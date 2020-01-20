using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FinalProject
{
    public class TestScore
    {
        [Key]
        public int TestId { get; set; }
        public float Score { get; set; }

    }
}
