namespace tcc_barcode.Forms
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtProductCode = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            dgvProductDetail = new DataGridView();
            clmId = new DataGridViewTextBoxColumn();
            clmProductCode = new DataGridViewTextBoxColumn();
            clmBarcode = new DataGridViewImageColumn();
            clmDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductDetail).BeginInit();
            SuspendLayout();
            // 
            // txtProductCode
            // 
            txtProductCode.CharacterCasing = CharacterCasing.Upper;
            txtProductCode.Location = new Point(119, 45);
            txtProductCode.Margin = new Padding(5, 4, 5, 4);
            txtProductCode.MaxLength = 19;
            txtProductCode.Name = "txtProductCode";
            txtProductCode.PlaceholderText = "XXXX-XXXX-XXXX-XXXX";
            txtProductCode.Size = new Size(600, 30);
            txtProductCode.TabIndex = 0;
            txtProductCode.KeyPress += txtProductCode_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 48);
            label1.Name = "label1";
            label1.Size = new Size(66, 22);
            label1.TabIndex = 1;
            label1.Text = "รหัสสินค้า";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(727, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProductDetail
            // 
            dgvProductDetail.AllowUserToAddRows = false;
            dgvProductDetail.AllowUserToDeleteRows = false;
            dgvProductDetail.AllowUserToResizeColumns = false;
            dgvProductDetail.AllowUserToResizeRows = false;
            dgvProductDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductDetail.BackgroundColor = SystemColors.Control;
            dgvProductDetail.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProductDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductDetail.ColumnHeadersHeight = 35;
            dgvProductDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductDetail.Columns.AddRange(new DataGridViewColumn[] { clmId, clmProductCode, clmBarcode, clmDelete });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvProductDetail.DefaultCellStyle = dataGridViewCellStyle4;
            dgvProductDetail.EnableHeadersVisualStyles = false;
            dgvProductDetail.Location = new Point(45, 100);
            dgvProductDetail.Name = "dgvProductDetail";
            dgvProductDetail.ReadOnly = true;
            dgvProductDetail.RowHeadersVisible = false;
            dgvProductDetail.Size = new Size(915, 397);
            dgvProductDetail.TabIndex = 3;
            dgvProductDetail.CellContentClick += dgvProductDetail_CellContentClick;
            // 
            // clmId
            // 
            clmId.DataPropertyName = "Id";
            clmId.HeaderText = "Id";
            clmId.Name = "clmId";
            clmId.ReadOnly = true;
            clmId.Width = 50;
            // 
            // clmProductCode
            // 
            clmProductCode.DataPropertyName = "ProductCode";
            clmProductCode.HeaderText = "รหัสสินค้า (16 หลัก)";
            clmProductCode.Name = "clmProductCode";
            clmProductCode.ReadOnly = true;
            clmProductCode.Width = 250;
            // 
            // clmBarcode
            // 
            clmBarcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmBarcode.DataPropertyName = "Barcode";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            clmBarcode.DefaultCellStyle = dataGridViewCellStyle2;
            clmBarcode.HeaderText = "บาร์โค้ดสินค้า";
            clmBarcode.Name = "clmBarcode";
            clmBarcode.ReadOnly = true;
            // 
            // clmDelete
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Red;
            dataGridViewCellStyle3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            clmDelete.DefaultCellStyle = dataGridViewCellStyle3;
            clmDelete.FlatStyle = FlatStyle.Flat;
            clmDelete.HeaderText = "Action";
            clmDelete.Name = "clmDelete";
            clmDelete.ReadOnly = true;
            clmDelete.Text = "ลบ";
            clmDelete.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 537);
            Controls.Add(dgvProductDetail);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtProductCode);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Form";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductCode;
        private Label label1;
        private Button btnAdd;
        private DataGridView dgvProductDetail;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmProductCode;
        private DataGridViewImageColumn clmBarcode;
        private DataGridViewButtonColumn clmDelete;
    }
}