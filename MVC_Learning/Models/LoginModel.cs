using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace MVC_Learning.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter username")]
        [DataType(DataType.Text)]
        [Display(Name ="Username")]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage= "Please enter Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(10)]
        public string Password { get; set; }

    }

    [Table("tblUser")]
    public class tblUser
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
