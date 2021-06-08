using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class AddPatientForm : Form
    {
        private Doctor currentDoctor;
        

        public AddPatientForm(Doctor doctor)
        {
            currentDoctor = doctor;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int Name))
            {
                MessageBox.Show("Name cant contain numbers");
                textBox1.Clear();
                return;
            }
            if (int.TryParse(textBox2.Text, out int Surname))
            {
                MessageBox.Show("Surname cant contain numbers");
                textBox1.Clear();
                return;
            }
            if (int.TryParse(textBox3.Text, out int Patronymic))
            {
                MessageBox.Show("Patronymic cant contain numbers");
                textBox1.Clear();
                return;
            }
            if (int.TryParse(textBox5.Text, out int Department))
            {
                MessageBox.Show("Department cant contain numbers");
                textBox1.Clear();
                return;
            }
            Patient patient = new Patient
            {
                Name = textBox1.Text,
                Surname = textBox2.Text,
                Patronymic = textBox3.Text,
                Diagnosis = textBox4.Text,
                Department = textBox5.Text,
                Сhamber = Convert.ToInt32(comboBox1.SelectedItem),
                Medicine = textBox7.Text.Split(',').ToList(),
                Entrance = dateTimePicker1.Value,
                Discharge = new DateTime(), 
            };
            currentDoctor.Paсients.Add(patient);
            MessageBox.Show("Пациент добавлен!");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            EditPatientForm functions = new EditPatientForm(currentDoctor);
            functions.Show();
        }
    }
}
