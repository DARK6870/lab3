using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghost.Entity
{
    [Table("UserData")]
    public class User
    {
        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "UserName is required."), Column(TypeName = "nvarchar(30)"), MaxLength(30)]
        public string? Name { get; set; }


        [Column(TypeName = "nvarchar(50)"), MaxLength(50)]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Password is required."), MinLength(5, ErrorMessage = "Password is too short"), Column(TypeName = "nvarchar(250)")]
        public string? PasswordHash { get; set; }


        [Required(ErrorMessage = "FullName is required.")]
        public string? FullName { get; set; }


        [Required, MaxLength(1), Column(TypeName = "varchar(20)")]
        public string? Gender { get; set; }


        [Required(ErrorMessage = "Date birthday is required."), Column(TypeName = "date")]
        public DateTime? DateBrth { get; set; }


        [Required(ErrorMessage = "Main language is required."), MaxLength(20), Column(TypeName = "varchar(20)")]
        public string? MainLanguage { get; set; }


        [Required(ErrorMessage = "Other languages is required."), MaxLength(100), Column(TypeName = "varchar(100)")]
        public string? SecondLanguages {  get; set; }

    }
}
