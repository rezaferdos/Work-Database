namespace Business_Service_DB_Code
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
            btnGenUser = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            txtFilterName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGenUser
            // 
            btnGenUser.Location = new Point(12, 12);
            btnGenUser.Name = "btnGenUser";
            btnGenUser.Size = new Size(117, 23);
            btnGenUser.TabIndex = 0;
            btnGenUser.Text = "Generate User";
            btnGenUser.UseVisualStyleBackColor = true;
            btnGenUser.Click += btnGenUser_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(874, 232);
            dataGridView1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Select All", "Active", "Not Active" });
            comboBox1.Location = new Point(12, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(117, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtFilterName
            // 
            txtFilterName.Location = new Point(235, 41);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.Size = new Size(154, 23);
            txtFilterName.TabIndex = 3;
            txtFilterName.TextChanged += txtFilterName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 44);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "Filter By Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 314);
            Controls.Add(label1);
            Controls.Add(txtFilterName);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnGenUser);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenUser;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox txtFilterName;
        private Label label1;
    }
}
