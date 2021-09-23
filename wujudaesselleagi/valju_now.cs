using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wujudaesselleagi
{
    public partial class valju_now : Form
    {
        public valju_now()
        {
            InitializeComponent();
        }

        private void valju_now_Load(object sender, EventArgs e)
        {

        }

        private void select_val_now(object sender, EventArgs e)
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

            Command.CommandText = "dbo.USP_order_list_now_S1";

            Command.Parameters.AddWithValue("@order_no", "");


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

        private void csv_save(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\aeter\Desktop\Wording\새폴더\발주현황.csv", false, Encoding.GetEncoding("UTF-8"));

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
    }
}
