using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.AASItems
{
    public class AASItemResponse
    {
        public string UniqueTitle { get; set; }
        public string SubTitle { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string SourceUrl { get; set; }        
        public string InputModel { get; set; }
        public string OutputModel { get; set; }
        
        [Range(typeof(bool), "true", "false")]
        public bool IsPaid { get; set; }      
   
        

    }
}
