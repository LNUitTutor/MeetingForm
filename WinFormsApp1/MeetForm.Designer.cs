
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
            this.LessonUpDown = new System.Windows.Forms.NumericUpDown();
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.LabButton = new System.Windows.Forms.RadioButton();
            this.SeminarButton = new System.Windows.Forms.RadioButton();
            this.LectureButton = new System.Windows.Forms.RadioButton();
            this.PractButton = new System.Windows.Forms.RadioButton();
            this.DayGroupBox.SuspendLayout();
            this.LessonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LessonUpDown)).BeginInit();
            this.TypeGroupBox.SuspendLayout();
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
            // 
            // LessonGroupBox
            // 
            this.LessonGroupBox.Controls.Add(this.LessonUpDown);
            this.LessonGroupBox.Location = new System.Drawing.Point(181, 54);
            this.LessonGroupBox.Name = "LessonGroupBox";
            this.LessonGroupBox.Size = new System.Drawing.Size(163, 148);
            this.LessonGroupBox.TabIndex = 2;
            this.LessonGroupBox.TabStop = false;
            this.LessonGroupBox.Text = "Оберіть пару";
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
            // LabButton
            // 
            this.LabButton.AutoSize = true;
            this.LabButton.Location = new System.Drawing.Point(6, 84);
            this.LabButton.Name = "LabButton";
            this.LabButton.Size = new System.Drawing.Size(124, 24);
            this.LabButton.TabIndex = 2;
            this.LabButton.TabStop = true;
            this.LabButton.Text = "Лабораторна";
            this.LabButton.UseVisualStyleBackColor = true;
            // 
            // SeminarButton
            // 
            this.SeminarButton.AutoSize = true;
            this.SeminarButton.Location = new System.Drawing.Point(6, 54);
            this.SeminarButton.Name = "SeminarButton";
            this.SeminarButton.Size = new System.Drawing.Size(88, 24);
            this.SeminarButton.TabIndex = 1;
            this.SeminarButton.TabStop = true;
            this.SeminarButton.Text = "Семінар";
            this.SeminarButton.UseVisualStyleBackColor = true;
            // 
            // LectureButton
            // 
            this.LectureButton.AutoSize = true;
            this.LectureButton.Location = new System.Drawing.Point(6, 24);
            this.LectureButton.Name = "LectureButton";
            this.LectureButton.Size = new System.Drawing.Size(76, 24);
            this.LectureButton.TabIndex = 0;
            this.LectureButton.TabStop = true;
            this.LectureButton.Text = "Лекція";
            this.LectureButton.UseVisualStyleBackColor = true;
            // 
            // PractButton
            // 
            this.PractButton.AutoSize = true;
            this.PractButton.Location = new System.Drawing.Point(6, 114);
            this.PractButton.Name = "PractButton";
            this.PractButton.Size = new System.Drawing.Size(105, 24);
            this.PractButton.TabIndex = 4;
            this.PractButton.TabStop = true;
            this.PractButton.Text = "Практичне";
            this.PractButton.UseVisualStyleBackColor = true;
            // 
            // MeetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypeGroupBox);
            this.Controls.Add(this.LessonGroupBox);
            this.Controls.Add(this.DayGroupBox);
            this.Controls.Add(this.ExplanationLabel);
            this.Name = "MeetForm";
            this.Text = "Планування заняття";
            this.DayGroupBox.ResumeLayout(false);
            this.LessonGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LessonUpDown)).EndInit();
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
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
    }
}

