using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Postal;

namespace CommunityProj.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public class BookDBContext : DbContext
        {
            public DbSet<Book> Books { get; set; }
        }

    }




    public class ReserveBook
    {


        public int ReserveID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public class ReserveBookDBContext : DbContext
        {
            public DbSet<ReserveBook> ReserveBooks { get; set; }
        }

    }
    //public class AskBook
    //{

    //    public string FirstName { get; set; }
    //    public string BookTitle { get; set; }


    //    public class AskBookdbContext : DbContext
    //    {
    //        public DbSet<AskBook> AskBooks { get; set; }
    //    }

    //}








    //public class NewCommentEmail : Email
    //{

    //    public string To { get; set; }
    //    public string UserName { get; set; }
    //    public string Comment { get; set; }
    //}
















}
















    


   







    
        

    












