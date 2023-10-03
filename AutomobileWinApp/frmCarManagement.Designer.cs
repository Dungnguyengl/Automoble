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
            btnClose = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            btnLoad = new Button();
            txtReleaseYear = new TextBox();
            txtPrice = new TextBox();
            txtManufacturer = new TextBox();
            txtCarName = new TextBox();
            txtCarID = new TextBox();
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
            dgvCarList.Location = new Point(83, 226);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(634, 150);
            dgvCarList.TabIndex = 30;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(355, 382);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 49);
            btnClose.TabIndex = 29;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(628, 157);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 49);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(355, 157);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(89, 49);
            btnNew.TabIndex = 27;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(83, 157);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(89, 49);
            btnLoad.TabIndex = 26;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(503, 64);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(214, 23);
            txtReleaseYear.TabIndex = 25;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(503, 19);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(214, 23);
            txtPrice.TabIndex = 24;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(171, 110);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(214, 23);
            txtManufacturer.TabIndex = 23;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(171, 67);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(214, 23);
            txtCarName.TabIndex = 22;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(171, 19);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(214, 23);
            txtCarID.TabIndex = 21;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(411, 67);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(71, 15);
            lbReleaseYear.TabIndex = 20;
            lbReleaseYear.Text = "Release Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(411, 19);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 19;
            lbPrice.Text = "Price";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(83, 110);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 18;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(83, 67);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 17;
            lbCarName.Text = "Car Name";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(83, 19);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 16;
            lbCarID.Text = "Car ID";
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCarList);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCarList;
        private Button btnClose;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private TextBox txtReleaseYear;
        private TextBox txtPrice;
        private TextBox txtManufacturer;
        private TextBox txtCarName;
        private TextBox txtCarID;
        private Label lbReleaseYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbCarID;
    }
}