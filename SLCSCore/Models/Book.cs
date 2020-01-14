using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLCSCore.Models
{
    public class Book
    {
        [Key]
        [Column(TypeName = "int")]
        public int B_Id { get; set; }

        [Display (Name="書籍名稱")]
        [Column(TypeName = "nvarchar(200)")]
        public string B_BookName { get; set; }

        [Display(Name = "作者")]
        [Column(TypeName = "nvarchar(200)")]
        public string B_Author { get; set; }

        [Display(Name = "出版社")]
        [Column(TypeName = "nvarchar(200)")]
        public string B_Publisher { get; set; }

        [Display(Name = "出版區域")]
        [Column(TypeName = "nvarchar(200)")]
        public string B_PublishPlace { get; set; }

        [Display(Name = "出版年度")]
        [Column(TypeName = "varchar(4)")]
        public string B_PublishYear { get; set; }

        [Display(Name = "ISBN")]
        [Column(TypeName = "nvarchar(200)")]
        public string B_Isbn { get; set; }

        [Display(Name = "書籍類別代碼")]
        [Column(TypeName = "nvarchar(200)")]
        public int B_TopicCode { get; set; }

        [Display(Name = "書籍狀態代碼")]
        [Column(TypeName = "nvarchar(10)")]
        public string B_BookStatusCode { get; set; }

      
        [Display(Name = "館藏地代碼")]
        public int L_Id { get; set; }

        public List<BrorrowLog> BrorrowLogs { get; set; }

        public List<Reserve> Reserves { get; set; }

    }
}
