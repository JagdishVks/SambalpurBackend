using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{



    [Table("tbl_S_10")]
    public class StatusCommunityPeopleModel
    {
        public int id { get; set; }

        public string Loc_ID { get; set; }
        public string Category { get; set; }
        public string Community { get; set; }
        public string Vote {  get; set; }

        public string Imp_Name_1 {  get; set; }
        public string Imp_Name_2 { get; set; }
        public string Imp_Name_3 { get; set; }
        public string Imp_Mobile_1 { get; set; }
        public string Imp_Mobile_2 { get; set; }
        public string Imp_Mobile_3 { get; set; }
        public string Party { get; set; }
        public string Party_2 { get; set; }
        public string Party_3 { get; set; }

    }
}
