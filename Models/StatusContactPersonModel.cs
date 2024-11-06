using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{
    [Table("tbl_S_21")]
    public class StatusContactPersonModel
    {
        public int Id { get; set; }
        public string Loc_ID { get; set; }
        public string Person_Name { get; set; }
        public string Community { get; set; }
        public string Mobile { get; set; }
    }
}
