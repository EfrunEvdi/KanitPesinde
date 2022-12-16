using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DetectiveStory
    {
        [Key]
        public int DetectiveStoryID { get; set; }    
        public string DetectiveTitle1 { get; set; }
        public string DetectiveDescription1 { get; set; }
        public string DetectiveImage1 { get; set; }
        public string DetectiveTitle2 { get; set; }
        public string DetectiveDescription2 { get; set; }
        public string DetectiveImage2 { get; set; }


    }
}
