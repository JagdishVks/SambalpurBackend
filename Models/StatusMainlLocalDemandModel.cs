
using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{

    [Table("tbl_S_9")]
    public class StatusMainLocalDemandModel
    {


        public int Id { get; set; }
        public string Loc_ID { get; set; }
        public string Main_Needs_of_People { get; set; }
    }
}
