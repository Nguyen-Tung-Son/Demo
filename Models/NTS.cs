using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace TungSon
{
    [Table("NTS")]
    public class NTS 

    {
        [Key, StringLength(20), Display(Name = "ID")]
        public string NTSID {get;set;}
        [Required, StringLength(50), Display(Name ="Họ và tên")]
        public String NTSname {get;set;}
    }

}