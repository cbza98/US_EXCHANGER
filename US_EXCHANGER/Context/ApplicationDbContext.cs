using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(string ConnectionString) : base (ConnectionString)
        {

        }
    }
}
