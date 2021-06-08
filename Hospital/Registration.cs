using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Registration : Form
    {
        
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonRegistrate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxName.Text, out int Name))
            {
                MessageBox.Show("Name cant contain numbers");
                textBoxName.Clear();
                return;
            }
            if (int.TryParse(textBoxSurname.Text, out int Surname))
            {
                MessageBox.Show("Surname cant contain numbers");
                textBoxSurname.Clear();
                return;
            }
            if (int.TryParse(textBoxPatronymic.Text, out int Patronymic))
            {
                MessageBox.Show("Patronymic cant contain numbers");
                textBoxPatronymic.Clear();
                return;
            }
            if (int.TryParse(textBoxDepartment.Text, out int Department))
            {
                MessageBox.Show("Department cant contain numbers");
                textBoxDepartment.Clear();
                return;
            }
            Doctor doctor = new Doctor
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                Patronymic = textBoxPatronymic.Text,
                Department = textBoxDepartment.Text,
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                Paсients = new List<Patient>()
                
        };

            var writer = new JsonMethods();
            var doctors = writer.GetAllDoctors();

            doctors.Add(doctor);
            writer.WriteDoctor(doctors);
            this.Hide();
            Form1 _form1 = new Form1();
            _form1.Show();
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void Department_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 _form1 = new Form1();
            _form1.Show();
        }
    }
}
