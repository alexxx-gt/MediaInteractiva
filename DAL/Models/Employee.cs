using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsMIEmployee { get; set; }

        public List<Animal> Animals { get; set; }
    }
}
