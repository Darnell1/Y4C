using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Y4C.Models
{
    public class Survey
    {
        [Key]
        public int id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public string theme { get; set; }
        public string user { get; set; }
        public string answertype { get; set; }
    }
}
