using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Sub_title { get; set; }
        public string Article { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public DateTime Publish_Date { get; set; }
        public int Comments_Quantity { get; set; }
        public int Order { get; set; }






    }
}
