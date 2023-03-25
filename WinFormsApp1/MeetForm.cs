using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MeetForm : Form
    {
        private string MeetType = "Лекція";
        private string Addition = string.Empty;
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
            string answer = string.Format(
                " Заплановано {0} на {1},\nпара #{2} в ауд. {3}",
                MeetType, DayListBox.Items[DayListBox.SelectedIndex],
                LessonUpDown.Value, RoomComboBox.Text);
            if (OnlineCheckBox.Checked)
            {
                answer += "\nЗаняття транслюватиметься онлайн";
            }
            if (TestCheckBox.Checked)
            {
                answer += "\nНа занятті може бути контрольна";
            }
            if (Addition != string.Empty)
            {
                answer += "\n\nДодаткові вимоги: " + Addition;
            }

            MessageBox.Show(answer, "Заняття",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void PrereqTextBox_Leave(object sender, EventArgs e)
        {
            Addition = (sender as TextBox).Text;
        }
    }
}