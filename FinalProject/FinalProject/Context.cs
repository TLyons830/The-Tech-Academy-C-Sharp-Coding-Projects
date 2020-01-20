using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProject
{
    public class Context: DbContext
    {
        public Context(): base()
        {

        }

        public DbSet<TestScore> TestScores { get; set; }
    }
}
