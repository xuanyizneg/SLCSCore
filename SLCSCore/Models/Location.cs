using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLCSCore.Models
{
    public class Location
    {
        [Key]
        [Column(TypeName = "int")]
        public int L_Id { get; set; }

        [Display(Name = "館藏地")]
        [Column(TypeName = "nvarchar(10)")]
        public string L_Location { get; set; }

        [Display(Name = "館藏地址")]
        [StringLength(250)]
        public string L_Address { get; set; }

        [Display(Name ="館藏電話")]
        [StringLength(10)]
        public string L_Phone { get; set; }

        public List<Book> Books { get; set; }
    }
}
