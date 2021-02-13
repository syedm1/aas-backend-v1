using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class AASItem
    {        
        public int Id { get; set; }        
        public string UniqueTitle { get; set; }
        public string SubTitle { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string SourceUrl { get; set; }
        public string InputModel { get; set; }
        public string OutputModel { get; set; }        
        public bool IsPaid { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
