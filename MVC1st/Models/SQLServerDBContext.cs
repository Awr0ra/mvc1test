namespace MVC1st.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SQLServerDBContext : DbContext
    {
        public SQLServerDBContext(): base("name=SQLServerDBContext")
        {
        }

        public System.Data.Entity.DbSet<MVC1st.Models.SQLServerUserAccount> SQLServerUserAccounts { get; set; }

        //public virtual DbSet<SQLServerUserAccount> SQLServerUserAccounts { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<SQLServerUserAccount>()
        //        .Property(e => e.UserLogin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SQLServerUserAccount>()
        //        .Property(e => e.UserPassword)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SQLServerUserAccount>()
        //        .Property(e => e.UserEmail)
        //        .IsUnicode(false);
        //}

    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data.Entity;
//using System.Data.Entity.Infrastructure;

//namespace MVC1st.Models
//{

//       /// <summary>
//        /// Entity Framework Connection String
//        /// https://www.youtube.com/watch?v=EG3GykWhuR8
//        /// </summary>
//        public partial class SQLServerDBContext : DbContext
//        {
//            public SQLServerDBContext(): base("name=SQLServerDBContext")
//            {
//            }

//            public virtual DbSet<User> Users { get; set; }

//            protected override void OnModelCreating(DbModelBuilder modelBuilder)
//            {
//                modelBuilder.Entity<User>()
//                    .Property(e => e.UserLogin)
//                    .IsUnicode(false);

//                modelBuilder.Entity<User>()
//                    .Property(e => e.UserPassword)
//                    .IsUnicode(false);

//                modelBuilder.Entity<User>()
//                    .Property(e => e.UserEmail)
//                    .IsUnicode(false);
//            }

//            public System.Data.Entity.DbSet<SQLServerUserAccount> SQLServerUserAccounts { get; set; }

//    }


//}