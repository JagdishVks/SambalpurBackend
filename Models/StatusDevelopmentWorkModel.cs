using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{
    [Table("tbl_S_7")]
    public class StatusDevelopmentWorkModel
    {
        public int Id { get; set; }
        public string Loc_ID { get; set; }
        public string MLA_Work_Done { get; set; } 
    }
}
