using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class EditPatientForm : Form
    {
        private readonly Doctor _currentDoctor;
        
        public EditPatientForm(Doctor currentDoctor)
        {
            _currentDoctor = currentDoctor;
            InitializeComponent();
        }
        public void PrintPatients(List<Patient> patients)
        {
            dataGridView1.Rows.Clear();
            foreach (var u in patients)
            {
                var result = string.Join(",", u.Medicine);

                dataGridView1.Rows.Add(u.Surname, u.Name, u.Patronymic, u.Diagnosis, u.Department, u.Сhamber, result, u.Entrance, u.Discharge, u.Guid);

            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrintPatients(_currentDoctor.Paсients);

            //сохранение
            List<Patient> patients = new List<Patient>();
            foreach (DataGridViewRow s in dataGridView1.Rows)
            {
                Patient patient = new Patient
                {
                    Guid = Guid.NewGuid(),
                    Name = (string)s.Cells[0].Value,
                    Surname = (string)s.Cells[1].Value,
                    Patronymic = (string)s.Cells[2].Value,
                    Diagnosis = (string)s.Cells[3].Value,
                    Department = (string)s.Cells[4].Value,
                    Сhamber = (int)s.Cells[5].Value,
                    Medicine = s.Cells[6].Value.ToString()?.Split(',').ToList(),
                    Entrance = (DateTime)s.Cells[7].Value,
                    Discharge = (DateTime)s.Cells[8].Value
                };
                //сохранение
                patients.Add(patient);
            }
            
            var writer = new JsonMethods();
            var doctors = writer.GetAllDoctors();
            doctors.Find(x => x.Login == _currentDoctor.Login).Paсients = patients;
            writer.WriteDoctor(doctors);
            Environment.Exit(0);
        }
        
        private void EditPatientForm_Load(object sender, EventArgs e)
        {
            foreach (var u in _currentDoctor.Paсients)
            {
                var result = string.Join(",", u.Medicine);

                dataGridView1.Rows.Add(u.Surname, u.Name, u.Patronymic, u.Diagnosis, u.Department, u.Сhamber, result, u.Entrance, u.Discharge, u.Guid);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow s in dataGridView1.SelectedRows)
            {
                Patient patient = new Patient
                {
                    Guid = Guid.Parse(s.Cells[9].Value.ToString()),
                    Name = (string)s.Cells[0].Value,
                    Surname = (string)s.Cells[1].Value,
                    Patronymic = (string)s.Cells[2].Value,
                    Diagnosis = (string)s.Cells[3].Value,
                    Department = (string)s.Cells[4].Value,
                    Сhamber = Convert.ToInt32(s.Cells[5].Value),
                    Medicine = s.Cells[6].Value.ToString()?.Split(',').ToList(),
                    Entrance = Convert.ToDateTime(s.Cells[7].Value),
                    Discharge = Convert.ToDateTime(s.Cells[8].Value)
                };

                Patient findPat = _currentDoctor.Paсients.Find(p => p.Guid == patient.Guid);
                _currentDoctor.Paсients.Remove(findPat);
                dataGridView1.Rows.Remove(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            AddPatientForm addPat = new AddPatientForm(_currentDoctor);
            addPat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int searching = dataGridView1.CurrentCell.RowIndex;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (searching < dataGridView1.RowCount - 1) searching++; else searching = 0;
                for (int column = 0; column < 10; column++)
                {
                    if (dataGridView1[column, searching].FormattedValue.ToString().
                        Contains(textBox1.Text.Trim()))
                    {
                        dataGridView1.CurrentCell = dataGridView1[0, searching];
                        return;
                    }
                }
            }
            MessageBox.Show("Nothing was found");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var list = _currentDoctor.Paсients.Where(p => p.Department.ToLower() == comboBox1.Text.ToLower()).ToList();
            if(list==null || list.Count <= 0)
            {
                MessageBox.Show("Nothing was found");
                return;
            }

            PrintPatients(list);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintPatients(_currentDoctor.Paсients);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var list = _currentDoctor.Paсients.Where(p => p.Сhamber.ToString().ToLower() == comboBox2.Text.ToLower()).ToList();
            if (list == null || list.Count <= 0)
            {
                    MessageBox.Show("Nothing was found");
                return;
            }

            PrintPatients(list);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var list = _currentDoctor.Paсients
            .Where(p => p.Entrance.Day == dateTimePicker1.Value.Day
                 && p.Entrance.Month == dateTimePicker1.Value.Month
                 && p.Entrance.Year == dateTimePicker1.Value.Year)
            .ToList();
            if (list == null || list.Count <= 0)
            {
                MessageBox.Show("Nothing was found");
                return;
            }

            PrintPatients(list);
        }
    }
}