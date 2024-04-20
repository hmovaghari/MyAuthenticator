using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAuthenticator.FramworkData.Context
{
    [Table("Setting")]
    public class Setting
    {
        [Key]
        public int SettingID { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        public string Value { get; set; }
    }
}
