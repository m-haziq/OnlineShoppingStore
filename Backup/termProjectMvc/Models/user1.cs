//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace termProjectMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    [MetadataType(typeof(UserRepo))]
    public partial class user1
    {
        public user1()
        {
            this.products = new HashSet<product>();
        }
    
        public int Id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string country { get; set; }
        public string password { get; set; }
    
        public virtual ICollection<product> products { get; set; }
    }
}
