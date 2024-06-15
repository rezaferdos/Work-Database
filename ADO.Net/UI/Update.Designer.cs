namespace ADO.Net.UI
{
    partial class Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            txtPName = new TextBox();
            label1 = new Label();
            dgUpdate = new DataGridView();
            UpdateColumn = new DataGridViewButtonColumn();
            label2 = new Label();
            txtPPrice = new TextBox();
            BrnLoad = new Button();
            label3 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgUpdate).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(102, 277);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 33);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(12, 148);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(186, 23);
            txtPName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 121);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Product Name";
            // 
            // dgUpdate
            // 
            dgUpdate.AllowUserToAddRows = false;
            dgUpdate.AllowUserToDeleteRows = false;
            dgUpdate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUpdate.Columns.AddRange(new DataGridViewColumn[] { UpdateColumn });
            dgUpdate.Location = new Point(204, 12);
            dgUpdate.Name = "dgUpdate";
            dgUpdate.ReadOnly = true;
            dgUpdate.Size = new Size(352, 298);
            dgUpdate.TabIndex = 3;
            dgUpdate.CellContentClick += dgUpdate_CellContentClick;
            // 
            // UpdateColumn
            // 
            UpdateColumn.HeaderText = "Click To Edit";
            UpdateColumn.Name = "UpdateColumn";
            UpdateColumn.ReadOnly = true;
            UpdateColumn.Text = "Edit Rows";
            UpdateColumn.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 174);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Unit Price";
            // 
            // txtPPrice
            // 
            txtPPrice.Location = new Point(9, 192);
            txtPPrice.Name = "txtPPrice";
            txtPPrice.Size = new Size(189, 23);
            txtPPrice.TabIndex = 4;
            // 
            // BrnLoad
            // 
            BrnLoad.Location = new Point(9, 277);
            BrnLoad.Name = "BrnLoad";
            BrnLoad.Size = new Size(87, 33);
            BrnLoad.TabIndex = 6;
            BrnLoad.Text = "Load Data";
            BrnLoad.UseVisualStyleBackColor = true;
            BrnLoad.Click += BrnLoad_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 77);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 8;
            label3.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 95);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(186, 23);
            txtID.TabIndex = 7;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 322);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(BrnLoad);
            Controls.Add(label2);
            Controls.Add(txtPPrice);
            Controls.Add(dgUpdate);
            Controls.Add(label1);
            Controls.Add(txtPName);
            Controls.Add(btnSave);
            Name = "Update";
            Text = "Update";
            ((System.ComponentModel.ISupportInitialize)dgUpdate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtPName;
        private Label label1;
        private DataGridView dgUpdate;
        private Label label2;
        private TextBox txtPPrice;
        private Button BrnLoad;
        private DataGridViewButtonColumn UpdateColumn;
        private Label label3;
        private TextBox txtID;
    }
}