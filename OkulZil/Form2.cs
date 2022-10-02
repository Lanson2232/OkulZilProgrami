using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OkulZil
{
    public partial class generalSettings : Form
    {
        public generalSettings()
        {
            InitializeComponent();
        }

        private void studentAlertChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog studentAlertFile = new OpenFileDialog();
            studentAlertFile.Filter = "Media File(*.wav)|*.wav;";
            studentAlertFile.InitialDirectory = Application.StartupPath;
            studentAlertFile.Title = "Öğrenci Zil Sesi Seç";
            studentAlertFile.ShowDialog();
            
            studentAlert.Text = studentAlertFile.FileName;

            Properties.Settings.Default["studentAlert"] = studentAlertFile.FileName;
            Properties.Settings.Default.Save();

            MessageBox.Show("Öğrenci Zili başarı ile güncellendi.");
        }

        private void audioSettings_Load(object sender, EventArgs e)
        {
            studentAlert.Text = Properties.Settings.Default.studentAlert;
            teacherAlert.Text = Properties.Settings.Default.teacherAlert;
            exitAlert.Text = Properties.Settings.Default.exitAlert;

            studentVolume.Value = Properties.Settings.Default.studentVolume;
            teacherVolume.Value = Properties.Settings.Default.teacherVolume;
            exitVolume.Value = Properties.Settings.Default.exitVolume;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void sirenAlertChoose_Click(object sender, EventArgs e)
        {

        }

        private void teacherAlertChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog teacherAlertFile = new OpenFileDialog();
            teacherAlertFile.Filter = "Media File(*.wav)|*.wav;";
            teacherAlertFile.InitialDirectory = Application.StartupPath;
            teacherAlertFile.Title = "Öğretmen Zil Sesi Seç";
            teacherAlertFile.ShowDialog();

            teacherAlert.Text = teacherAlertFile.FileName;

            Properties.Settings.Default["teacherAlert"] = teacherAlertFile.FileName;
            Properties.Settings.Default.Save();

            MessageBox.Show("Öğretmen Zili başarı ile güncellendi.");
        }

        private void teacherAlert_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitAlertChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog exitAlertFile = new OpenFileDialog();
            exitAlertFile.Filter = "Media File(*.wav)|*.wav;";
            exitAlertFile.InitialDirectory = Application.StartupPath;
            exitAlertFile.Title = "Teneffüs Zil Sesi Seç";
            exitAlertFile.ShowDialog();

            exitAlert.Text = exitAlertFile.FileName;

            Properties.Settings.Default["exitAlert"] = exitAlertFile.FileName;
            Properties.Settings.Default.Save();

            MessageBox.Show("Teneffüs Zili başarı ile güncellendi.");
        }

        private void studentVolume_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["studentVolume"] = studentVolume.Value;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["studentVolume"] = studentVolume.Value;
            Properties.Settings.Default["teacherVolume"] = teacherVolume.Value;
            Properties.Settings.Default["exitVolume"] = exitVolume.Value;

            Properties.Settings.Default.Save();
            MessageBox.Show("Değişiklikler başarı ile kayıt edildi.", "Okul Zil Programı");
            this.Close();
        }

        private void exitVolume_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["exitVolume"] = exitVolume.Value;
            Properties.Settings.Default.Save();
        }

        private void teacherVolume_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["teacherVolume"] = teacherVolume.Value;
            Properties.Settings.Default.Save();
        }
    }
}
