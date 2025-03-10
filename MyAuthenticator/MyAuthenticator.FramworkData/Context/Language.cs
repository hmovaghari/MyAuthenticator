namespace MyAuthenticator.FramworkData.Context
{
    public enum Language
    {
        English,
        Farsi,
    }

    public static class LanguageEX
    {
        public static string Name(this  Language language) => language.ToString();

        public static string Title(this Language language)
        {
            switch (language)
            {
                case Language.English:
                    return "انگلیسی";
                case Language.Farsi:
                    return "فارسی";
                default:
                    return string.Empty;
            }
        }

        public static string Ket(this Language language) => "Language";
    }
}
