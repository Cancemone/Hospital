using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var reader = new JsonMethods();
            var doctors = reader.GetAllDoctors();
            var currentDoctor = doctors.FirstOrDefault(d => d.Login == textBoxLogin.Text && d.Password == textBoxPassword.Text);
            if (currentDoctor == null)
            {
                labelFail.Text = "Data entered incorrectly";
            }
            else
            {
                Hide();
                EditPatientForm main = new EditPatientForm(currentDoctor);
                main.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
