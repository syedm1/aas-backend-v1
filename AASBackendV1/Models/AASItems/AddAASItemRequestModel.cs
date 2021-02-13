using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.AASItems
{
    public class AddAASItemRequestModel
    {
        [Required]
        public string UniqueTitle { get; set; }
        
        [Required]
        public string SubTitle { get; set; }
        
        [Required]
        public string Publisher { get; set; }
        
        [Required]
        public string Description { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public string SourceUrl { get; set; }        
        public string InputModel { get; set; }
        public string OutputModel { get; set; }       

        public bool IsPaid { get; set; }      
   
        

    }
}
