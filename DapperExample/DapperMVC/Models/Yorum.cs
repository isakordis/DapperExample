using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperMVC.Models
{
    public class Yorum
    {
        
        public int y_id { get; set; }
        public string y_name { get; set; }
        public string y_detail { get; set; }
        public DateTime y_date { get; set; }
        public int y_newsID { get; set; }




    }
}