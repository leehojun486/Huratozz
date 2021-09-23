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
    public partial class select : Form
    {
        private string tjcd_value;
        private string order_tj_nm_value2;

        public string Passvalue
        {
            get { return this.tjcd_value; } // Form2에서 얻은(get) 값을 다른폼(Form1)으로 전달 목적
            set { this.tjcd_value = value; }  // 다른폼(Form1)에서 전달받은 값을 쓰기
        }
        public string Passvalue2
        {
            get { return this.order_tj_nm_value2; } // Form2에서 얻은(get) 값을 다른폼(Form1)으로 전달 목적
            set { this.order_tj_nm_value2 = value; }  // 다른폼(Form1)에서 전달받은 값을 쓰기
        }

        public select()
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

                var Command = new SqlCommand(); // MSDB 에서 사용할 QUERRY 문 , 프로시저 를 나타내는 CLASS

                Command.Connection = DBConn;

                Command.CommandType = CommandType.StoredProcedure;

                //저장프로시저명

                Command.CommandText = "dbo.USP_tj_list_S1";

                Command.Parameters.AddWithValue("@tj_cd", "");

                Command.Parameters.AddWithValue("@tj_nm", "");

                dgv_Search.ReadOnly = false;

                var da_search_dgv = new SqlDataAdapter(Command);
                var ds_search_dgv = new DataSet();

                da_search_dgv.Fill(ds_search_dgv, "dgv_search");
                dgv_Search.DataSource = ds_search_dgv;

                dgv_Search.DataMember = "dgv_search";

                Command.ExecuteNonQuery();

                //DB 닫기

                DBConn.Close();

            }

            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }
        }
        private void Btn_select_degree_click(object sender, EventArgs e)
        {
            Passvalue =  TB.Text;   //Form2로 데이터를 보냄
            Passvalue2 = TB2.Text;  //Form2로 데이터를 보냄
            this.Hide();          // 검색폼 닫기

        }
        private void dgv_search_RowEnters(object sender, DataGridViewCellEventArgs e)
        {
            TB.Text = dgv_Search.Rows[e.RowIndex].Cells["tj_cd"].Value.ToString();   //선택한 셀의 cide 를 TB에저장
            TB2.Text = dgv_Search.Rows[e.RowIndex].Cells["tj_nm"].Value.ToString();  // 선택한 셀의 name 을 TB2에 저장
        }

        private void barogo(object sender, DataGridViewCellEventArgs e)
        {
            TB.Text = dgv_Search.Rows[e.RowIndex].Cells["tj_cd"].Value.ToString();   //선택한 셀의 cide 를 TB에저장
            TB2.Text = dgv_Search.Rows[e.RowIndex].Cells["tj_nm"].Value.ToString();  // 선택한 셀의 name 을 TB2에 저장

            Passvalue = TB.Text;   //Form2로 데이터를 보냄
            Passvalue2 = TB2.Text;  //Form2로 데이터를 보냄
            this.Hide();          // 검색폼 닫기
        }
    }
}
