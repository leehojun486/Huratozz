
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

    public partial class Item_form : Form
    {
        public Item_form()
        {
            InitializeComponent();
            // dgv_Search.rows[0].Cells[0] = DataGridViewButtonCell();
            Application.Idle += LoadEven_use;
            // dgv_Search.rows[0].Cells[0] = DataGridViewButtonCell();
            Application.Idle += LoadEven_cf;
            Application.Idle += LoadEven_og;


        }

        string[] cd_value1;
        string[] nm_value1;
        string[] og_value1;
        string[] cf_value1;
        string[] salses_value1;
        string[] use_value1;

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



                        MessageBox.Show("데이터가 조회됐습니다.", "Information");



                        Command.ExecuteNonQuery();

                        //DB 닫기

                        DBConn.Close();
                        dgv_Search.AllowUserToAddRows = false;
                        dgv_Search.Columns["item_cd1"].ReadOnly = true;

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

                    Command.CommandText = "dbo.USP_item_list_S1";

                    Command.Parameters.AddWithValue("@item_cd", "");

                    Command.Parameters.AddWithValue("@item_nm", "");

                    dgv_Search.ReadOnly = false;

                    var daSearch = new SqlDataAdapter(Command);


                    var dsSearch = new DataSet();


                    //DataSEt에 Customers 테이블 만들고 그 테이블에 데이터를 저장

                    daSearch.Fill(dsSearch);


                    dgv_Search.DataSource = dsSearch.Tables[0];

                    DataTable dt = (DataTable)(dgv_Search.DataSource);


                    //DataSet 내부의 테이블 이름



                    MessageBox.Show("데이터가 조회됐습니다.", "Information");



                    Command.ExecuteNonQuery();
                    Console.WriteLine(Command.ExecuteNonQuery());
                    //DB 닫기

                    DBConn.Close();
                    dgv_Search.AllowUserToAddRows = false;
                    dgv_Search.Columns["item_cd1"].ReadOnly = true;
                }


            }

            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }
        }

        private string AddModiDel(DataTable dt)
        {
            int delCnt = 0;
            int AddCnt = 0;
            int ModiCnt = 0;

            DataTable dtDel = dt.GetChanges(DataRowState.Deleted);
            DataTable dtAdd = dt.GetChanges(DataRowState.Added);
            DataTable dtModi = dt.GetChanges(DataRowState.Modified);

            if (dtDel != null)
            {
                foreach (DataRow dr in dtDel.Rows)
                {
                    if (dr.RowState == DataRowState.Deleted)
                    {
                        // 삭제되기 전 값
                        var boforeValue = dr[0, DataRowVersion.Original];

                        // 여기에 Delete Query 를 써도 됨.
                        // 나 같은 경우는 id값을 가져와 삭제를 했음.
                        delCnt += 1;
                    }
                }
            }
            else if (dtAdd != null)
            {
                foreach (DataRow dr in dtAdd.Rows)
                {
                    if (dr.RowState == DataRowState.Added)
                    {
                        // 추가 된 행 
                        var AddValue = dr[0, DataRowVersion.Current];
                        AddCnt += 1;
                    }
                }
            }
            else if (dtModi != null)
            {
                foreach (DataRow dr in dtAdd.Rows)
                {
                    if (dr.RowState == DataRowState.Modified)
                    {
                        // 추가 된 행 
                        var ModiValue = dr[0, DataRowVersion.Current];
                        ModiCnt += 1;
                    }
                }
            }
            dt.AcceptChanges();
            string cmt = string.Format("추가 된 행은 {0}건 \n삭제 된 행은 {1}건 \n수정 된 행은 {2}건 \n\n", AddCnt, delCnt, ModiCnt);
            return cmt == "" ? "결과 없음" : cmt;
        }
      

        private void btn_add_click(object sender, EventArgs e)
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


                //저장프로시저 사용

                // SqlCommand Command = new SqlCommand(); // MSDB 에서 사용할 QUERRY 문 , 프로시저 를 나타내는 CLASS

                //  Command.Connection = DBConn;

                // Command.CommandType = CommandType.StoredProcedure;






                
                   if (dgv_Search.AllowUserToAddRows == true)
                  {
                      //저장프로시저명

                      Command.CommandText = "dbo.usp_item_list_I1"; // 가져올 프로시져



                      // 프로시저 에 저장 되어 있는 Parmater 가 받을 데이터 입력.
                      Command.Parameters.AddWithValue("@item_cd", dgv_Search.CurrentRow.Cells["item_cd1"].Value);

                      Command.Parameters.AddWithValue("@item_nm", dgv_Search.CurrentRow.Cells["item_nm1"].Value);

                      Command.Parameters.AddWithValue("@item_cf", dgv_Search.CurrentRow.Cells["item_cf1"].Value);

                      Command.Parameters.AddWithValue("@item_og", dgv_Search.CurrentRow.Cells["item_og1"].Value);

                      Command.Parameters.AddWithValue("@item_sales", dgv_Search.CurrentRow.Cells["item_sales1"].Value);

                      Command.Parameters.AddWithValue("@item_use", dgv_Search.CurrentRow.Cells["item_use1"].Value);







                      if (string.IsNullOrWhiteSpace(dgv_Search.CurrentRow.Cells["item_cd1"].Value.ToString()))
                      {
                          MessageBox.Show("품목 번호는 입력해라 인간 적으로", "Information");


                      }
                      else if (string.IsNullOrWhiteSpace(dgv_Search.CurrentRow.Cells["item_nm1"].Value.ToString()))
                      {
                          MessageBox.Show("품목명은  입력해라 인간 적으로", "Information");

                      }
                      else if (string.IsNullOrWhiteSpace(dgv_Search.CurrentRow.Cells["item_og1"].Value.ToString()))
                      {
                          MessageBox.Show("원산지 입력 안하면 불법이다", "Information");


                      }
                      else
                      {
                          Command.ExecuteNonQuery();

                          MessageBox.Show("데이터가 저장됐습니다.", "Information");
                          dgv_Search.AllowUserToAddRows = false;
                          dgv_Search.Columns["item_cd1"].ReadOnly = true;

                      }
                  }

                  else if(dgv_Search.AllowUserToAddRows == false)
                  {
                      Command.CommandText = "dbo.usp_item_list_U1";

                      Command.Parameters.AddWithValue("@item_cd", (dgv_Search.CurrentRow.Cells["item_cd1"].Value));

                      Command.Parameters.AddWithValue("@item_nm", dgv_Search.CurrentRow.Cells["item_nm1"].Value);

                      Command.Parameters.AddWithValue("@item_cf", dgv_Search.CurrentRow.Cells["item_cf1"].Value);

                      Command.Parameters.AddWithValue("@item_og", dgv_Search.CurrentRow.Cells["item_og1"].Value);

                      Command.Parameters.AddWithValue("@item_sales", dgv_Search.CurrentRow.Cells["item_sales1"].Value);

                      Command.Parameters.AddWithValue("@item_use", dgv_Search.CurrentRow.Cells["item_use1"].Value);





                      MessageBox.Show("수정에 성공 했습니다.", "Information");
                      Command.ExecuteNonQuery();
                      Console.WriteLine(Command.ExecuteNonQuery());
                      dgv_Search.AllowUserToAddRows = false;
                      dgv_Search.Columns["item_cd1"].ReadOnly = true;






                      //DB 닫기

                      DBConn.Close();


                  }
              }

              catch (SqlException ex)

              {

                  MessageBox.Show(ex.Message);

              }

          }    

              
             


        // 업데이트 버튼 이벤트

     /*   private void btn_update_click(object sender, EventArgs e)
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

                    Command.CommandText = "dbo.usp_item_list_U1";

                    Command.Parameters.AddWithValue("@item_cd", dgv_Search.CurrentRow.Cells["item_cd1"].Value);

                    Command.Parameters.AddWithValue("@item_nm", dgv_Search.CurrentRow.Cells["item_nm1"].Value);

                    Command.Parameters.AddWithValue("@item_cf", dgv_Search.CurrentRow.Cells["item_cf1"].Value);

                    Command.Parameters.AddWithValue("@item_og", dgv_Search.CurrentRow.Cells["item_og1"].Value);

                    Command.Parameters.AddWithValue("@item_sales", dgv_Search.CurrentRow.Cells["item_sales1"].Value);

                    Command.Parameters.AddWithValue("@item_use", dgv_Search.CurrentRow.Cells["item_use1"].Value);



              

                        MessageBox.Show("수정에 성공 했습니다.", "Information");
                        Command.ExecuteNonQuery();
                dgv_Search.AllowUserToAddRows = false;





                //DB 닫기

                DBConn.Close();

                
            }
            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }
        } */

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

                    Command.CommandText = "dbo.usp_item_list_D1";


                    Command.Parameters.AddWithValue("@item_CD", dgv_Search.CurrentRow.Cells["item_cd1"].Value);




                    //삭제 처리 성공여부 체크
                   

                        Command.ExecuteNonQuery();
                        MessageBox.Show("삭제에 성공 했습니다.", "Information");
                dgv_Search.AllowUserToAddRows = false;
                dgv_Search.Columns["item_cd1"].ReadOnly = true;

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
            StreamWriter writer = new StreamWriter(@"C:\Users\aeter\Desktop\Wording\새폴더\test.csv", false, Encoding.GetEncoding("UTF-8"));

            for(int i =0; i < dgv_Search.Columns.Count; i ++)
            {
                writer.Write(dgv_Search.Columns[i].HeaderText);
                if(i!= dgv_Search.Columns.Count)
                {
                    writer.Write(",");
                }
            
            }
            writer.Write(writer.NewLine);
            foreach (DataGridViewRow dr in dgv_Search.Rows)
            {
                for(int i =0; i < dgv_Search.Columns.Count; i++)
                {
                    writer.Write(dr.Cells[i].Value);
                    if(i != dgv_Search.Columns.Count)
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
            dgv_Search.Columns["item_cd1"].ReadOnly = false;
        }

        private void LoadEven_use(object sender,EventArgs e)
        {
            
            SqlConnection DBconn = new SqlConnection("Server = DESKTOP-CPJQVAP\\LEEHJ; database = Hurato; uid =sa; pwd = 1234 ");
            DBconn.Open();
            SqlCommand comand = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            da.TableMappings.Add("Table", "minor_cms");

            comand.Connection = DBconn;

            comand.CommandType = CommandType.StoredProcedure;

            comand.CommandText = "dbo.usp_codemaster_S2";
            comand.Parameters.AddWithValue("@major_cd", "AD1");

            da.SelectCommand = comand;

            da.SelectCommand.ExecuteNonQuery();

            da.Fill(ds);

            item_use1.DataSource = ds.DefaultViewManager;

            item_use1.DisplayMember = "minor_cms.minor_nm";

            item_use1.ValueMember = "minor_cms.minor_cd";

            DBconn.Close();
        }

        private void LoadEven_cf(object sender, EventArgs e)
        {

            SqlConnection DBconn = new SqlConnection("Server = DESKTOP-CPJQVAP\\LEEHJ; database = Hurato; uid =sa; pwd = 1234 ");
            DBconn.Open();
            SqlCommand comand = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            da.TableMappings.Add("Table", "minor_cms");

            comand.Connection = DBconn;

            comand.CommandType = CommandType.StoredProcedure;

            comand.CommandText = "dbo.usp_codemaster_S2";
            comand.Parameters.AddWithValue("@major_cd", "AD2");

            da.SelectCommand = comand;

            da.SelectCommand.ExecuteNonQuery();

            da.Fill(ds);

            item_cf1.DataSource = ds.DefaultViewManager;

            item_cf1.DisplayMember = "minor_cms.minor_nm";

            item_cf1.ValueMember = "minor_cms.minor_cd";

            DBconn.Close();
        }

        private void LoadEven_og(object sender, EventArgs e)
        {

            SqlConnection DBconn = new SqlConnection("Server = DESKTOP-CPJQVAP\\LEEHJ; database = Hurato; uid =sa; pwd = 1234 ");
            DBconn.Open();
            SqlCommand comand = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            da.TableMappings.Add("Table", "minor_cms");

            comand.Connection = DBconn;

            comand.CommandType = CommandType.StoredProcedure;

            comand.CommandText = "dbo.usp_codemaster_S2";
            comand.Parameters.AddWithValue("@major_cd", "AD3");

            da.SelectCommand = comand;

            da.SelectCommand.ExecuteNonQuery();

            da.Fill(ds);

            item_og1.DataSource = ds.DefaultViewManager;

            item_og1.DisplayMember = "minor_cms.minor_nm";

            item_og1.ValueMember = "minor_cms.minor_cd";

            DBconn.Close();
        }

        private void Btn_Exm(object sender, EventArgs e)
        {


            try

            {
                SqlConnection DBConn = new SqlConnection();

                DBConn.ConnectionString = "Server = DESKTOP-CPJQVAP\\LEEHJ; database = Hurato; uid =sa; pwd = 1234 ";

                DBConn.Open();

                SqlCommand Command = new SqlCommand();

                Command.Connection = DBConn;

                Command.CommandType = CommandType.StoredProcedure;


                if (dgv_Search.AllowUserToAddRows == true)
                {
                    for(int i=0; i <  2; i ++) { 
                   
                    //저장프로시저명

                    Command.CommandText = "dbo.usp_item_list_I1"; // 가져올 프로시져



                    // 프로시저 에 저장 되어 있는 Parmater 가 받을 데이터 입력.
                    Command.Parameters.AddWithValue("@item_cd",this.cd_value1[i]);

                    Command.Parameters.AddWithValue("@item_nm", this.nm_value1[i]);

                    Command.Parameters.AddWithValue("@item_cf", this.cf_value1[i]);

                    Command.Parameters.AddWithValue("@item_og", this.og_value1[i]);

                    Command.Parameters.AddWithValue("@item_sales", this.salses_value1[i]);

                    Command.Parameters.AddWithValue("@item_use",   this.use_value1[i]);





                    Command.ExecuteNonQuery();

                    MessageBox.Show("데이터가 저장됐습니다.", "Information");
                    dgv_Search.AllowUserToAddRows = false;
                    dgv_Search.Columns["item_cd1"].ReadOnly = true;
                    }


                }
            }

            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }
          }

        private void CellEditEnd(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("item_cd1", typeof(String));
            dt.Columns.Add("item_nm1", typeof(String));
            dt.Columns.Add("item_og1", typeof(String));
            dt.Columns.Add("item_cf1", typeof(String));
            dt.Columns.Add("item_sales1", typeof(String));
            dt.Columns.Add("item_use1", typeof(String));

            dt.Rows.Add(dgv_Search.CurrentRow.Cells["item_cd1"].Value.ToString(),
                        dgv_Search.CurrentRow.Cells["item_nm1"].Value.ToString(),
                        dgv_Search.CurrentRow.Cells["item_og1"].Value.ToString(),
                        dgv_Search.CurrentRow.Cells["item_cf1"].Value.ToString(),
                        dgv_Search.CurrentRow.Cells["item_sales1"].Value.ToString(),
                        dgv_Search.CurrentRow.Cells["item_use1"].Value.ToString()

                );








            for (int i = 0; i < dt.Rows.Count; i++) {
                string cd_value = dt.Rows[i]["item_cd1"].ToString();
                string nm_value = dt.Rows[i]["item_nm1"].ToString();
                string og_value = dt.Rows[i]["item_og1"].ToString();
                string cf_value = dt.Rows[i]["item_cf1"].ToString();
                string salses_value = dt.Rows[i]["item_sales1"].ToString();
                string use_value = dt.Rows[i]["item_use1"].ToString();



                
            }
            



           
  
        }
    }
}
