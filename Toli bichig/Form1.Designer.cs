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
            lblEnglish = new Label();
            lblMongolian = new Label();
            lblRussian = new Label();
            txtRussian = new TextBox();
            txtMongolian = new TextBox();
            txtEnglish = new TextBox();
            lblLanguage = new Label();
            lblWordsTitle = new Label();
            lblSavedTitle = new Label();
            lblSavedHeader = new Label();
            lstSaved = new ListBox();
            btnAdd = new Button();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvWords).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(112, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(483, 27);
            txtSearch.TabIndex = 1;
            // 
            // cmbLanguage
            // 
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "Бүх хэл", "", "English", "", "Монгол", "", "Орос" });
            cmbLanguage.Location = new Point(683, 7);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(164, 28);
            cmbLanguage.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightBlue;
            btnSearch.Location = new Point(12, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Хайх ";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvWords
            // 
            dgvWords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWords.BackgroundColor = Color.Silver;
            dgvWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWords.Columns.AddRange(new DataGridViewColumn[] { colNumber, colEnglish, colMongolian, colRussian });
            dgvWords.Location = new Point(12, 94);
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
            colNumber.HeaderText = "№";
            colNumber.MinimumWidth = 6;
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            // 
            // colEnglish
            // 
            colEnglish.HeaderText = "Англи";
            colEnglish.MinimumWidth = 6;
            colEnglish.Name = "colEnglish";
            colEnglish.ReadOnly = true;
            // 
            // colMongolian
            // 
            colMongolian.HeaderText = "Монгол";
            colMongolian.MinimumWidth = 6;
            colMongolian.Name = "colMongolian";
            colMongolian.ReadOnly = true;
            // 
            // colRussian
            // 
            colRussian.HeaderText = "Орос";
            colRussian.MinimumWidth = 6;
            colRussian.Name = "colRussian";
            colRussian.ReadOnly = true;
            // 
            // lblEnglish
            // 
            lblEnglish.AutoSize = true;
            lblEnglish.Location = new Point(12, 599);
            lblEnglish.Name = "lblEnglish";
            lblEnglish.Size = new Size(55, 20);
            lblEnglish.TabIndex = 5;
            lblEnglish.Text = "Англи ";
            // 
            // lblMongolian
            // 
            lblMongolian.AutoSize = true;
            lblMongolian.Location = new Point(192, 599);
            lblMongolian.Name = "lblMongolian";
            lblMongolian.Size = new Size(63, 20);
            lblMongolian.TabIndex = 6;
            lblMongolian.Text = "Монгол";
            // 
            // lblRussian
            // 
            lblRussian.AutoSize = true;
            lblRussian.Location = new Point(414, 603);
            lblRussian.Name = "lblRussian";
            lblRussian.Size = new Size(45, 20);
            lblRussian.TabIndex = 7;
            lblRussian.Text = "Орос";
            lblRussian.Click += label3_Click;
            // 
            // txtRussian
            // 
            txtRussian.Location = new Point(465, 596);
            txtRussian.Name = "txtRussian";
            txtRussian.Size = new Size(125, 27);
            txtRussian.TabIndex = 8;
            // 
            // txtMongolian
            // 
            txtMongolian.Location = new Point(261, 596);
            txtMongolian.Name = "txtMongolian";
            txtMongolian.Size = new Size(125, 27);
            txtMongolian.TabIndex = 9;
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(61, 596);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(125, 27);
            txtEnglish.TabIndex = 10;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(641, 15);
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
            // lblSavedHeader
            // 
            lblSavedHeader.AutoSize = true;
            lblSavedHeader.BackColor = Color.Chartreuse;
            lblSavedHeader.BorderStyle = BorderStyle.FixedSingle;
            lblSavedHeader.ForeColor = Color.DarkGreen;
            lblSavedHeader.Location = new Point(641, 128);
            lblSavedHeader.Name = "lblSavedHeader";
            lblSavedHeader.Size = new Size(86, 22);
            lblSavedHeader.TabIndex = 14;
            lblSavedHeader.Text = "Санасан үг";
            lblSavedHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstSaved
            // 
            lstSaved.BorderStyle = BorderStyle.FixedSingle;
            lstSaved.FormattingEnabled = true;
            lstSaved.Location = new Point(641, 162);
            lstSaved.Name = "lstSaved";
            lstSaved.Size = new Size(206, 22);
            lstSaved.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 638);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+Нэмэх";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(496, 638);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "\t▣Санах";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(365, 638);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 18;
            btnClear.Text = "⟳Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(243, 638);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.No;
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "\t▤Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(132, 638);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "✎Засах";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(12, 673);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 28);
            lblTitle.TabIndex = 21;
            lblTitle.Text = "Нийт: 10 үг · Санасан: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 710);
            Controls.Add(lblTitle);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(lstSaved);
            Controls.Add(lblSavedHeader);
            Controls.Add(lblSavedTitle);
            Controls.Add(lblWordsTitle);
            Controls.Add(lblLanguage);
            Controls.Add(txtEnglish);
            Controls.Add(txtMongolian);
            Controls.Add(txtRussian);
            Controls.Add(lblRussian);
            Controls.Add(lblMongolian);
            Controls.Add(lblEnglish);
            Controls.Add(dgvWords);
            Controls.Add(btnSearch);
            Controls.Add(cmbLanguage);
            Controls.Add(txtSearch);
            MinimumSize = new Size(1000, 700);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гурван хэлний толь бичиг";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private ComboBox cmbLanguage;
        private Button btnSearch;
        private DataGridView dgvWords;
        private Label lblEnglish;
        private Label lblMongolian;
        private Label lblRussian;
        private TextBox txtRussian;
        private TextBox txtMongolian;
        private TextBox txtEnglish;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colEnglish;
        private DataGridViewTextBoxColumn colMongolian;
        private DataGridViewTextBoxColumn colRussian;
        private Label lblLanguage;
        private Label lblWordsTitle;
        private Label lblSavedTitle;
        private Label lblSavedHeader;
        private ListBox lstSaved;
        private Button btnAdd;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Label lblTitle;
    }
}
