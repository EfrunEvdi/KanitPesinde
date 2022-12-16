using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SceneOne
    {
        [Key]
        public int SceneOneID { get; set; }
        public string SceneOneTitle { get; set; }
        public string SceneOneDescription { get; set; }
        public string SceneOneImage { get; set; }
    }
}
