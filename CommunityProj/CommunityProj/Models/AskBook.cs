using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace CommunityProj.Models
{
    public class AskBook
    {

            public int ID { get; set; }
            public string FirstName { get; set; }
            public string BookTitle { get; set; }


        //   public class AskBookdbContext : DbContext
        //{
        //        public DbSet<AskBook> AskBooks { get; set; }
        //}
               
    }
}