using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//add using statement for data annotations
using System.ComponentModel.DataAnnotations;


namespace PortfolioSite.Models
{
    //add the metadata type to the contact
    [MetadataType(typeof(ContactFormValidation))]
    public partial class ContactForms 
    {
    
    }
    public class ContactFormValidation 
    {
        [Required, Display(Name ="Your Name")]
        public string Name { get; set; }
        public string CompanyName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, DataType(DataType.MultilineText)]
        public string Comments { get; set; }
    }




}

