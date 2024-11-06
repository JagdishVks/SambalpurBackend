using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{
    [Table("tbl_S_18")]
    public class StatusGovtOfficialsWorkingModel
    {
        public int Id { get; set; }
        public string Loc_ID { get; set; }
        public string Designation { get; set; }
        public string Worker_Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Community { get; set; }
        public string Mobile { get; set; }
    }
}
