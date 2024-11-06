using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{

    [Table("tbl_S_14")]
    public class StatusPanchayatMemweberModel
    {
        public int id {  get; set; }
        public string Loc_ID {  get; set; }
        public string Worker_Name { get ; set; }


        public string Party { set; get; }

        public string Community { set; get; }

        public string Gender { set; get; }

        public string Age { set; get; }

        public string Mobile { set; get; }

        public string Effect { set; get; }


    }

    
}
