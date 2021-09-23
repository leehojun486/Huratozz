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

namespace wujudaesselleagi
{
    public partial class select2 : Form
    {
        private string item_cd_value;
        private string item_nm_value;

        public string Passvalue
        {
            get { return this.item_cd_value; } // Form2에서 얻은(get) 값을 다른폼(Form1)으로 전달 목적
            set { this.item_cd_value = value; }  // 다른폼(Form1)에서 전달받은 값을 쓰기
        }
        public string Passvalue2
        {
            get { return this.item_nm_value; } // Form2에서 얻은(get) 값을 다른폼(Form1)으로 전달 목적
            set { this.item_nm_value = value; }  // 다른폼(Form1)에서 전달받은 값을 쓰기
        }
        public select2()
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

                    Command.CommandText = "dbo.USP_item_list_S1";

                    Command.Parameters.AddWithValue("@item_cd", "");

                    Command.Parameters.AddWithValue("@item_nm", "");

                    dgv_Search.ReadOnly = false;

                    var daSearch = new SqlDataAdapter(Command);


                    var dsSearch = new DataSet();


                    //DataSEt에 Customers 테이블 만들고 그 테이블에 데이터를 저장

                    daSearch.Fill(dsSearch);


                    dgv_Search.DataSource = dsSearch.Tables[0];


                    //DataSet 내부의 테이블 이름



                    Command.ExecuteNonQuery();

                    //DB 닫기

                    DBConn.Close();
                    dgv_Search.AllowUserToAddRows = false;
                    dgv_Search.Columns["item_cd1"].ReadOnly = true;
               

            }

            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }
        }

        private void Btn_select_degree_click(object sender, EventArgs e)
        {
            Passvalue = TB.Text;   //Form2로 데이터를 보냄
            Passvalue2 = TB2.Text;  //Form2로 데이터를 보냄
            this.Hide();          // 검색폼 닫기

        }
        private void dgv_search_RowEnters(object sender, DataGridViewCellEventArgs e)
        {
            TB.Text = dgv_Search.Rows[e.RowIndex].Cells["item_cd1"].Value.ToString();   //선택한 셀의 cide 를 TB에저장
            TB2.Text = dgv_Search.Rows[e.RowIndex].Cells["item_nm1"].Value.ToString();  // 선택한 셀의 name 을 TB2에 저장
        }

        private void barogo(object sender, DataGridViewCellEventArgs e)
        {
            TB.Text = dgv_Search.Rows[e.RowIndex].Cells["item_cd1"].Value.ToString();   //선택한 셀의 cide 를 TB에저장
            TB2.Text = dgv_Search.Rows[e.RowIndex].Cells["item_nm1"].Value.ToString();  // 선택한 셀의 name 을 TB2에 저장
            Passvalue = TB.Text;   //Form2로 데이터를 보냄
            Passvalue2 = TB2.Text;  //Form2로 데이터를 보냄
            this.Hide();          // 검색폼 닫기
        }
    }
}
