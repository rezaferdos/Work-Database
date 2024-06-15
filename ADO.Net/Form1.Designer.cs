namespace ADO.Net
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
            btnAdd = new Button();
            btnAddParam = new Button();
            btnSolved = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 31);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Product Fix Value";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAddParam
            // 
            btnAddParam.Location = new Point(176, 12);
            btnAddParam.Name = "btnAddParam";
            btnAddParam.Size = new Size(158, 31);
            btnAddParam.TabIndex = 1;
            btnAddParam.Text = "Add Product SQL Injection";
            btnAddParam.UseVisualStyleBackColor = true;
            btnAddParam.Click += btnAddParam_Click;
            // 
            // btnSolved
            // 
            btnSolved.Location = new Point(340, 12);
            btnSolved.Name = "btnSolved";
            btnSolved.Size = new Size(231, 31);
            btnSolved.TabIndex = 2;
            btnSolved.Text = "Add Product Solved SQL Injection";
            btnSolved.UseVisualStyleBackColor = true;
            btnSolved.Click += btnSolved_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 318);
            Controls.Add(btnSolved);
            Controls.Add(btnAddParam);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnAddParam;
        private Button btnSolved;
    }
}
