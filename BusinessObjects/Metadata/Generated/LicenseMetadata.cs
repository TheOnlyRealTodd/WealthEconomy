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
    
    public class LicenseMetadata
    {
        [Display(Name = "Id")]
        public short Id { get; set; }
    
        [Display(Name = "Name")]
        public string Name { get; set; }
    
        [Display(Name = "Description")]
        public string Description { get; set; }
    
        [Display(Name = "Text")]
        public string Text { get; set; }
    
        [Display(Name = "CreatedOn")]
        public System.DateTime CreatedOn { get; set; }
    
        [Display(Name = "ModifiedOn")]
        public System.DateTime ModifiedOn { get; set; }
    
        [Display(Name = "DeletedOn")]
        public Nullable<System.DateTime> DeletedOn { get; set; }
    
    }
}
