﻿using System.Windows.Forms;

namespace Schedlify.WinForm
{
    partial class CreateIntervalAssignment
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox classesComboBox;
        private Label classesLabel;
        

        private Label lblLecturer;
        private TextBox txtLecturer;

        private GroupBox groupClassType;
        private RadioButton rbtnLecture;
        private RadioButton rbtnPractical;

        private GroupBox groupMode;
        private RadioButton rbtnInPerson;
        private RadioButton rbtnRemote;

        private Label lblAddress;
        private TextBox txtAddress;

        private Label lblRoomNumber;
        private TextBox txtRoomNumber;

        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            classesComboBox = new ComboBox();
            classesLabel = new Label();
       
            lblLecturer = new Label();
            txtLecturer = new TextBox();
            groupClassType = new GroupBox();
            rbtnLecture = new RadioButton();
            rbtnPractical = new RadioButton();
            groupMode = new GroupBox();
            rbtnInPerson = new RadioButton();
            rbtnRemote = new RadioButton();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblRoomNumber = new Label();
            txtRoomNumber = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            dayWeekLabel = new Label();
            classNumberLabel = new Label();
            groupClassType.SuspendLayout();
            groupMode.SuspendLayout();
            SuspendLayout();
            // 
            // classesComboBox
            // 
            classesComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            classesComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            classesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            classesComboBox.Font = new Font("Segoe UI", 10F);
            classesComboBox.FormattingEnabled = true;
            classesComboBox.Location = new Point(150, 53);
            classesComboBox.Name = "classesComboBox";
            classesComboBox.Size = new Size(200, 45);
            classesComboBox.TabIndex = 1;
            // 
            // classesLabel
            // 
            classesLabel.AutoSize = true;
            classesLabel.Location = new Point(20, 53);
            classesLabel.Name = "classesLabel";
            classesLabel.Size = new Size(116, 32);
            classesLabel.TabIndex = 0;
            classesLabel.Text = "Предмет:";        
            // 
            // lblLecturer
            // 
            lblLecturer.AutoSize = true;
            lblLecturer.Location = new Point(20, 111);
            lblLecturer.Name = "lblLecturer";
            lblLecturer.Size = new Size(123, 32);
            lblLecturer.TabIndex = 4;
            lblLecturer.Text = "Викладач:";
            // 
            // txtLecturer
            // 
            txtLecturer.Location = new Point(150, 111);
            txtLecturer.Name = "txtLecturer";
            txtLecturer.Size = new Size(200, 39);
            txtLecturer.TabIndex = 5;
            // 
            // groupClassType
            // 
            groupClassType.Controls.Add(rbtnLecture);
            groupClassType.Controls.Add(rbtnPractical);
            groupClassType.Location = new Point(20, 151);
            groupClassType.Name = "groupClassType";
            groupClassType.Size = new Size(490, 60);
            groupClassType.TabIndex = 6;
            groupClassType.TabStop = false;
            groupClassType.Text = "Тип заняття";
            // 
            // rbtnLecture
            // 
            rbtnLecture.AutoSize = true;
            rbtnLecture.Checked = true;
            rbtnLecture.Location = new Point(10, 25);
            rbtnLecture.Name = "rbtnLecture";
            rbtnLecture.Size = new Size(118, 36);
            rbtnLecture.TabIndex = 0;
            rbtnLecture.TabStop = true;
            rbtnLecture.Text = "Лекція";
            // 
            // rbtnPractical
            // 
            rbtnPractical.AutoSize = true;
            rbtnPractical.Location = new Point(150, 25);
            rbtnPractical.Name = "rbtnPractical";
            rbtnPractical.Size = new Size(164, 36);
            rbtnPractical.TabIndex = 1;
            rbtnPractical.Text = "Практична";
            // 
            // groupMode
            // 
            groupMode.Controls.Add(rbtnInPerson);
            groupMode.Controls.Add(rbtnRemote);
            groupMode.Location = new Point(20, 221);
            groupMode.Name = "groupMode";
            groupMode.Size = new Size(490, 60);
            groupMode.TabIndex = 7;
            groupMode.TabStop = false;
            groupMode.Text = "Формат";
            // 
            // rbtnInPerson
            // 
            rbtnInPerson.AutoSize = true;
            rbtnInPerson.Location = new Point(10, 25);
            rbtnInPerson.Name = "rbtnInPerson";
            rbtnInPerson.Size = new Size(105, 36);
            rbtnInPerson.TabIndex = 0;
            rbtnInPerson.Text = "Очно";
            // 
            // rbtnRemote
            // 
            rbtnRemote.AutoSize = true;
            rbtnRemote.Checked = true;
            rbtnRemote.Location = new Point(150, 25);
            rbtnRemote.Name = "rbtnRemote";
            rbtnRemote.Size = new Size(185, 36);
            rbtnRemote.TabIndex = 1;
            rbtnRemote.TabStop = true;
            rbtnRemote.Text = "Дистанційно";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(20, 301);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(97, 32);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Адреса:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 301);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 39);
            txtAddress.TabIndex = 9;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(20, 341);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(202, 32);
            lblRoomNumber.TabIndex = 10;
            lblRoomNumber.Text = "Номер аудиторії:";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(150, 341);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(200, 39);
            txtRoomNumber.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(50, 391);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 12;
            btnSave.Text = "Зберегти";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(200, 391);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Скасувати";
            btnCancel.Click += btnCancel_Click;
            // 
            // dayWeekLabel
            // 
            dayWeekLabel.AutoSize = true;
            dayWeekLabel.Location = new Point(20, 9);
            dayWeekLabel.Name = "dayWeekLabel";
            dayWeekLabel.Size = new Size(148, 32);
            dayWeekLabel.TabIndex = 14;
            dayWeekLabel.Text = "День Тижня";
            // 
            // classNumberLabel
            // 
            classNumberLabel.AutoSize = true;
            classNumberLabel.Location = new Point(200, 9);
            classNumberLabel.Name = "classNumberLabel";
            classNumberLabel.Size = new Size(150, 32);
            classNumberLabel.TabIndex = 15;
            classNumberLabel.Text = "Номер пари";
            // 
            // CreateRegularAssignment
            // 
            ClientSize = new Size(380, 469);
            Controls.Add(classNumberLabel);
            Controls.Add(dayWeekLabel);
            Controls.Add(classesLabel);
            Controls.Add(classesComboBox);
            Controls.Add(lblLecturer);
            Controls.Add(txtLecturer);
            Controls.Add(groupClassType);
            Controls.Add(groupMode);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblRoomNumber);
            Controls.Add(txtRoomNumber);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "CreateRegularAssignment";
            Text = "Створення заняття";
            groupClassType.ResumeLayout(false);
            groupClassType.PerformLayout();
            groupMode.ResumeLayout(false);
            groupMode.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label dayWeekLabel;
        private Label classNumberLabel;
    }
}