using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulZil
{
    public partial class mondayLessons : Form
    {
        public mondayLessons()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mondayLessons_Load(object sender, EventArgs e)
        {
            lesson1Student.Value = Convert.ToDateTime(Properties.Lessons.Default.monday_1_student.ToString());
            lesson1Teacher.Value = Convert.ToDateTime(Properties.Lessons.Default.monday_1_teacher.ToString());
            lesson1Exit.Value = Convert.ToDateTime(Properties.Lessons.Default.monday_1_exit.ToString());

            lesson2Student.Value = Convert.ToDateTime(Properties.Lessons.Default.monday_2_student.ToString());
            lesson2Teacher.Value = Convert.ToDateTime(Properties.Lessons.Default.monday_2_teacher.ToString());
            lesson2Exit.Value = Convert.ToDateTime(Properties.Lessons.Default.monday_2_exit.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ders saatleri başarıyla güncellendi.", "Okul Zil Programı");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Değişikliler başarı ile kayıt edildi.");
            this.Close();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime dt = lesson1Student.Value;
            TimeSpan lesson1 = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            Properties.Lessons.Default["monday_1_student"] = lesson1;
            Properties.Lessons.Default.Save();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lesson1_Teacher_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = lesson1Teacher.Value;
            TimeSpan lesson1 = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            Properties.Lessons.Default["monday_1_teacher"] = lesson1;
            Properties.Lessons.Default.Save();
        }

        private void dateTimePicker23_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = lesson1Exit.Value;
            TimeSpan lesson1 = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            Properties.Lessons.Default["monday_1_exit"] = lesson1;
            Properties.Lessons.Default.Save();
        }

        private void lesson2Student_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = lesson2Student.Value;
            TimeSpan lesson2 = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            Properties.Lessons.Default["monday_2_student"] = lesson2;
            Properties.Lessons.Default.Save();
        }

        private void lesson2Teacher_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = lesson2Teacher.Value;
            TimeSpan lesson2 = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            Properties.Lessons.Default["monday_2_teacher"] = lesson2;
            Properties.Lessons.Default.Save();
        }

        private void lesson2Exit_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = lesson2Exit.Value;
            TimeSpan lesson2 = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            Properties.Lessons.Default["monday_2_exit"] = lesson2;
            Properties.Lessons.Default.Save();
        }
    }
}
