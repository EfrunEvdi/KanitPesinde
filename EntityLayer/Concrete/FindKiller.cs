using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FindKiller
    {
        [Key]
        public int FindKillerID { get; set; }
        public string FindKillerName { get; set; }
        public string FindKillerClose { get; set; }
        public string FindKillerImage { get; set; }
        public bool FindKillerStatus { get; set; }
       
    }
}
