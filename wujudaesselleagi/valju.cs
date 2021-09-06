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
    public partial class valju : Form
    {
        public valju()
        {
            InitializeComponent();
        }

        private void valju_Load(object sender, EventArgs e)
        {
          

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

                Command.CommandText = "dbo.USP_order_S1";

                Command.Parameters.AddWithValue("@order_no", "");

                Command.Parameters.AddWithValue("@order_date", "");
                Command.Parameters.AddWithValue("@order_tj_nm", "");
                Command.Parameters.AddWithValue("@tj_cd", "");

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
        private void Add_item_Click(object sender, EventArgs e)
        {
            dgv_Search.AllowUserToAddRows = true;
        }


    }
}
