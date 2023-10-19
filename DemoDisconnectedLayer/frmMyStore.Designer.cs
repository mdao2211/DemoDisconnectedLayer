namespace DemoDisconnectedLayer
{
    partial class frmMyStore
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
            btnViewProducts = new Button();
            btnViewCategories = new Button();
            btnClose = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnViewProducts
            // 
            btnViewProducts.Location = new Point(75, 42);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(214, 56);
            btnViewProducts.TabIndex = 0;
            btnViewProducts.Text = "View Products";
            btnViewProducts.UseVisualStyleBackColor = true;
            btnViewProducts.Click += btnViewProducts_Click;
            // 
            // btnViewCategories
            // 
            btnViewCategories.Location = new Point(464, 42);
            btnViewCategories.Name = "btnViewCategories";
            btnViewCategories.Size = new Size(214, 56);
            btnViewCategories.TabIndex = 1;
            btnViewCategories.Text = "View Categories";
            btnViewCategories.UseVisualStyleBackColor = true;
            btnViewCategories.Click += btnViewCategories_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(265, 366);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(214, 56);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(52, 123);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.Size = new Size(696, 225);
            dgvData.TabIndex = 3;
            // 
            // frmMyStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvData);
            Controls.Add(btnClose);
            Controls.Add(btnViewCategories);
            Controls.Add(btnViewProducts);
            Name = "frmMyStore";
            Text = "frmMyStore";
            Load += frmMyStore_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewProducts;
        private Button btnViewCategories;
        private Button btnClose;
        private DataGridView dgvData;
    }
}