using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMC.WApp.Models
{
    public class ShiftViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public DateTime From { set; get; }

        public DateTime To { set; get; }

        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }

        public string Description { set; get; }

        public bool Status { set; get; }
    }
}
