using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{
    [Table("tbl_S_23")]
    public class StatusAreaDevelopModel
    {
        public int Id { get; set; }
        public string Loc_ID { get; set; }
        public string Area { get; set; }
        public string Date_of_Update { get; set; }
    }
}
