using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{
    [Table("tbl_Location")]
    public class StatusGetAllLocsModel
    {
        public int Id { get; set; }
        public string AC_Name { get; set; }

        public string State_Name { get; set; }
        public string Village_Name { get; set; }
        public string Loc_ID { get; set; }
    }
}
