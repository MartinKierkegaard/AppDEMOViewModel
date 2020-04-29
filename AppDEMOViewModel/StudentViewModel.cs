using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDEMOViewModel
{
    public class StudentViewModel
    {
        public Student Student { get; set; }

        public StudentViewModel()
        {
            Student = new Student() {Navn = "Martin" };
        }

    }
}
