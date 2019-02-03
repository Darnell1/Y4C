using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Y4C.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string StudentFName { get; set; }
        public string StudentLName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentUser { get; set; }
        public string StudentPwd { get; set; }
        public string StudentDob { get; set; }
        public string StudentTakenYogaClass { get; set; }
    }
}
