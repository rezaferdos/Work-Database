﻿namespace ORM_EF_CodeFirst
{
    partial class Form1
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
            btnRefresh = new Button();
            dgvMain = new DataGridView();
            btnInsert = new Button();
            btnInPerson = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(560, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 23);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location = new Point(12, 12);
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
            dgvMain.Size = new Size(537, 311);
            dgvMain.TabIndex = 1;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(560, 41);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(107, 23);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnInPerson
            // 
            btnInPerson.Location = new Point(560, 70);
            btnInPerson.Name = "btnInPerson";
            btnInPerson.Size = new Size(107, 23);
            btnInPerson.TabIndex = 3;
            btnInPerson.Text = "Add In Person";
            btnInPerson.UseVisualStyleBackColor = true;
            btnInPerson.Click += btnInPerson_Click;
            // 
            // button1
            // 
            button1.Location = new Point(560, 99);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 4;
            button1.Text = "Add LastDegree";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 335);
            Controls.Add(button1);
            Controls.Add(btnInPerson);
            Controls.Add(btnInsert);
            Controls.Add(dgvMain);
            Controls.Add(btnRefresh);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private DataGridView dgvMain;
        private Button btnInsert;
        private Button btnInPerson;
        private Button button1;
    }
}
