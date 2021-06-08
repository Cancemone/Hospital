using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Hospital
{
    public class JsonMethods
    {
        public List<Doctor> GetAllDoctors()
        {

            // read file into a string and deserialize JSON to a type
            List<Doctor> doctors = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText(Directory.GetCurrentDirectory() + "\\doctors.json"));
            return doctors;
        }
        public void WriteDoctor(List<Doctor> doctors)
        {

            // serialize JSON to a string and then write string to a file
            File.WriteAllText(Directory.GetCurrentDirectory() +"\\doctors.json", JsonConvert.SerializeObject(doctors,Formatting.Indented));
        }
        public List<Patient> GetPatients(Doctor doctor)
        {
            List<Patient> patients =
                JsonConvert.DeserializeObject<List<Patient>>(
                    File.ReadAllText(Directory.GetCurrentDirectory() + "\\doctors.json"));
            return patients;
        }
    }
}
