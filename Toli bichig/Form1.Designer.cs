namespace Toli_bichig
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
            txtSearch = new TextBox();
            cmbLanguage = new ComboBox();
            btnSearch = new Button();
            dgvWords = new DataGridView();
            colNumber = new DataGridViewTextBoxColumn();
            colEnglish = new DataGridViewTextBoxColumn();
            colMongolian = new DataGridViewTextBoxColumn();
            colRussian = new DataGridViewTextBoxColumn();
            lblLanguage = new Label();
            lblWordsTitle = new Label();
            lblSavedTitle = new Label();
            panelTop = new Panel();
            lblMongolian = new Label();
            lblEnglish = new Label();
            txtEnglish = new TextBox();
            lblRussian = new Label();
            txtMongolian = new TextBox();
            txtRussian = new TextBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            panelBottom = new Panel();
            statusStrip1 = new StatusStrip();
            lblCount = new ToolStripStatusLabel();
            dataGridView1 = new DataGridView();
            btnRemoveSaved = new Button();
            cmbSort = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvWords).BeginInit();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(103, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(483, 27);
            txtSearch.TabIndex = 1;
            // 
            // cmbLanguage
            // 
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "Бүх хэл", "", "English", "", "Монгол", "", "Орос" });
            cmbLanguage.Location = new Point(786, 14);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(164, 28);
            cmbLanguage.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightBlue;
            btnSearch.Location = new Point(3, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Хайх ";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvWords
            // 
            dgvWords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWords.BackgroundColor = Color.White;
            dgvWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWords.Columns.AddRange(new DataGridViewColumn[] { colNumber, colEnglish, colMongolian, colRussian });
            dgvWords.Location = new Point(0, 91);
            dgvWords.MultiSelect = false;
            dgvWords.Name = "dgvWords";
            dgvWords.ReadOnly = true;
            dgvWords.RowHeadersVisible = false;
            dgvWords.RowHeadersWidth = 51;
            dgvWords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWords.Size = new Size(583, 483);
            dgvWords.TabIndex = 4;
            // 
            // colNumber
            // 
            colNumber.DataPropertyName = "id";
            colNumber.HeaderText = "№";
            colNumber.MinimumWidth = 6;
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            // 
            // colEnglish
            // 
            colEnglish.DataPropertyName = "english";
            colEnglish.HeaderText = "Англи";
            colEnglish.MinimumWidth = 6;
            colEnglish.Name = "colEnglish";
            colEnglish.ReadOnly = true;
            // 
            // colMongolian
            // 
            colMongolian.DataPropertyName = "mongolia";
            colMongolian.HeaderText = "Монгол";
            colMongolian.MinimumWidth = 6;
            colMongolian.Name = "colMongolian";
            colMongolian.ReadOnly = true;
            // 
            // colRussian
            // 
            colRussian.DataPropertyName = "russian";
            colRussian.HeaderText = "Орос";
            colRussian.MinimumWidth = 6;
            colRussian.Name = "colRussian";
            colRussian.ReadOnly = true;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(735, 21);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(36, 20);
            lblLanguage.TabIndex = 11;
            lblLanguage.Text = "Хэл:";
            // 
            // lblWordsTitle
            // 
            lblWordsTitle.AutoSize = true;
            lblWordsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWordsTitle.Location = new Point(12, 63);
            lblWordsTitle.Name = "lblWordsTitle";
            lblWordsTitle.Size = new Size(131, 28);
            lblWordsTitle.TabIndex = 12;
            lblWordsTitle.Text = "toli.db .words";
            // 
            // lblSavedTitle
            // 
            lblSavedTitle.AutoSize = true;
            lblSavedTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSavedTitle.Location = new Point(641, 91);
            lblSavedTitle.Name = "lblSavedTitle";
            lblSavedTitle.Size = new Size(206, 28);
            lblSavedTitle.TabIndex = 13;
            lblSavedTitle.Text = "saved.db saved_words";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnSearch);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblLanguage);
            panelTop.Controls.Add(cmbLanguage);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(982, 60);
            panelTop.TabIndex = 22;
            // 
            // lblMongolian
            // 
            lblMongolian.AutoSize = true;
            lblMongolian.Location = new Point(204, 0);
            lblMongolian.Name = "lblMongolian";
            lblMongolian.Size = new Size(63, 20);
            lblMongolian.TabIndex = 6;
            lblMongolian.Text = "Монгол";
            // 
            // lblEnglish
            // 
            lblEnglish.AutoSize = true;
            lblEnglish.Location = new Point(3, 0);
            lblEnglish.Name = "lblEnglish";
            lblEnglish.Size = new Size(55, 20);
            lblEnglish.TabIndex = 5;
            lblEnglish.Text = "Англи ";
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(64, 3);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(125, 27);
            txtEnglish.TabIndex = 10;
            // 
            // lblRussian
            // 
            lblRussian.AutoSize = true;
            lblRussian.Location = new Point(404, 3);
            lblRussian.Name = "lblRussian";
            lblRussian.Size = new Size(45, 20);
            lblRussian.TabIndex = 7;
            lblRussian.Text = "Орос";
            lblRussian.Click += label3_Click;
            // 
            // txtMongolian
            // 
            txtMongolian.Location = new Point(273, 3);
            txtMongolian.Name = "txtMongolian";
            txtMongolian.Size = new Size(125, 27);
            txtMongolian.TabIndex = 9;
            // 
            // txtRussian
            // 
            txtRussian.Location = new Point(455, 3);
            txtRussian.Name = "txtRussian";
            txtRussian.Size = new Size(125, 27);
            txtRussian.TabIndex = 8;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(147, 70);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "✎Засах";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(279, 70);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.No;
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "\t▤Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(391, 70);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 18;
            btnClear.Text = "⟳Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(519, 70);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "\t▣Санах";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(33, 70);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+Нэмэх";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(statusStrip1);
            panelBottom.Controls.Add(btnAdd);
            panelBottom.Controls.Add(btnSave);
            panelBottom.Controls.Add(btnClear);
            panelBottom.Controls.Add(btnDelete);
            panelBottom.Controls.Add(btnEdit);
            panelBottom.Controls.Add(txtRussian);
            panelBottom.Controls.Add(txtMongolian);
            panelBottom.Controls.Add(lblRussian);
            panelBottom.Controls.Add(txtEnglish);
            panelBottom.Controls.Add(lblEnglish);
            panelBottom.Controls.Add(lblMongolian);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 580);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(982, 142);
            panelBottom.TabIndex = 23;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblCount });
            statusStrip1.Location = new Point(0, 116);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(982, 26);
            statusStrip1.TabIndex = 21;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblCount
            // 
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(160, 20);
            lblCount.Text = "\tНийт: 0 үг · Санасан: 0";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(641, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(260, 151);
            dataGridView1.TabIndex = 24;
            // 
            // btnRemoveSaved
            // 
            btnRemoveSaved.Location = new Point(641, 279);
            btnRemoveSaved.Name = "btnRemoveSaved";
            btnRemoveSaved.Size = new Size(94, 29);
            btnRemoveSaved.TabIndex = 25;
            btnRemoveSaved.Text = "Хасах";
            btnRemoveSaved.UseVisualStyleBackColor = true;
            btnRemoveSaved.Click += btnRemoveSaved_Click;
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.FormattingEnabled = true;
            cmbSort.Location = new Point(641, 314);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(151, 28);
            cmbSort.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 722);
            Controls.Add(cmbSort);
            Controls.Add(btnRemoveSaved);
            Controls.Add(dataGridView1);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Controls.Add(lblSavedTitle);
            Controls.Add(lblWordsTitle);
            Controls.Add(dgvWords);
            MinimumSize = new Size(1000, 700);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гурван хэлний толь бичиг";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWords).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private ComboBox cmbLanguage;
        private Button btnSearch;
        private DataGridView dgvWords;
        private Label lblLanguage;
        private Label lblWordsTitle;
        private Label lblSavedTitle;
        private Panel panelTop;
        private Label lblMongolian;
        private Label lblEnglish;
        private TextBox txtEnglish;
        private Label lblRussian;
        private TextBox txtMongolian;
        private TextBox txtRussian;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
        private Button btnAdd;
        private Panel panelBottom;
        private DataGridView dataGridView1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblCount;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colEnglish;
        private DataGridViewTextBoxColumn colMongolian;
        private DataGridViewTextBoxColumn colRussian;
        private Button btnRemoveSaved;
        private ComboBox cmbSort;
    }
}
