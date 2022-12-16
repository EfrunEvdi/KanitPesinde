using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SceneTwo
    {
        [Key]
        public int SceneTwoID { get; set; }
        public string SceneTwoTitle { get; set; }
        public string SceneTwoDescription { get; set; }
        public string SceneTwoImage { get; set; }
    }
}
