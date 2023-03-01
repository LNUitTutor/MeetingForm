using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MeetForm : Form
    {
        private string MeetType = "Лекція";
        public MeetForm()
        {
            InitializeComponent();
            DayListBox.SelectedIndex = 0;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LectureButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = sender as RadioButton;
            if (box.Checked) MeetType = box.Text;
            //MessageBox.Show(box.Text, "Debug");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Заплановано {MeetType} на {DayListBox.Items[DayListBox.SelectedIndex]}");
        }

        private void DayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DayListBox.SelectedIndex)
            {
                case 0: case 1: case 2: case 3: case 4:
                    LessonUpDown.Maximum = 7;
                    TestCheckBox.Enabled = true;
                    SeminarButton.Enabled = true;
                    LabButton.Enabled = true;
                    PractButton.Enabled = true;
                    break;
                case 5:
                    LessonUpDown.Maximum = 3;
                    TestCheckBox.Enabled = true;
                    SeminarButton.Enabled = true;
                    LabButton.Enabled = true;
                    PractButton.Enabled = true;
                    break;
                case 6:
                    LessonUpDown.Maximum = 3;
                    TestCheckBox.Enabled = false;
                    SeminarButton.Enabled = false;
                    LabButton.Enabled = false;
                    PractButton.Enabled = false;
                    break;
            }
        }
    }
}