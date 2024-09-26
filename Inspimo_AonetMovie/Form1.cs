using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inspimo_AonetMovie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=DESKTOP-KR485FT\\SQLEXPRESS; initial catalog=InspimoMovieDb; integrated security=true;");

        private void AllCategoryList()
        {
            SqlCommand command = new SqlCommand("Select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgCategory.DataSource = dt;
        }

        private void btnCategoryEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName)values(@p1)", connection);
            command.Parameters.AddWithValue("@p1", txtCategoryAdi.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AllCategoryList();
            ClearToTexts();
            connection.Close();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from TblCategory where CategoryID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtCategoryID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            AllCategoryList();
            ClearToTexts();
            connection.Close();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update TblCategory set CategoryName=@p1 where CategoryID=@p2", connection);
            command.Parameters.AddWithValue("@p1", txtCategoryAdi.Text);
            command.Parameters.AddWithValue("@p2", txtCategoryID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AllCategoryList();
            ClearToTexts();
            connection.Close();
        }

        private void ClearToTexts()
        {
            txtCategoryAdi.Text = "";
            txtCategoryID.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllCategoryList();
            AllMovieListWithCategory();
            ListCategoryIntoCombobox();

            GetCategoryCount();
            GetMovieCount();
            GetAvarageOfAllFilms();
            GEtTopOneFilmName();
        }

        private void GEtTopOneFilmName()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT MovieName FROM TblMovie WHERE MovieImdb = (SELECT MAX(MovieImdb) FROM TblMovie)", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblTopOneFilmName.Text = dr[0].ToString();
            }
            connection.Close();
        }

        private void GetAvarageOfAllFilms()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select Round(AVG(Cast(MovieImdb as Float)),1) From TblMovie", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblAverageImdb.Text = dr[0].ToString();
            }
            connection.Close();
        }

        private void GetMovieCount()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select Count(*) From TblMovie", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblMovieCount.Text = dr[0].ToString();
            }
            connection.Close();
        }

        private void GetCategoryCount()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select Count(*) From TblCategory",connection);
            SqlDataReader dr=command.ExecuteReader();
            while (dr.Read())
            {
                lblKategoriCount.Text = dr[0].ToString();
            }
            connection.Close();
        }

        private void AllMovieListWithCategory()
        {
            SqlCommand command = new SqlCommand("Exec MovieListWithCategory", connection); //Prosedür ile çektim.
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgMovie.DataSource = dt;
        }

        private void ListCategoryIntoCombobox()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbKategori.ValueMember = "CategoryID";//Arka taraf da çalışacak olan kod
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.DataSource = dt;
            connection.Close();
        }

        private void btnMovieSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblMovie (MovieName,MovieDuration,MovieImdb,MovieCategory) values(@p1,@p2,@p3,@p4)", connection);
            command.Parameters.AddWithValue("@p1", txtMovieName.Text);
            command.Parameters.AddWithValue("@p2", txtMovieDuration.Text);
            command.Parameters.AddWithValue("@p3", txtMovieImdb.Text);
            command.Parameters.AddWithValue("@p4", cmbKategori.SelectedValue);
            command.ExecuteNonQuery();
            MessageBox.Show("Filminiz Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AllMovieListWithCategory();
            ClearToMovieTexts();
            connection.Close();
        }

        private void ClearToMovieTexts()
        {
            txtMovieDuration.Text = "";
            txtMovieID.Text = "";
            txtMovieImdb.Text = "";
            txtMovieName.Text = "";
            cmbKategori.Text = "";
        }

        private void btnMovieDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from TblMovie where MovieID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtMovieID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Filminiz Başarılı Bir Şekilde Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            AllMovieListWithCategory();
            ClearToMovieTexts();
            connection.Close();
        }

        private void dtgMovie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Seçili satırı al
                DataGridViewRow selectedRow = dtgMovie.Rows[e.RowIndex];

                // Hücre değerlerini al ve TextBox'lara yazdır
                txtMovieID.Text = selectedRow.Cells["MovieID"].Value.ToString();
                txtMovieName.Text = selectedRow.Cells["MovieName"].Value.ToString();
                txtMovieImdb.Text = selectedRow.Cells["MovieImdb"].Value.ToString();
                txtMovieDuration.Text = selectedRow.Cells["MovieDuration"].Value.ToString();
                cmbKategori.Text = selectedRow.Cells["CategoryName"].Value.ToString();
            }
        }

        private void btnMovieUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update TblMovie set MovieName=@p1,MovieDuration=@p2,MovieImdb=@p3,MovieCategory=@p4 where MovieID=@p5", connection);
            command.Parameters.AddWithValue("@p1", txtMovieName.Text);
            command.Parameters.AddWithValue("@p2", txtMovieDuration.Text);
            command.Parameters.AddWithValue("@p3", txtMovieImdb.Text);
            command.Parameters.AddWithValue("@p4", cmbKategori.SelectedValue);
            command.Parameters.AddWithValue("@p5", txtMovieID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Filminiz Başarılı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AllMovieListWithCategory();
            ClearToTexts();
            connection.Close();
        }
    }
}
