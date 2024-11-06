using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{  

    [Table("{tbl_S_12}")]
    public class StatusMainWorkerModel
    {
      
        public int id { get; set; }
        public string Loc_ID { get; set; }
        public string Party {  get; set; }
        public string Worker_Name { get; set; }

        public string Communtiy { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; } 

        public string Mobile { get; set; }

        public string Effect { get; set; }
        
    }
}
