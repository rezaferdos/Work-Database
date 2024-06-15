namespace ADO.Net.UI
{
    partial class Read
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
            dgProducts = new DataGridView();
            btnreadDataReader = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // dgProducts
            // 
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Location = new Point(12, 129);
            dgProducts.Name = "dgProducts";
            dgProducts.Size = new Size(608, 221);
            dgProducts.TabIndex = 0;
            // 
            // btnreadDataReader
            // 
            btnreadDataReader.Location = new Point(12, 12);
            btnreadDataReader.Name = "btnreadDataReader";
            btnreadDataReader.Size = new Size(187, 40);
            btnreadDataReader.TabIndex = 1;
            btnreadDataReader.Text = "Read Products With DataReader";
            btnreadDataReader.UseVisualStyleBackColor = true;
            btnreadDataReader.Click += btnreadDataReader_Click;
            // 
            // Read
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 362);
            Controls.Add(btnreadDataReader);
            Controls.Add(dgProducts);
            Name = "Read";
            Text = "Read";
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgProducts;
        private Button btnreadDataReader;
    }
}