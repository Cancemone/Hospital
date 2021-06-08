using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Department { get; set; }
       public List<Patient> Paсients { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
