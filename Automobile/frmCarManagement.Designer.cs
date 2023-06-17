namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            dgvCarList = new DataGridView();
            txtReleaseYear = new TextBox();
            txtPrice = new TextBox();
            txtManufacturer = new TextBox();
            txtCarName = new TextBox();
            txtCarID = new TextBox();
            btnDelete = new Button();
            btnNew = new Button();
            btnLoad = new Button();
            lbReleaseYear = new Label();
            lbPrice = new Label();
            lbManufacturer = new Label();
            lbCarName = new Label();
            lbCarID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(53, 286);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(695, 188);
            dgvCarList.TabIndex = 27;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(539, 84);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(209, 27);
            txtReleaseYear.TabIndex = 26;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(539, 32);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(209, 27);
            txtPrice.TabIndex = 25;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(172, 131);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(209, 27);
            txtManufacturer.TabIndex = 24;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(172, 80);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(209, 27);
            txtCarName.TabIndex = 23;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(172, 29);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(209, 27);
            txtCarID.TabIndex = 22;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(577, 207);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(361, 207);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 20;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click_1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(172, 207);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click_1;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(440, 90);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(88, 20);
            lbReleaseYear.TabIndex = 18;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(440, 35);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 17;
            lbPrice.Text = "Price";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(69, 136);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 16;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(69, 84);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(79, 20);
            lbCarName.TabIndex = 15;
            lbCarName.Text = " Car Name";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(69, 32);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 14;
            lbCarID.Text = "Car ID";
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 511);
            Controls.Add(dgvCarList);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            Text = "frmCarManagement";
            Load += frmCarManagement_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCarList;
        private TextBox txtReleaseYear;
        private TextBox txtPrice;
        private TextBox txtManufacturer;
        private TextBox txtCarName;
        private TextBox txtCarID;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private Label lbReleaseYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbCarID;
    }
}