//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Assignments.Models.Assign5
{  
    public partial class tblComment
    {
        public int Id { get; set; }
        [AllowHtml]
        [Required(ErrorMessage = " Name cannot be empty")]
        public string Name { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = "Comment cannot be empty")]
        public string Comments { get; set; }
    }
}
