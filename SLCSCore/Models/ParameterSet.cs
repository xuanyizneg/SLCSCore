using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLCSCore.Models
{
    public class ParameterSet
    {
        [Key]
        [Column(TypeName = "int")]
        public int PS_Id { get; set; }

        [Display (Name="參數類別")]
        [Column(TypeName = "nvarchar(100)")]
        public string PS_Type { get; set; }

        [Display(Name = "參數值")]
        [Column(TypeName = "nvarchar(100)")]
        public string PS_Value { get; set; }

        [Display(Name = "參數名稱")]
        [Column(TypeName = "nvarchar(100)")]
        public string PS_Name { get; set; }

        [Display(Name = "參數註記")]
        [Column(TypeName = "nvarchar(100)")]
        public string PS_Remark { get; set; }
    }
}
