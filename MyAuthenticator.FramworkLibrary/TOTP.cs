using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ZXing.Common;
using ZXing;
using System.Drawing;
using ZXing.QrCode.Internal;
using System.Web;
using System.Runtime.Remoting.Messaging;

namespace MyAuthenticator.FramworkLibrary
{
    public class TOTP
    {
        const long unixEpochTicks = 621355968000000000L;

        const long ticksToSeconds = 10000000L;

        private const int step = 30;

        private const int totpSize = 6;

        private byte[] key;

        public static byte[] GetSecretKey(string secretKey)
        {
            if (string.IsNullOrEmpty(secretKey))
            {
                return null;
            }
            var totp = new TOTP(secretKey);
            return totp.key;
        }

        public static string GetSecretKey(byte[] secretKey)
        {
            return Base32Encoding.ToString(secretKey);
        }

        public TOTP(byte[] secretKey)
        {
            key = secretKey;
        }

        public TOTP(string secretKey)
        {
            var bytes = Base32Encoding.ToBytes(secretKey);
            key = bytes;
        }

        public string ComputeTotp()
        {
            var window = CalculateTimeStepFromTimestamp(DateTime.UtcNow);

            var data = GetBigEndianBytes(window);

            var hmac = new HMACSHA1();
            hmac.Key = key;
            var hmacComputedHash = hmac.ComputeHash(data);

            int offset = hmacComputedHash[hmacComputedHash.Length - 1] & 0x0F;
            var otp = (hmacComputedHash[offset] & 0x7f) << 24
                   | (hmacComputedHash[offset + 1] & 0xff) << 16
                   | (hmacComputedHash[offset + 2] & 0xff) << 8
                   | (hmacComputedHash[offset + 3] & 0xff) % 1000000;

            var result = Digits(otp, totpSize);

            return result;
        }

        public int RemainingSeconds()
        {
            return step - (int)(((DateTime.UtcNow.Ticks - unixEpochTicks) / ticksToSeconds) % step);
        }

        private byte[] GetBigEndianBytes(long input)
        {
            // Since .net uses little endian numbers, we need to reverse the byte order to get big endian.
            var data = BitConverter.GetBytes(input);
            Array.Reverse(data);
            return data;
        }

        private long CalculateTimeStepFromTimestamp(DateTime timestamp)
        {
            var unixTimestamp = (timestamp.Ticks - unixEpochTicks) / ticksToSeconds;
            var window = unixTimestamp / (long)step;
            return window;
        }

        private string Digits(long input, int digitCount)
        {
            var truncatedValue = ((int)input % (int)Math.Pow(10, digitCount));
            return truncatedValue.ToString().PadLeft(digitCount, '0');
        }

        public static string GenerateUrl(string title, string code)
        {
            return $"otpauth://totp/{title}?secret={code}";
        }

        private static Dictionary<string, string> ReadOtpFromBitmap(Bitmap image)
        {
            try
            {
                var res = new Dictionary<string, string>();
                var options = new DecodingOptions { PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE }, TryHarder = true };
                var reader = new BarcodeReader(null, null, ls => new GlobalHistogramBinarizer(ls)) { AutoRotate = false, TryInverted = false, Options = options };
                var otpResult = reader.Decode(image);
                if (otpResult != null)
                {
                    var otpUri = new Uri(otpResult.Text);
                    res.Add("Name", otpUri.Segments[1].TrimEnd('/'));
                    string query = otpUri.Query;
                    var queryParameters = HttpUtility.ParseQueryString(query);
                    res.Add("Secret", queryParameters["secret"]);
                    res.Add("Digits", queryParameters["digits"]);
                }
                else
                {
                    return null;
                }
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Dictionary<string, string> ReadOtp(string fileName)
        {
            try
            {
                using (Bitmap image = (Bitmap)Bitmap.FromFile(fileName))
                {
                    return ReadOtpFromBitmap(image);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Dictionary<string, string> ReadOtp(Bitmap image)
        {
            try
            {
                return ReadOtpFromBitmap(image);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
