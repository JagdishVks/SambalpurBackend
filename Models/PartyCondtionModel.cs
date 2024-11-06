using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{


    [Table("tbl_S_4")]
    public class PartyCondtionModel 
    {



        public int id { get; set; }
        public string Loc_ID { get; set; }
        public string BJP { get; set; }
        public string BJD { get; set; }
        public string INC { get; set; }
        public string Others { get; set; }


    }
}
