using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mybook
{
    public partial class Book : Form
    {
        String Mode = "";
        string strconn = " SERVER = 192.168.0.156; DATABASE = mybook ;UID = root ; PASSWORD = 1234; ";
        public Book()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(242, 220, 240);
        }

        private void Book_Load(object sender, EventArgs e)
        {
            updatadataGridView();
        }

        private void updatadataGridView()
        {
            MySqlConnection conn;
            DataSet ds = new DataSet();
            conn = new MySqlConnection(strconn);
            string strSelect = "";
            using (MySqlConnection aMySqlConnection = new MySqlConnection(strconn))
            {
                conn.Open();

                strSelect = "SELECT isbn as ISBN,Name as 책이름, publisher as 출판사 , page as '페이지 수' FROM tblBook;";//본인의 TABLE 이름 
                MySqlCommand cmd = new MySqlCommand(strSelect, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "data");

                conn.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "data";
            }

        }

        private bool ChecingPrimaryKey()
        {
            List<string> alist = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT isbn FROM tblBook WHERE isbn = @isbn ";
                cmd.Parameters.AddWithValue("@isbn", txtIsbn.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    alist.Add(reader[0].ToString());
                }

                return (alist.Count > 0);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Mode = "INSERT";
            txtName.Text = "";
            txtIsbn.Text = "";
            txtPage.Text = "";
            txtPub.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Mode == "INSERT")
            {
                if (txtIsbn.Text == "")
                {
                    MessageBox.Show("Isbn을 입력해주세요");
                    return;
                }
                else if (txtName.Text == "")
                {
                    MessageBox.Show("책이름 입력해주세요");
                    return;
                }
                else if (txtPub.Text == "")
                {
                    MessageBox.Show("출판사를 입력해주세요");
                    return;
                }
                else if (txtPage.Text == "")
                {
                    MessageBox.Show("페이지수를  입력해주세요");
                    return;
                }

                if (ChecingPrimaryKey())
                {
                    MessageBox.Show("isbn이 중복됩니다.");
                }
                else
                {
                    using (MySqlConnection conn = new MySqlConnection(strconn))
                    {
                        DataSet ds = new DataSet();
                        conn.Open();

                        // 2개의 파라미터 정의 (항상 @로 시작)
                        string sql = "INSERT INTO tblBook  (isbn,name,Publisher,page) VALUES( @isbn ,  @name ,  @Publisher,   @page)";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        MySqlParameter paramCity = new MySqlParameter("@isbn", MySqlDbType.VarChar, 10);
                        paramCity.Value = txtIsbn.Text;
                        cmd.Parameters.Add(paramCity);

                        paramCity = new MySqlParameter("@name", MySqlDbType.VarChar, 30);
                        paramCity.Value = txtName.Text;
                        cmd.Parameters.Add(paramCity);

                        paramCity = new MySqlParameter("@publisher", MySqlDbType.VarChar, 30);
                        paramCity.Value = txtPub.Text;
                        cmd.Parameters.Add(paramCity);

                        paramCity = new MySqlParameter("@page", MySqlDbType.VarChar, 20);
                        paramCity.Value = txtPage.Text;
                        cmd.Parameters.Add(paramCity);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(this, "추가되었습니다.");
                        Mode = "";

                    }
                    updatadataGridView();
                }
            }
            else
            {
                MessageBox.Show("신규를 누르고 저장해주세요");
            }
            Mode = "";

        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                DataSet ds = new DataSet();
                conn.Open();

                // 2개의 파라미터 정의 (항상 @로 시작)
                string sql = "UPDATE tblBook SET isbn=@isbn , name = @name , publisher = @publisher , page =@page  WHERE isbn=@isbn";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlParameter paramCity = new MySqlParameter("@isbn", MySqlDbType.VarChar, 10);
                paramCity.Value = txtIsbn.Text;
                cmd.Parameters.Add(paramCity);

                paramCity = new MySqlParameter("@name", MySqlDbType.VarChar, 30);
                paramCity.Value = txtName.Text;
                cmd.Parameters.Add(paramCity);

                paramCity = new MySqlParameter("@publisher", MySqlDbType.VarChar, 30);
                paramCity.Value = txtPub.Text;
                cmd.Parameters.Add(paramCity);

                paramCity = new MySqlParameter("@page", MySqlDbType.VarChar, 20);
                paramCity.Value = txtPage.Text;
                cmd.Parameters.Add(paramCity);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(this, "저장되었습니다.");
            }

            Mode = "";

            updatadataGridView();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtIsbn.Text == "")
            {
                MessageBox.Show("Isbn을 입력해주세요");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                DataSet ds = new DataSet();
                conn.Open();

                // 2개의 파라미터 정의 (항상 @로 시작)
                string sql = " DELETE FROM tblBook WHERE isbn = @isbn ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlParameter paramCity = new MySqlParameter("@isbn", MySqlDbType.VarChar, 10);
                paramCity.Value = txtIsbn.Text;
                cmd.Parameters.Add(paramCity);


                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(this, "삭제되었습니다.");
                Mode = "";

            }
            updatadataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIsbn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPub.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPage.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Mode = "";
        }

      
    }
}
