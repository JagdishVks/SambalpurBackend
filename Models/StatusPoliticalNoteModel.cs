using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{
    [Table("tbl_S_20")]
    public class StatusPoliticalNoteModel
    {
        public int Id { get; set; }

        public string Loc_ID { get; set; }
        public string Position {  get; set; }
    }
}
