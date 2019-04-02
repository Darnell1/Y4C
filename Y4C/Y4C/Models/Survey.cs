using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Y4C.Models
{
    public class Survey
    {
        /**
        [Key]
        public int Id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public string answerType { get; set; }
        public string user { get; set; }
        public string theme { get; set; }
        */

        [Key]
        public int Id { get; set; }
        [ForeignKey("Account")]
        public int UserId { get; set; }
        [ForeignKey("AC")]

        public int ThemeId { get; set; }
        
        public IList<Questions> Question { get; set; }
        public IList<AddContent> Themes { get; set; }
        //public IList<Account> Users { get; set; }//
    }
}
