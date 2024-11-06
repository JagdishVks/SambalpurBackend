 using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{
    [Table("YourTableName")]  
    public class GetLocIDAndBoothModel
    {
        public int Id { get; set; }
        public string Loc_ID { get; set; }
        public string Booth_no { get; set; }
        public string AC_Name { get; set; }
        public string Village_Name { get; set; }
    }
}
