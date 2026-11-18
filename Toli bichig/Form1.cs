using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
namespace Toli_bichig
{
    public partial class Form1 : Form
    {
        private string dbPath = Path.Combine(
    Application.StartupPath, "toli.db");

        private string savedDbPath = Path.Combine(
            Application.StartupPath, "saved.db");
        public Form1()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSort.Items.Clear();

            cmbSort.Items.Add("ID");
            cmbSort.Items.Add("Англи");
            cmbSort.Items.Add("Монгол");

            cmbSort.SelectedIndex = 0;

            LoadSavedWords();
            LoadWords();
        }
        private string GetSortColumn()
        {
            if (cmbSort.SelectedIndex == 1)
                return "eng";

            if (cmbSort.SelectedIndex == 2)
                return "mon";

            return "id";
        }
        private void LoadWords()
        {
            try
            {
                using (var connection = new SqliteConnection(
                    $"Data Source={dbPath}"))
                {
                    connection.Open();

                    string sortColumn = GetSortColumn();

                    string query = $@"
                SELECT 
                    id AS realId,
                    ROW_NUMBER() OVER (ORDER BY {sortColumn}) AS displayNumber,
                    eng, mon, rus
                FROM words
                ORDER BY {sortColumn}";

                    using (var command = new SqliteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dgvWords.AutoGenerateColumns = false;

                        dgvWords.Columns["colNumber"].DataPropertyName = "displayNumber";
                        dgvWords.Columns["colEnglish"].DataPropertyName = "eng";
                        dgvWords.Columns["colMongolian"].DataPropertyName = "mon";
                        dgvWords.Columns["colRussian"].DataPropertyName = "rus";

                        dgvWords.DataSource = table;

                        dgvWords.ReadOnly = true;
                        dgvWords.AllowUserToAddRows = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Алдаа: " + ex.Message);
            }
        }
        private void LoadSavedWords()
        {
            try
            {
                using (var connection = new SqliteConnection(
                    $"Data Source={savedDbPath}"))
                {
                    connection.Open();

                    string query = "SELECT eng, mon, rus FROM saved_words";

                    using (var command = new SqliteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        MessageBox.Show("Хадгалсан үгийн тоо: " + table.Rows.Count);

                        dataGridView1.DataSource = null;
                        dataGridView1.Columns.Clear();
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = table;

                        dataGridView1.ReadOnly = true;
                        dataGridView1.AllowUserToAddRows = false;
                        dataGridView1.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Хадгалсан үг ачаалахад алдаа гарлаа: " + ex.Message);
            }
        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadWords();
                return;
            }

            try
            {
                using (var connection = new SqliteConnection(
                    $"Data Source={dbPath}"))
                {
                    connection.Open();

                    string sortColumn = GetSortColumn();

                    string query = $@"
    SELECT 
        id AS realId,
        ROW_NUMBER() OVER (ORDER BY {sortColumn}) AS displayNumber,
        eng, mon, rus
    FROM words
    WHERE eng LIKE @search
       OR mon LIKE @search
       OR rus LIKE @search
    ORDER BY {sortColumn}";

                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@search", "%" + searchText + "%");

                        using (var reader = command.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            dgvWords.AutoGenerateColumns = false;

                            dgvWords.Columns["colNumber"].DataPropertyName = "displayNumber";
                            dgvWords.Columns["colEnglish"].DataPropertyName = "eng";
                            dgvWords.Columns["colMongolian"].DataPropertyName = "mon";
                            dgvWords.Columns["colRussian"].DataPropertyName = "rus";

                            dgvWords.DataSource = table;

                            dgvWords.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Хайлтын алдаа: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string eng = txtEnglish.Text.Trim();
            string mon = txtMongolian.Text.Trim();
            string rus = txtRussian.Text.Trim();

            if (eng == "" || mon == "" || rus == "")
            {
                MessageBox.Show("Гурван хэлний үгийг бүрэн оруулна уу!");
                return;
            }

            try
            {
                using (var connection = new SqliteConnection(
                    $"Data Source={dbPath}"))
                {
                    connection.Open();

                    // Англи үг байгаа эсэхийг шалгах
                    string checkQuery =
                        "SELECT COUNT(*) FROM words WHERE LOWER(eng) = LOWER(@eng)";

                    using (var checkCommand =
                        new SqliteCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@eng", eng);

                        long count = Convert.ToInt64(checkCommand.ExecuteScalar() ?? 0);

                        if (count > 0)
                        {
                            MessageBox.Show("Энэ үг байна!");
                            return;
                        }
                    }

                    string query = @"
                INSERT INTO words (eng, mon, rus)
                VALUES (@eng, @mon, @rus)";

                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@eng", eng);
                        command.Parameters.AddWithValue("@mon", mon);
                        command.Parameters.AddWithValue("@rus", rus);

                        command.ExecuteNonQuery();
                    }
                }

                LoadWords();

                txtEnglish.Clear();
                txtMongolian.Clear();
                txtRussian.Clear();

                MessageBox.Show("Үг амжилттай нэмэгдлээ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Алдаа: " + ex.Message);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvWords.CurrentRow == null)
            {
                MessageBox.Show("Засах үгээ сонгоно уу!");
                return;
            }
            if (dgvWords.CurrentRow.DataBoundItem is not DataRowView row)
            {
                MessageBox.Show("Мөрийн мэдээллийг уншиж чадсангүй!");
                return;
            }


            if (row == null)
            {
                MessageBox.Show("Мөрийн мэдээллийг уншиж чадсангүй!");
                return;
            }
            if (!row.Row.Table.Columns.Contains("realId"))
            {
                MessageBox.Show("realId багана олдсонгүй!");
                return;
            }

            if (row["realId"] == DBNull.Value)
            {
                MessageBox.Show("ID утга хоосон байна!");
                return;
            }



            int id = Convert.ToInt32(row["realId"]);

            string eng = txtEnglish.Text.Trim();
            string mon = txtMongolian.Text.Trim();
            string rus = txtRussian.Text.Trim();

            if (eng == "" || mon == "" || rus == "")
            {
                MessageBox.Show("Гурван хэлний мэдээллийг бүрэн оруулна уу!");
                return;
            }

            try
            {
                using (var connection = new SqliteConnection($"Data Source={dbPath}"))
                {
                    connection.Open();

                    string query = @"
                UPDATE words
                SET eng = @eng, mon = @mon, rus = @rus
                WHERE id = @id";

                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@eng", eng);
                        command.Parameters.AddWithValue("@mon", mon);
                        command.Parameters.AddWithValue("@rus", rus);
                        command.Parameters.AddWithValue("@id", id);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            LoadWords();
                            MessageBox.Show("Үг амжилттай засагдлаа!");
                        }
                        else
                        {
                            MessageBox.Show("Засах үг олдсонгүй!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Засахад алдаа гарлаа: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvWords.CurrentRow == null)
            {
                MessageBox.Show("Устгах үгээ сонгоно уу!");
                return;
            }

            if (dgvWords.CurrentRow.DataBoundItem is not DataRowView row)
            {
                MessageBox.Show("Мөрийн мэдээллийг уншиж чадсангүй!");
                return;
            }

            int id = Convert.ToInt32(row["realId"]);

            DialogResult result = MessageBox.Show(
                "Сонгосон үгийг устгах уу?",
                "Устгах баталгаажуулалт",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (var connection = new SqliteConnection($"Data Source={dbPath}"))
                {
                    connection.Open();

                    string query = "DELETE FROM words WHERE id = @id";

                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }

                LoadWords();

                MessageBox.Show("Үг амжилттай устгагдлаа!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Устгахад алдаа гарлаа: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvWords.CurrentRow == null)
            {
                MessageBox.Show("Санах үгээ хүснэгтээс сонгоно уу!");
                return;
            }

            if (dgvWords.CurrentRow.DataBoundItem is not DataRowView row)
            {
                MessageBox.Show("Үгийн мэдээллийг уншиж чадсангүй!");
                return;
            }

            string eng = row["eng"].ToString();
            string mon = row["mon"].ToString();
            string rus = row["rus"].ToString();

            try
            {
                using (var connection = new SqliteConnection(
                    $"Data Source={savedDbPath}"))
                {
                    connection.Open();

                    string query = @"
                INSERT INTO saved_words (eng, mon, rus)
                SELECT @eng, @mon, @rus
                WHERE NOT EXISTS (
                    SELECT 1 FROM saved_words WHERE eng = @eng
                )";

                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@eng", eng);
                        command.Parameters.AddWithValue("@mon", mon);
                        command.Parameters.AddWithValue("@rus", rus);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Үг амжилттай хадгалагдлаа!");
                        }
                        else
                        {
                            MessageBox.Show("Энэ үг өмнө нь хадгалагдсан байна!");
                        }
                    }
                }

                LoadSavedWords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Хадгалахад алдаа гарлаа: " + ex.Message);
            }
        }

        private void lstSaved_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnglish.Clear();
            txtMongolian.Clear();
            txtRussian.Clear();
            txtSearch.Clear();

            dgvWords.ClearSelection();

            MessageBox.Show("Талбарууд амжилттай цэвэрлэгдлээ!");
        }

        private void btnRemoveSaved_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Хасах үгээ сонгоно уу!");
                return;
            }

            if (dataGridView1.CurrentRow.DataBoundItem is not DataRowView row)
            {
                MessageBox.Show("Үгийн мэдээллийг уншиж чадсангүй!");
                return;
            }

            string eng = row["eng"].ToString();

            DialogResult result = MessageBox.Show(
                "Санасан жагсаалтаас энэ үгийг хасах уу?",
                "Баталгаажуулалт",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (var connection = new SqliteConnection(
                    $"Data Source={savedDbPath}"))
                {
                    connection.Open();

                    string query = "DELETE FROM saved_words WHERE eng = @eng";

                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@eng", eng);
                        command.ExecuteNonQuery();
                    }
                }

                LoadSavedWords();

                MessageBox.Show("Үг санасан жагсаалтаас хасагдлаа!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Хасахад алдаа гарлаа: " + ex.Message);
            }
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.SelectedIndex == -1)
                return;

            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadWords();
            }
            else
            {
                btnSearch_Click(sender, e);
            }
            
        }
    }
}
