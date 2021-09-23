
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
    public partial class TJ_Form : Form
    {
        public TJ_Form()
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

                Command.CommandText = "dbo.USP_tj_list_S1";

                Command.Parameters.AddWithValue("@tj_cd", "");

                Command.Parameters.AddWithValue("@tj_nm", "");

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

                SqlCommand Command = new SqlCommand(); // MSDB 에서 사용할 QUERRY 문 , 프로시저 를 나타내는 CLASS

                Command.Connection = DBConn;

                Command.CommandType = CommandType.StoredProcedure;

                //저장프로시저명

                Command.CommandText = "dbo.usp_tj_list_I1"; // 가져올 프로시져

                // 프로시저 에 저장 되어 있는 Parmater 가 받을 데이터 입력.
                Command.Parameters.AddWithValue("@tj_cd", dgv_Search.CurrentRow.Cells["tj_cd"].Value);

                Command.Parameters.AddWithValue("@tj_nm", dgv_Search.CurrentRow.Cells["tj_nm"].Value);

                Command.Parameters.AddWithValue("@tj_leader", dgv_Search.CurrentRow.Cells["tj_leader"].Value);

                Command.Parameters.AddWithValue("@tj_address", dgv_Search.CurrentRow.Cells["tj_address"].Value);

                if (string.IsNullOrWhiteSpace(dgv_Search.CurrentRow.Cells["tj_cd"].Value.ToString()))
                {
                    MessageBox.Show("거래처 잘 관리해라", "Information");


                }
                else if (string.IsNullOrWhiteSpace(dgv_Search.CurrentRow.Cells["tj_nm"].Value.ToString()))
                {
                    MessageBox.Show("업체명은 알아야지 그치?", "Information");

                }
                else if (string.IsNullOrWhiteSpace(dgv_Search.CurrentRow.Cells["tj_leader"].Value.ToString()))
                {
                    MessageBox.Show("대표자명도 기입해라 좀", "Information");


                }
                else
                {
                    Command.ExecuteNonQuery();
                    DBConn.Close();
                    MessageBox.Show("데이터가 저장됐습니다.", "Information");
                    dgv_Search.AllowUserToAddRows = false;


                }

            }

            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }

        }

        private void btn_update_click(object sender, EventArgs e)
        {
            try

            {


                SqlConnection DBConn = new SqlConnection();

                //DB 연결 변수


                DBConn.ConnectionString = "Server = DESKTOP-CPJQVAP\\LEEHJ; database = Hurato; uid =sa; pwd = 1234 ";

                //DB 열기

                DBConn.Open();



                //저장프로시저 사용

                SqlCommand Command = new SqlCommand();

                Command.Connection = DBConn;

                Command.CommandType = CommandType.StoredProcedure;

                //저장프로시저명

                Command.CommandText = "dbo.usp_tj_list_U1";

                Command.Parameters.AddWithValue("@tj_cd", dgv_Search.CurrentRow.Cells["tj_cd"].Value);

                Command.Parameters.AddWithValue("@tj_nm", dgv_Search.CurrentRow.Cells["tj_nm"].Value);

                Command.Parameters.AddWithValue("@tj_leader", dgv_Search.CurrentRow.Cells["tj_leader"].Value);

                Command.Parameters.AddWithValue("@tj_address", dgv_Search.CurrentRow.Cells["tj_address"].Value);





                MessageBox.Show("수정에 성공 했습니다.", "Information");
                Command.ExecuteNonQuery();





                //DB 닫기

                DBConn.Close();


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

                Command.CommandText = "dbo.usp_tj_list_D1";


                Command.Parameters.AddWithValue("@tj_CD", dgv_Search.CurrentRow.Cells["tj_cd"].Value);




                //삭제 처리 성공여부 체크


                Command.ExecuteNonQuery();
                MessageBox.Show("삭제에 성공 했습니다.", "Information");


                //DB 닫기

                DBConn.Close();


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
        }
    }
}
