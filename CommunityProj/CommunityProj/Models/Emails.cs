using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Postal;


namespace CommunityProj.Models
{
    public class NewCommentEmail : Email
    {

        public string To { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }
    }

}
