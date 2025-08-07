using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Entities.ContacUs
{
   public class ContactUs
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsSeenByAdmin { get; set; }
    }
}
