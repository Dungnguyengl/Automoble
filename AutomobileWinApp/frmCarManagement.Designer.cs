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
            dgvCarList.Location = new Point(95, 301);
            dgvCarList.Margin = new Padding(3, 4, 3, 4);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(725, 200);
            dgvCarList.TabIndex = 30;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(406, 509);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(102, 65);
            btnClose.TabIndex = 29;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(718, 209);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 65);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(406, 209);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(102, 65);
            btnNew.TabIndex = 27;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(95, 209);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(102, 65);
            btnLoad.TabIndex = 26;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(575, 85);
            txtReleaseYear.Margin = new Padding(3, 4, 3, 4);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(244, 27);
            txtReleaseYear.TabIndex = 25;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(575, 25);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(244, 27);
            txtPrice.TabIndex = 24;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(195, 147);
            txtManufacturer.Margin = new Padding(3, 4, 3, 4);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(244, 27);
            txtManufacturer.TabIndex = 23;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(195, 89);
            txtCarName.Margin = new Padding(3, 4, 3, 4);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(244, 27);
            txtCarName.TabIndex = 22;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(195, 25);
            txtCarID.Margin = new Padding(3, 4, 3, 4);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(244, 27);
            txtCarID.TabIndex = 21;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(470, 89);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(92, 20);
            lbReleaseYear.TabIndex = 20;
            lbReleaseYear.Text = "Release Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(470, 25);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 19;
            lbPrice.Text = "Price";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(95, 147);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 18;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(95, 89);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 17;
            lbCarName.Text = "Car Name";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(95, 25);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 16;
            lbCarID.Text = "Car ID";
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
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