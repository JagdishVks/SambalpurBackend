
using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{

    [Table("tbl_booth_wise_results")]
    public class StatusResultsModel 
    {


        public int Id { get; set; }
        public string Loc_ID { get; set; }
        public string BJP { get; set; }
        public string BJD { get; set; }
        public string INC { get; set; }
        public string OTH { get; set; }
        public string Total { get; set; }
    }
}
