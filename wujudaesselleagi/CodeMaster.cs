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
    public partial class CodeMaster : Form
    {
        public CodeMaster()
        {
            InitializeComponent();
        }
        string celldatasave;

        private void btn_select_click(object sender, EventArgs e)
        {

            try

            {



                if (dgv_Search.AllowUserToAddRows == true)
                {
                    if (MessageBox.Show("작업중이던 파일이 있습니다 계속하시겠습니까?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

                        Command.CommandText = "dbo.USP_codemaster_S1";

                        Command.Parameters.AddWithValue("@major_cd", "");
                        Command.Parameters.AddWithValue("@major_nm", "");
                        Command.Parameters.AddWithValue("@major_basic", "");
                       



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
                        dgv_Search.Columns["major_cd"].ReadOnly = true;






                    }

                }
                else
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

                    Command.CommandText = "dbo.USP_codemaster_S1";

                    Command.Parameters.AddWithValue("@major_cd", "");
                    Command.Parameters.AddWithValue("@major_nm", "");
                    Command.Parameters.AddWithValue("@major_basic", "");

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
                    dgv_Search.Columns["major_cd"].ReadOnly = true;
                }


            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }
        }
        private void Add_item_Click(object sender, EventArgs e)
        {


            if (dgv_Search2.CurrentCell == null)
            {
                dgv_Search.AllowUserToAddRows = true;
                dgv_Search.Columns["major_cd"].ReadOnly = false;
            }

            else if (dgv_Search2.CurrentCell != null)
            {

                dgv_Search2.AllowUserToAddRows = true;


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

                if (dgv_Search.SelectedRows.Count == -1)
                {
                    return;
                }


                else
                {

                    if (this.celldatasave == null)
                    {

                        if (dgv_Search2.CurrentCell == null)
                        {
                            if (dgv_Search.AllowUserToAddRows == true)
                            {    //저장프로시저명

                                Command.CommandText = "dbo.USP_codemaster_I1";

                                Command.Parameters.AddWithValue("@major_cd", dgv_Search.CurrentRow.Cells["major_cd"].Value);

                                Command.Parameters.AddWithValue("@major_nm", dgv_Search.CurrentRow.Cells["major_nm"].Value);

                                Command.Parameters.AddWithValue("@major_basic", dgv_Search.CurrentRow.Cells["major_basic"].Value);




                                Command.ExecuteNonQuery();
                                DBConn.Close();

                                dgv_Search.AllowUserToAddRows = false;
                                dgv_Search.Columns["major_cd"].ReadOnly = true;


                            }

                            else if (dgv_Search.AllowUserToAddRows == false)
                            {

                               
                                Command.CommandText = "dbo.USP_codemaster_U1";

                                Command.Parameters.AddWithValue("@major_cd", dgv_Search.CurrentRow.Cells["major_cd"].Value);

                                Command.Parameters.AddWithValue("@major_nm", dgv_Search.CurrentRow.Cells["major_nm"].Value);

                                Command.Parameters.AddWithValue("@major_basic", dgv_Search.CurrentRow.Cells["major_basic"].Value);





                                Command.ExecuteNonQuery();
                                dgv_Search.AllowUserToAddRows = false;
                                dgv_Search.Columns["major_cd"].ReadOnly = true;
                            }
                        }


                        if (dgv_Search2.CurrentCell != null)
                        {
                            if (dgv_Search2.AllowUserToAddRows == true)
                            {

                                Command.CommandText = "dbo.USP_codemaster_I2";

                                Command.Parameters.AddWithValue("@major_cd", dgv_Search.CurrentRow.Cells["major_cd"].Value);

                                Command.Parameters.AddWithValue("@minor_cd", dgv_Search2.CurrentRow.Cells["minor_cd"].Value);

                                Command.Parameters.AddWithValue("@minor_nm", dgv_Search2.CurrentRow.Cells["minor_nm"].Value);

                                Command.ExecuteNonQuery();
                                DBConn.Close();
                                dgv_Search.AllowUserToAddRows = false;
                                dgv_Search.Columns["major_Cd"].ReadOnly = true;
                            }

                            if (dgv_Search2.AllowUserToAddRows == false)
                            {
                                Command.CommandText = "dbo.USP_codemaster_u2";

                                Command.Parameters.AddWithValue("@ajor_cd", dgv_Search.CurrentRow.Cells["major_cd"].Value);

                                Command.Parameters.AddWithValue("@minor_cd", dgv_Search2.CurrentRow.Cells["minor_cd"].Value);

                                Command.Parameters.AddWithValue("@minor_nm", dgv_Search2.CurrentRow.Cells["minor_nm"].Value);

                                Command.ExecuteNonQuery();
                                DBConn.Close();
                                dgv_Search.AllowUserToAddRows = false;
                                dgv_Search.Columns["major_cd"].ReadOnly = true;
                            }
                        }
                    }

                    if (this.celldatasave != null)
                    {
                        if (dgv_Search2.CurrentCell == null)
                        {

                            Command.CommandText = "dbo.usp_codemaster_D1";


                            Command.Parameters.AddWithValue("@major_cd", this.celldatasave);




                            Command.ExecuteNonQuery();
                            dgv_Search.AllowUserToAddRows = false;

                            this.celldatasave = null;


                        }

                        if (dgv_Search2.CurrentCell != null)
                        {

                            Command.CommandText = "dbo.usp_codemaster_D2";


                            Command.Parameters.AddWithValue("@major_cd", dgv_Search.CurrentRow.Cells["major_cd"].Value);
                            Command.Parameters.AddWithValue("@minor_cd", dgv_Search2.CurrentRow.Cells["minor_cd"].Value);






                            Command.ExecuteNonQuery();
                            dgv_Search.AllowUserToAddRows = false;


                            this.celldatasave = null;
                        }
                    }
                    DBConn.Close();


                    var DBConn2 = new SqlConnection();

                    //DB 연결 변수

                    DBConn2.ConnectionString = "Server = DESKTOP-CPJQVAP\\LEEHJ; database = Hurato; uid =sa; pwd = 1234 ";

                    //DB 열기

                    DBConn2.Open();

                    //저장프로시저 사용

                    var Command2 = new SqlCommand();

                    Command2.Connection = DBConn2;

                    var commandSearch2 = new SqlCommand();

                    commandSearch2.Connection = DBConn2;


                    Command2.CommandType = CommandType.StoredProcedure;

                    //저장프로시저명

                    Command2.CommandText = "dbo.USP_codemaster_S1";

                    Command2.Parameters.AddWithValue("@major_cd", "");
                    Command2.Parameters.AddWithValue("@major_nm", "");
                    Command2.Parameters.AddWithValue("@major_basic", "");
               


                    dgv_Search.ReadOnly = false;

                    var daSearch2 = new SqlDataAdapter(Command2);


                    var dsSearch2 = new DataSet();


                    //DataSEt에 Customers 테이블 만들고 그 테이블에 데이터를 저장

                    daSearch2.Fill(dsSearch2);


                    dgv_Search.DataSource = dsSearch2.Tables[0];




                    //DataSet 내부의 테이블 이름




                    Command2.ExecuteNonQuery();



                    //DB 닫기

                    DBConn2.Close();


                    dgv_Search.AllowUserToAddRows = false;
                    dgv_Search.Columns["major_cd"].ReadOnly = true;




                }
            }


            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }

        }


        private void Click_data_catch(object sender, DataGridViewCellEventArgs e)  // 첫번째 그리드 Cell 에서 basic_no(사원번호) 기준으로 두번째 그리드 데이터 조회
        {
            try
            {


                SqlConnection DBConn = new SqlConnection();

                //DB 연결 변수

                DBConn.ConnectionString = "Server = DESKTOP-CPJQVAP\\LEEHJ; database = Hurato; uid =sa; pwd = 1234 ";

                //DB 열기

                DBConn.Open();

                SqlCommand Command2 = new SqlCommand();

                Command2.Connection = DBConn;

                SqlCommand commandSearch2 = new SqlCommand();

                commandSearch2.Connection = DBConn;




                Command2.CommandType = CommandType.StoredProcedure;

                //저장프로시저명

                Command2.CommandText = "dbo.USP_codemaster_S2";


                Command2.Parameters.AddWithValue("@major_cd", dgv_Search.CurrentRow.Cells["major_cd"].Value);



                dgv_Search2.ReadOnly = false;

                SqlDataAdapter daSearch2 = new SqlDataAdapter(Command2);

                DataSet dsSearch2 = new DataSet();

                //DataSEt에 Customers 테이블 만들고 그 테이블에 데이터를 저장

                daSearch2.Fill(dsSearch2, "dgv_Search2");

                dgv_Search2.DataSource = dsSearch2;

                //DataSet 내부의 테이블 이름

                dgv_Search2.DataMember = "dgv_Search2";

                Command2.ExecuteNonQuery();

                if ((dgv_Search2.CurrentCell != null))
                {
                    dgv_Search2.AllowUserToAddRows = false;
                }
                else if ((dgv_Search2.CurrentCell == null))
                {
                    dgv_Search2.AllowUserToAddRows = true;
                }



                //DB 닫기

                DBConn.Close();



            }




            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }
        }

        private void select_dgv1(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_Search2.CurrentCell = null;
        }

        private void btn_delete_eve(object sender, EventArgs e)
        {
            if (dgv_Search.SelectedRows.Count < 0)
            {
                return;
            }
            else
            {
                this.celldatasave = dgv_Search.CurrentRow.Cells["major_cd"].Value.ToString();
            }

        }



    }
}
