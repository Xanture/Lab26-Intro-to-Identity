using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab26_brian.Models
{
    public class CMS
    {
        [Key]
        public int CustomerID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [DisplayName("Image URL")]
        public string ImageURL { get; set; }
        public bool IsPublished { get; set; }
    }
}
