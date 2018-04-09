using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
//

namespace PartyInvitesSheilferZepeda.Models
{
    [MetadataType(typeof(GuestResponse))]
    public class GuestResponse
    {
        [Key]
   
        public string Name { get; set; }
        [EmailAddress, Required]
        	[RegularExpression(@"^([a - zA - Z0 - 9_\-\.]+)@([a - zA - Z0 - 9_\-\.]+)\.([a - zA - Z]{2,5})$")]
        public string Email { get; set; }
        [Range(1, 25,
       ErrorMessage = "Name cannot be empty")]
        public string Phone { get; set; }
        [Required] 
        public bool? WillAttend { get; set; }
    }
}