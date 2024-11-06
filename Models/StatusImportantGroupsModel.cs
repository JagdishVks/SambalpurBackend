using System.ComponentModel.DataAnnotations.Schema;


namespace dharmendraPradhan.Models
{
    [Table("tbl_S_3_1")]
    public class StatusImportantGroupsModel
    {

        public int id { get; set; }
        public string Loc_ID { get; set; }
        public string P_Name { get; set; }
        public string P_Community { get; set; }
        public string P_Mobile { get; set; }
        public string P_Party { get; set; }
    }
}
