
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace wujudaesselleagi
{
    public partial class staff_list : Form
    {
        public staff_list()
        {
            InitializeComponent();
        }

        private void btn_select_click(object sender, EventArgs e)
        {
            try

            {

                var DBConn = new SqlConnection();

                //DB 연결 변수

                DBConn.ConnectionString = "Server = DESKTOP-CPJQVAP\\LEEHJ; database = Hurato; uid =sa; pwd = 1234 ";

                //DB 열기

                DBConn.Open();



                //저장프로시저 사용

                var Command = new SqlCommand();

                Command.Connection = DBConn;

                var commandSearch = new SqlCommand();

                commandSearch.Connection = DBConn;


                Command.CommandType = CommandType.StoredProcedure;

                //저장프로시저명

                Command.CommandText = "dbo.staff_list_S1";

                Command.Parameters.AddWithValue("@staff_cd", "");

                Command.Parameters.AddWithValue("@staff_nm", "");

                dgv_Search.ReadOnly = false;

                var daSearch = new SqlDataAdapter(Command);


                var dsSearch = new DataSet();


                //DataSEt에 Customers 테이블 만들고 그 테이블에 데이터를 저장

                daSearch.Fill(dsSearch);


                dgv_Search.DataSource = dsSearch.Tables[0];


                //DataSet 내부의 테이블 이름



                MessageBox.Show("데이터가 조회됐습니다.", "Information");



                Command.ExecuteNonQuery();

                //DB 닫기

                DBConn.Close();
              
                dgv_Search.Columns["staff_cd"].ReadOnly = true;

            }

            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btn_add_click(object sender, EventArgs e)
        {

            try

            {

                SqlConnection DBConn = new SqlConnection(); // DB에 대한 연결을 나타내는 클래스



                DBConn.ConnectionString = "Server = DESKTOP-CPJQVAP\\LEEHJ; database = Hurato; uid =sa; pwd = 1234 ";



                DBConn.Open(); //DB 열기



                //저장프로시저 사용
                if (dgv_Search.AllowUserToAddRows == true)
                {

                    SqlCommand Command = new SqlCommand(); // MSDB 에서 사용할 QUERRY 문 , 프로시저 를 나타내는 CLASS

                    Command.Connection = DBConn;

                    Command.CommandType = CommandType.StoredProcedure;

                    //저장프로시저명

                    Command.CommandText = "dbo.usp_staff_list_I1"; // 가져올 프로시져

                    // 프로시저 에 저장 되어 있는 Parmater 가 받을 데이터 입력.
                    Command.Parameters.AddWithValue("@staff_cd", dgv_Search.CurrentRow.Cells["staff_cd"].Value);

                    Command.Parameters.AddWithValue("@staff_nm", dgv_Search.CurrentRow.Cells["staff_nm"].Value);

                    Command.Parameters.AddWithValue("@staff_mw", dgv_Search.CurrentRow.Cells["staff_mw"].Value);

                    Command.Parameters.AddWithValue("@staff_position", dgv_Search.CurrentRow.Cells["staff_position"].Value);

                    if (string.IsNullOrWhiteSpace(dgv_Search.CurrentRow.Cells["staff_cd"].Value.ToString()))
                    {
                        MessageBox.Show("직원코드 없으면 난리난다", "Information");


                    }
                    else if (string.IsNullOrWhiteSpace(dgv_Search.CurrentRow.Cells["staff_nm"].Value.ToString()))
                    {
                        MessageBox.Show("이름은 알아야지 인간적으로", "Information");

                    }
                    else if (string.IsNullOrWhiteSpace(dgv_Search.CurrentRow.Cells["staff_mw"].Value.ToString()))
                    {
                        MessageBox.Show("니 시급적게 주기만해 클난다", "Information");


                    }
                    else
                    {
                        Command.ExecuteNonQuery();
                        DBConn.Close();
                        MessageBox.Show("데이터가 저장됐습니다.", "Information");
                        dgv_Search.AllowUserToAddRows = false;


                    }

                    dgv_Search.Columns["staff_cd"].ReadOnly = true;

                }
                else if (dgv_Search.AllowUserToAddRows == false)
                {
                    //저장프로시저 사용

                    SqlCommand Command = new SqlCommand();

                    Command.Connection = DBConn;

                    Command.CommandType = CommandType.StoredProcedure;

                    //저장프로시저명

                    Command.CommandText = "dbo.usp_staff_list_U1";

                    Command.Parameters.AddWithValue("@staff_cd", dgv_Search.CurrentRow.Cells["staff_cd"].Value);

                    Command.Parameters.AddWithValue("@staff_nm", dgv_Search.CurrentRow.Cells["staff_nm"].Value);

                    Command.Parameters.AddWithValue("@staff_mw", dgv_Search.CurrentRow.Cells["staff_mw"].Value);

                    Command.Parameters.AddWithValue("@staff_position", dgv_Search.CurrentRow.Cells["staff_position"].Value);





                    MessageBox.Show("수정에 성공 했습니다.", "Information");
                    Command.ExecuteNonQuery();





                    //DB 닫기

                    DBConn.Close();

                    dgv_Search.Columns["staff_cd"].ReadOnly = true;
                }
            }

         


            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }

        }


        private void btn_click_delete(object sender, EventArgs e)
        {
            try

            {


                var DBConn = new SqlConnection();

                //DB 연결 변수

                DBConn.ConnectionString = "Server = DESKTOP-CPJQVAP\\LEEHJ; database = Hurato; uid =sa; pwd = 1234 ";

                //DB 열기

                DBConn.Open();



                //저장프로시저 사용

                var Command = new SqlCommand();

                Command.Connection = DBConn;

                Command.CommandType = CommandType.StoredProcedure;

                //저장프로시저명

                Command.CommandText = "dbo.usp_staff_list_D1";


                Command.Parameters.AddWithValue("@staff_CD", dgv_Search.CurrentRow.Cells["staff_cd"].Value);




                //삭제 처리 성공여부 체크


                Command.ExecuteNonQuery();
                MessageBox.Show("삭제에 성공 했습니다.", "Information");


                //DB 닫기

                DBConn.Close();
          
                dgv_Search.Columns["staff_cd"].ReadOnly = true;


            }

            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }
        }


        private void CSV_SAVE_click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\aeter\Desktop\Wording\새 폴더\test.csv", false, Encoding.GetEncoding("UTF-8"));

            for (int i = 0; i < dgv_Search.Columns.Count; i++)
            {
                writer.Write(dgv_Search.Columns[i].HeaderText);
                if (i != dgv_Search.Columns.Count)
                {
                    writer.Write(",");
                }

            }
            writer.Write(writer.NewLine);
            foreach (DataGridViewRow dr in dgv_Search.Rows)
            {
                for (int i = 0; i < dgv_Search.Columns.Count; i++)
                {
                    writer.Write(dr.Cells[i].Value);
                    if (i != dgv_Search.Columns.Count)
                    {
                        writer.Write(",");

                    }
                }
                writer.Write(writer.NewLine);
            }
            writer.Flush();

            writer.Close();

        }

        private void item_nm_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void item_nm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Add_item_Click(object sender, EventArgs e)
        {
            dgv_Search.AllowUserToAddRows = true;
            dgv_Search.Columns["staff_cd"].ReadOnly = false;
        }
    }
}
