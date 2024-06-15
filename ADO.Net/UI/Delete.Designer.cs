namespace ADO.Net.UI
{
    partial class Delete
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
            dgDeleteProducts = new DataGridView();
            btnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgDeleteProducts).BeginInit();
            SuspendLayout();
            // 
            // dgDeleteProducts
            // 
            dgDeleteProducts.AllowUserToAddRows = false;
            dgDeleteProducts.AllowUserToDeleteRows = false;
            dgDeleteProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDeleteProducts.Columns.AddRange(new DataGridViewColumn[] { btnDelete });
            dgDeleteProducts.Location = new Point(12, 12);
            dgDeleteProducts.Name = "dgDeleteProducts";
            dgDeleteProducts.ReadOnly = true;
            dgDeleteProducts.Size = new Size(554, 361);
            dgDeleteProducts.TabIndex = 0;
            dgDeleteProducts.CellContentClick += dgDeleteProducts_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            btnDelete.HeaderText = "Delete Record";
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Resizable = DataGridViewTriState.True;
            btnDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 105;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 385);
            Controls.Add(dgDeleteProducts);
            Name = "Delete";
            Text = "Delete";
            Load += Delete_Load;
            ((System.ComponentModel.ISupportInitialize)dgDeleteProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgDeleteProducts;
        private DataGridViewButtonColumn btnDelete;
    }
}