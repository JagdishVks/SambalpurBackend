using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{
    [Table("tbl_S_17")]
    public class StatusBoothAgentModel
    {
      public int Id { get; set; }
        public string Loc_ID { get; set; }
        public string Booth_no_Agent { get; set; }
        public string Party { get; set; }
        public string Booth_Agent_Name { get; set; }
        public string Community { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Mobile { get; set; }


    }
}
