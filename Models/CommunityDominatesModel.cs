using System.ComponentModel.DataAnnotations.Schema;
namespace dharmendraPradhan.Models
{
    [Table("tbl_S_3")]
    public class CommunityDominatesModel
    {

        public int id { get; set; }
        public string  AC_Name { get; set; }
        public string  Village_Name { get; set; }
        public string Loc_Id { get; set; }
        public string P_Name { get; set; }

    }
}
