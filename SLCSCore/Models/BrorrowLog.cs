using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLCSCore.Models
{
    public class BrorrowLog
    {
        [Key]
        [Column(TypeName = "int")]
        public int BL_Id { get; set; }

        [Display(Name = "借閱時間")]
        [Column(TypeName = "datetime")]
        public DateTime BL_BorrowTime { get; set; }

        [Display(Name = "歸還時間")]
        [Column(TypeName = "datetime")]
        public DateTime BL_ReturnTime { get; set; }

        //外來鍵
        [Display(Name = "借閱書籍ID")]
        public int B_Id { get; set; }

        //外來鍵
        [Display(Name = "借閱人ID")]
        public int U_Id { get; set; }
    }                  
}
