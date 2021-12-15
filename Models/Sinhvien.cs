using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace TungSon
{
    [Table("Sinhvien")]
    public class Sinhvien 
    {
        [Key,StringLength(20),Display(Name ="ID")]
        public string SVId {get;set;}
        [Required, StringLength(50),Display(Name ="Họ và tên")]
        public string SVname {get;set;}
        [Required, Display(Name ="Giới tính nam")]
        public bool SVgender {get;set;}
    }

    

}