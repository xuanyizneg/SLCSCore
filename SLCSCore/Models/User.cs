using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLCSCore.Models
{
    public class User
    {
        [Key]
        [Column(TypeName = "int")]
        public int U_Id { set; get; }

        [Display(Name = "使用者帳號")]
        [Column(TypeName = "nvarchar(10)")]
        public string U_Account { set;get;}

        [Display(Name = "身分證字號")]
        [Column(TypeName = "varchar(10)")]
        public string U_IdNumber { set;get;}

        [Display(Name = "使用者密碼")]
        [Column(TypeName = "nvarchar(12)")]
        public string U_Password { set;get;}

        [Display(Name = "聯絡電話")]
        [Column(TypeName = "nvarchar(10)")]
        public string U_Phone { set;get;}

        [Display(Name = "聯絡信箱")]
        [Column(TypeName = "nvarchar(100)")]
        public string U_Email { set;get;}

        public List<BrorrowLog> BrorrowLogs { get; set; }

        public List<Reserve> Reserves { get; set; }
    }
}
