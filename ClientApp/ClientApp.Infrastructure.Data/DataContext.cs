using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("Name=DefaultConnection")
        {

        }
    }

}
