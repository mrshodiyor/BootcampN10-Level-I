using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N7
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public DateTime BirthDay { get; set; }
        public int Age { get; set; }

        public int Payment { get; set; }

        public string EduType { get; set; }
    
        public bool IsPayment { get; set; }

        public int GetAge() => DateTime.Now.Year - BirthDay.Year;

    }


}
