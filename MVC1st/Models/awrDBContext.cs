using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// add by AWR
using System.Data.Entity;

namespace MVC1st.Models
{
    /// <summary>
    /// Code First: // https://www.youtube.com/watch?v=Uq0y8oxnx-8
    /// </summary>
    public class awrDBContext: DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }
    }

}