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
    }
}