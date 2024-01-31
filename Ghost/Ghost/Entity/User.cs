using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghost.Entity
{
    [Table("UserData")]
    public class User
    {
        [Required, Key]
        public int ID { get; set; }


        [Required, Column(TypeName = "nvarchar(30)"), MaxLength(30)]
        public string Name { get; set; }


        [Required, Column(TypeName = "nvarchar(50)"), MaxLength(50)]
        public string Email { get; set; }


        [Required, Column(TypeName = "nvarchar(250)")]
        public string PasswordHash { get; set; }


        [Required]
        public string FullName { get; set; }


        [Required, MaxLength(1), Column(TypeName = "varchar(20)")]
        public string Gender { get; set; }


        [Required, Column(TypeName = "date")]
        public DateTime DateBrth { get; set; }


        [Required, MaxLength(20), Column(TypeName = "varchar(20)")]
        public string MainLanguage { get; set; }


        [Required, MaxLength(100), Column(TypeName = "varchar(100)")]
        public string SecondLanguages {  get; set; }

    }
}
