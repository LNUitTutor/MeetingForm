
namespace WinFormsApp1
{
    partial class MeetForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExplanationLabel = new System.Windows.Forms.Label();
            this.DayGroupBox = new System.Windows.Forms.GroupBox();
            this.DayListBox = new System.Windows.Forms.ListBox();
            this.LessonGroupBox = new System.Windows.Forms.GroupBox();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.LessonUpDown = new System.Windows.Forms.NumericUpDown();
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.PractButton = new System.Windows.Forms.RadioButton();
            this.LabButton = new System.Windows.Forms.RadioButton();
            this.SeminarButton = new System.Windows.Forms.RadioButton();
            this.LectureButton = new System.Windows.Forms.RadioButton();
            this.AdditionalGroupBox = new System.Windows.Forms.GroupBox();
            this.TestCheckBox = new System.Windows.Forms.CheckBox();
            this.OnlineCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrereqTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.DayGroupBox.SuspendLayout();
            this.LessonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LessonUpDown)).BeginInit();
            this.TypeGroupBox.SuspendLayout();
            this.AdditionalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExplanationLabel
            // 
            this.ExplanationLabel.AutoSize = true;
            this.ExplanationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExplanationLabel.Location = new System.Drawing.Point(10, 23);
            this.ExplanationLabel.Name = "ExplanationLabel";
            this.ExplanationLabel.Size = new System.Drawing.Size(444, 28);
            this.ExplanationLabel.TabIndex = 0;
            this.ExplanationLabel.Text = "Оберіть параметри щодо призначення заняття";
            // 
            // DayGroupBox
            // 
            this.DayGroupBox.Controls.Add(this.DayListBox);
            this.DayGroupBox.Location = new System.Drawing.Point(12, 54);
            this.DayGroupBox.Name = "DayGroupBox";
            this.DayGroupBox.Size = new System.Drawing.Size(163, 148);
            this.DayGroupBox.TabIndex = 1;
            this.DayGroupBox.TabStop = false;
            this.DayGroupBox.Text = "Оберіть день";
            // 
            // DayListBox
            // 
            this.DayListBox.FormattingEnabled = true;
            this.DayListBox.ItemHeight = 20;
            this.DayListBox.Items.AddRange(new object[] {
            "Понеділок",
            "Вівторок",
            "Середа",
            "Четвер",
            "П\'ятниця",
            "Субота",
            "Неділя"});
            this.DayListBox.Location = new System.Drawing.Point(6, 26);
            this.DayListBox.Name = "DayListBox";
            this.DayListBox.Size = new System.Drawing.Size(150, 104);
            this.DayListBox.TabIndex = 2;
            this.DayListBox.SelectedIndexChanged += new System.EventHandler(this.DayListBox_SelectedIndexChanged);
            // 
            // LessonGroupBox
            // 
            this.LessonGroupBox.Controls.Add(this.RoomComboBox);
            this.LessonGroupBox.Controls.Add(this.LessonUpDown);
            this.LessonGroupBox.Location = new System.Drawing.Point(181, 54);
            this.LessonGroupBox.Name = "LessonGroupBox";
            this.LessonGroupBox.Size = new System.Drawing.Size(163, 148);
            this.LessonGroupBox.TabIndex = 2;
            this.LessonGroupBox.TabStop = false;
            this.LessonGroupBox.Text = "Оберіть пару і авдиторію";
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Items.AddRange(new object[] {
            "146",
            "216",
            "220",
            "379",
            "439"});
            this.RoomComboBox.Location = new System.Drawing.Point(0, 102);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(151, 28);
            this.RoomComboBox.TabIndex = 1;
            this.RoomComboBox.Text = "216";
            // 
            // LessonUpDown
            // 
            this.LessonUpDown.Location = new System.Drawing.Point(20, 54);
            this.LessonUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.LessonUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LessonUpDown.Name = "LessonUpDown";
            this.LessonUpDown.Size = new System.Drawing.Size(118, 27);
            this.LessonUpDown.TabIndex = 0;
            this.LessonUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TypeGroupBox
            // 
            this.TypeGroupBox.Controls.Add(this.PractButton);
            this.TypeGroupBox.Controls.Add(this.LabButton);
            this.TypeGroupBox.Controls.Add(this.SeminarButton);
            this.TypeGroupBox.Controls.Add(this.LectureButton);
            this.TypeGroupBox.Location = new System.Drawing.Point(350, 54);
            this.TypeGroupBox.Name = "TypeGroupBox";
            this.TypeGroupBox.Size = new System.Drawing.Size(163, 148);
            this.TypeGroupBox.TabIndex = 3;
            this.TypeGroupBox.TabStop = false;
            this.TypeGroupBox.Text = "Задайте вид заняття";
            // 
            // PractButton
            // 
            this.PractButton.AutoSize = true;
            this.PractButton.Location = new System.Drawing.Point(6, 114);
            this.PractButton.Name = "PractButton";
            this.PractButton.Size = new System.Drawing.Size(105, 24);
            this.PractButton.TabIndex = 4;
            this.PractButton.Text = "Практичне";
            this.PractButton.UseVisualStyleBackColor = true;
            this.PractButton.CheckedChanged += new System.EventHandler(this.LectureButton_CheckedChanged);
            // 
            // LabButton
            // 
            this.LabButton.AutoSize = true;
            this.LabButton.Location = new System.Drawing.Point(6, 84);
            this.LabButton.Name = "LabButton";
            this.LabButton.Size = new System.Drawing.Size(124, 24);
            this.LabButton.TabIndex = 2;
            this.LabButton.Text = "Лабораторна";
            this.LabButton.UseVisualStyleBackColor = true;
            this.LabButton.CheckedChanged += new System.EventHandler(this.LectureButton_CheckedChanged);
            // 
            // SeminarButton
            // 
            this.SeminarButton.AutoSize = true;
            this.SeminarButton.Location = new System.Drawing.Point(6, 54);
            this.SeminarButton.Name = "SeminarButton";
            this.SeminarButton.Size = new System.Drawing.Size(88, 24);
            this.SeminarButton.TabIndex = 1;
            this.SeminarButton.Text = "Семінар";
            this.SeminarButton.UseVisualStyleBackColor = true;
            this.SeminarButton.CheckedChanged += new System.EventHandler(this.LectureButton_CheckedChanged);
            // 
            // LectureButton
            // 
            this.LectureButton.AutoSize = true;
            this.LectureButton.Checked = true;
            this.LectureButton.Location = new System.Drawing.Point(6, 24);
            this.LectureButton.Name = "LectureButton";
            this.LectureButton.Size = new System.Drawing.Size(76, 24);
            this.LectureButton.TabIndex = 0;
            this.LectureButton.TabStop = true;
            this.LectureButton.Text = "Лекція";
            this.LectureButton.UseVisualStyleBackColor = true;
            this.LectureButton.CheckedChanged += new System.EventHandler(this.LectureButton_CheckedChanged);
            // 
            // AdditionalGroupBox
            // 
            this.AdditionalGroupBox.Controls.Add(this.TestCheckBox);
            this.AdditionalGroupBox.Controls.Add(this.OnlineCheckBox);
            this.AdditionalGroupBox.Location = new System.Drawing.Point(519, 54);
            this.AdditionalGroupBox.Name = "AdditionalGroupBox";
            this.AdditionalGroupBox.Size = new System.Drawing.Size(163, 148);
            this.AdditionalGroupBox.TabIndex = 4;
            this.AdditionalGroupBox.TabStop = false;
            this.AdditionalGroupBox.Text = "Додатково";
            // 
            // TestCheckBox
            // 
            this.TestCheckBox.AutoSize = true;
            this.TestCheckBox.Location = new System.Drawing.Point(18, 84);
            this.TestCheckBox.Name = "TestCheckBox";
            this.TestCheckBox.Size = new System.Drawing.Size(98, 24);
            this.TestCheckBox.TabIndex = 1;
            this.TestCheckBox.Text = "Контроль";
            this.TestCheckBox.UseVisualStyleBackColor = true;
            // 
            // OnlineCheckBox
            // 
            this.OnlineCheckBox.AutoSize = true;
            this.OnlineCheckBox.Location = new System.Drawing.Point(18, 38);
            this.OnlineCheckBox.Name = "OnlineCheckBox";
            this.OnlineCheckBox.Size = new System.Drawing.Size(85, 24);
            this.OnlineCheckBox.TabIndex = 0;
            this.OnlineCheckBox.Text = "Онлайн";
            this.OnlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Попередні вимоги";
            // 
            // PrereqTextBox
            // 
            this.PrereqTextBox.Location = new System.Drawing.Point(14, 246);
            this.PrereqTextBox.Name = "PrereqTextBox";
            this.PrereqTextBox.Size = new System.Drawing.Size(668, 27);
            this.PrereqTextBox.TabIndex = 6;
            this.PrereqTextBox.Leave += new System.EventHandler(this.PrereqTextBox_Leave);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(226, 295);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 29);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "Гаразд";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(351, 295);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(94, 29);
            this.QuitButton.TabIndex = 8;
            this.QuitButton.Text = "Завершити";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MeetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.QuitButton;
            this.ClientSize = new System.Drawing.Size(693, 343);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PrereqTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdditionalGroupBox);
            this.Controls.Add(this.TypeGroupBox);
            this.Controls.Add(this.LessonGroupBox);
            this.Controls.Add(this.DayGroupBox);
            this.Controls.Add(this.ExplanationLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeetForm";
            this.Text = "Планування заняття";
            this.DayGroupBox.ResumeLayout(false);
            this.LessonGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LessonUpDown)).EndInit();
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            this.AdditionalGroupBox.ResumeLayout(false);
            this.AdditionalGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExplanationLabel;
        private System.Windows.Forms.GroupBox DayGroupBox;
        private System.Windows.Forms.ListBox DayListBox;
        private System.Windows.Forms.GroupBox LessonGroupBox;
        private System.Windows.Forms.NumericUpDown LessonUpDown;
        private System.Windows.Forms.GroupBox TypeGroupBox;
        private System.Windows.Forms.RadioButton LabButton;
        private System.Windows.Forms.RadioButton SeminarButton;
        private System.Windows.Forms.RadioButton LectureButton;
        private System.Windows.Forms.RadioButton PractButton;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.GroupBox AdditionalGroupBox;
        private System.Windows.Forms.CheckBox TestCheckBox;
        private System.Windows.Forms.CheckBox OnlineCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrereqTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button QuitButton;
    }
}

