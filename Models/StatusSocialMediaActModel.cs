using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{

    [Table("tbl_S_16")]
    public class StatusSocialMediaActModel
    {
        public int id { get; set; }

        public string Loc_ID {  get; set; }
        public string Worker_Name {  get; set; }
        public string Gender { get; set; }
        public string Age { set; get; }
        public string Community {  set; get; }
        public string Party { set; get; }
        public string Mobile { set; get; }


    }
}
