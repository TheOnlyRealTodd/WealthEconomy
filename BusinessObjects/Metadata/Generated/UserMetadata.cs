//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessObjects.Metadata.Generated
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public class UserMetadata
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
    
        [Display(Name = "Email")]
        public string Email { get; set; }
    
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
    
        [Display(Name = "MiddleName")]
        public string MiddleName { get; set; }
    
        [Display(Name = "LastName")]
        public string LastName { get; set; }
    
        [Display(Name = "UserAccountTypeId")]
        public UserAccountType UserAccountTypeId { get; set; }
    
        [Display(Name = "Notes")]
        public string Notes { get; set; }
    
        [Display(Name = "CreatedOn")]
        public System.DateTime CreatedOn { get; set; }
    
        [Display(Name = "ModifiedOn")]
        public System.DateTime ModifiedOn { get; set; }
    
        [Display(Name = "DeletedOn")]
        public Nullable<System.DateTime> DeletedOn { get; set; }
    
    }
}
