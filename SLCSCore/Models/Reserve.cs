using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLCSCore.Models
{
    public class Reserve
    {
        [Key]
        [Column(TypeName = "int")]
        public int R_Id { get; set; }

        [Display(Name ="預約時間")]
        [Column(TypeName = "datetime")]
        public DateTime R_ReverseTime { get;set;}

        //外來鍵
        [Display(Name = "預約書籍ID")]
        [Column(TypeName = "int")]
        public int B_Id { get;set;}

        //外來鍵
        [Display(Name = "預約人ID")]
        [Column(TypeName = "int")]
        public int U_Id { get;set;}
    }
}
