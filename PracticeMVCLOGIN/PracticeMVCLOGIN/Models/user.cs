//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticeMVCLOGIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {
        public int id { get; set; }



        
        [DisplayName("USERNAME")]
        [Required]
        public string username { get; set; }


        
        
        [DisplayName("PASSWORD")]
        [DataType(DataType.Password)]
        [Required]
        public string password { get; set; }
    }
}
