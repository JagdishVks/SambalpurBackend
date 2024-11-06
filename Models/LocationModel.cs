using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{
    [Table("tbl_Location")]
    public class LocationModel
    {
        public int Id { get; set; }
        public string State_Name { get; set; }
        public string PC_Name { get; set;  }
        public string AC_Name { get; set; }
        public string Village_Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
