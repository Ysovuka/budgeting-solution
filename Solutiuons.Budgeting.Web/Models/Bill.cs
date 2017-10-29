using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Solutiuons.Budgeting.Web.Models
{
    public class Bill
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Schedule { get; set; }
        public double MinimumPayment { get; set; }
        public bool AllDay { get; set; }
    }
}
