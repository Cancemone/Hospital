using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Patient
    {
        public Guid Guid { get; set; }
        
        public string Name { get; set; }
        
        public string Surname{ get; set; }
        
        public string Patronymic { get; set; }
        
        public string Diagnosis { get; set; }
        
        public string Department { get; set; }
        
        public int Сhamber { get; set; }
        
        public List<string> Medicine { get; set; }
        
        public DateTime Entrance { get; set; }
        
        public DateTime Discharge { get; set; }
    }
}
