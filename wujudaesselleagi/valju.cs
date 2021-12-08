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
using System.Windows.Input;

namespace wujudaesselleagi
{
    public partial class Class1 : Form
    {
        string celldatasave;
       


        public Class1()
        {
          

            InitializeComponent();
        }
       


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




                        Command.ExecuteNonQuery();



                        //DB 닫기

                        DBConn.Close();


                        dgv_Search.AllowUserToAddRows = false;
                        dgv_Search.Columns["order_no"].ReadOnly = true;


                      

             

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



                    Command.ExecuteNonQuery();

                    //DB 닫기

                    DBConn.Close();
                    dgv_Search.AllowUserToAddRows = false;
                    dgv_Search.Columns["order_no"].ReadOnly = true;
                }


            }

            catch (Exception ex)

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

                if (dgv_Search.SelectedRows.Count == 0)
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

                                Command.CommandText = "dbo.USP_order_I1";

                                Command.Parameters.AddWithValue("@order_no", dgv_Search.CurrentRow.Cells["order_no"].Value);

                                Command.Parameters.AddWithValue("@order_date", dgv_Search.CurrentRow.Cells["order_date"].Value);

                                Command.Parameters.AddWithValue("@order_tj_nm", dgv_Search.CurrentRow.Cells["order_tj_nm"].Value);

                                Command.Parameters.AddWithValue("@tj_cd", dgv_Search.CurrentRow.Cells["tjcd"].Value);




                                Command.ExecuteNonQuery();
                                DBConn.Close();
                                dgv_Search.AllowUserToAddRows = false;
                                dgv_Search.Columns["order_no"].ReadOnly = true;


                            }

                            else if (dgv_Search.AllowUserToAddRows == false)
                            {

                                Command.CommandText = "dbo.USP_order_U1";

                                Command.Parameters.AddWithValue("@order_no", dgv_Search.CurrentRow.Cells["order_no"].Value);

                                Command.Parameters.AddWithValue("@order_date", dgv_Search.CurrentRow.Cells["order_date"].Value);

                                Command.Parameters.AddWithValue("@order_tj_nm", dgv_Search.CurrentRow.Cells["order_tj_nm"].Value);

                                Command.Parameters.AddWithValue("@tj_cd", dgv_Search.CurrentRow.Cells["tjcd"].Value);





                                Command.ExecuteNonQuery();
                                dgv_Search.AllowUserToAddRows = false;
                                dgv_Search.Columns["order_no"].ReadOnly = true;
                            }
                        }


                        if (dgv_Search2.CurrentCell != null)
                        {
                            if (dgv_Search2.AllowUserToAddRows == true)
                            {

                                Command.CommandText = "dbo.USP_order_list_I2";

                                Command.Parameters.AddWithValue("@order_no", dgv_Search.CurrentRow.Cells["order_no"].Value);

                                Command.Parameters.AddWithValue("@order_sno", dgv_Search2.CurrentRow.Cells["order_sno"].Value);

                                Command.Parameters.AddWithValue("@item_cd", dgv_Search2.CurrentRow.Cells["item_cd"].Value);

                                Command.Parameters.AddWithValue("@ol_cnt", dgv_Search2.CurrentRow.Cells["ol_cnt"].Value);

                                Command.Parameters.AddWithValue("@ol_price_cnt", dgv_Search2.CurrentRow.Cells["ol_price_cnt"].Value);

                                Command.Parameters.AddWithValue("@ol_price", dgv_Search2.CurrentRow.Cells["ol_price"].Value);

                                Command.ExecuteNonQuery();
                                DBConn.Close();
                                dgv_Search.AllowUserToAddRows = false;
                                dgv_Search.Columns["order_no"].ReadOnly = true;
                            }

                            if (dgv_Search2.AllowUserToAddRows == false)
                            {
                                Command.CommandText = "dbo.USP_order_list_U2";

                                Command.Parameters.AddWithValue("@order_no", dgv_Search.CurrentRow.Cells["order_no"].Value);

                                Command.Parameters.AddWithValue("@order_sno", dgv_Search2.CurrentRow.Cells["order_sno"].Value);

                                Command.Parameters.AddWithValue("@item_cd", dgv_Search2.CurrentRow.Cells["item_cd"].Value);

                                Command.Parameters.AddWithValue("@ol_cnt", dgv_Search2.CurrentRow.Cells["ol_cnt"].Value);

                                Command.Parameters.AddWithValue("@ol_price_cnt", dgv_Search2.CurrentRow.Cells["ol_price_cnt"].Value);

                                Command.Parameters.AddWithValue("@ol_price", dgv_Search2.CurrentRow.Cells["ol_price"].Value);

                                Command.ExecuteNonQuery();
                                DBConn.Close();
                                dgv_Search.AllowUserToAddRows = false;
                                dgv_Search.Columns["order_no"].ReadOnly = true;
                            }
                        }
                    }

                    if (this.celldatasave != null)
                    {
                        if (dgv_Search2.CurrentCell == null)
                        {

                            Command.CommandText = "dbo.usp_order_D1";


                            Command.Parameters.AddWithValue("@order_no", this.celldatasave);




                            Command.ExecuteNonQuery();
                            dgv_Search.AllowUserToAddRows = false;

                            this.celldatasave = null;


                        }

                        if (dgv_Search2.CurrentCell != null)
                        {

                            Command.CommandText = "dbo.usp_order_list_D2";


                            Command.Parameters.AddWithValue("@order_no", dgv_Search.CurrentRow.Cells["order_no"].Value);
                            Command.Parameters.AddWithValue("@order_sno", dgv_Search2.CurrentRow.Cells["order_sno"].Value);






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

                    Command2.CommandText = "dbo.USP_order_S1";

                    Command2.Parameters.AddWithValue("@order_no", "");
                    Command2.Parameters.AddWithValue("@order_date", "");
                    Command2.Parameters.AddWithValue("@order_tj_nm", "");
                    Command2.Parameters.AddWithValue("@tj_cd", "");



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
                    dgv_Search.Columns["order_no"].ReadOnly = true;




                }
            }


            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }

        }




        private void Add_item_Click(object sender, EventArgs e)
        { 
            

            if (dgv_Search2.CurrentCell == null)
            {
                dgv_Search.AllowUserToAddRows = true;
                dgv_Search.Columns["order_no"].ReadOnly = false;
            }

            else if (dgv_Search2.CurrentCell != null)
            {

               dgv_Search2.AllowUserToAddRows = true;
              

            }
          



        }
        /*   private void Btn_search_code_click(object sender, EventArgs e)   //학사 검색 폼을 여는 이벤트
           {
               var select = new select();
               select.ShowDialog();  //검색폼 출력

               // 선택한 데이터 Text에 저장
               dgv_Search.CurrentRow.Cells["tj_cd"].Value = select.Passvalue;
               dgv_Search.CurrentRow.Cells["order_tj_nm"].Value = select.Passvalue2;

           }*/
        private void DgvHelloWorld_CellContentClick(object sender, DataGridViewCellEventArgs ea)
        {
            var grid = (DataGridView)sender;

            if (ea.RowIndex < 0)
            {
                return;
            }

            if (grid[ea.ColumnIndex, ea.RowIndex] is DataGridViewButtonCell)
            {
                var clickHandler = dgv_Search.Columns[ea.ColumnIndex].Tag;
                var person = dgv_Search.Rows[ea.RowIndex].DataBoundItem;
                if (ea.RowIndex == 1)
                {

                    var select = new select();
                    select.ShowDialog();  

                    dgv_Search.CurrentRow.Cells["tjcd"].Value = select.Passvalue;
                    dgv_Search.CurrentRow.Cells["order_tj_nm"].Value = select.Passvalue2;
                }
            }

     

        }

        private void dgv2_select_form(object sender, DataGridViewCellEventArgs ea)
        {
            var grid = (DataGridView)sender;

            if (ea.RowIndex < 0)
            {
          
                return;
            }


            if (grid[ea.ColumnIndex, ea.RowIndex] is DataGridViewButtonCell)
            {
                var clickHandler = dgv_Search2.Columns[ea.ColumnIndex].Tag;
                var person = dgv_Search2.Rows[ea.RowIndex].DataBoundItem;

                var select = new select2();
                select.ShowDialog(); 

                dgv_Search2.CurrentRow.Cells["item_cd"].Value = select.Passvalue;
                dgv_Search2.CurrentRow.Cells["item_nm"].Value = select.Passvalue2;


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

                Command2.CommandText = "dbo.USP_order_list_S2";


                Command2.Parameters.AddWithValue("@order_no", dgv_Search.CurrentRow.Cells["order_no"].Value);



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
                dateTimePicker1.Visible = false;


                //DB 닫기

                DBConn.Close();
                if (e.ColumnIndex == 2)
                {

                    dateTimePicker1 = new DateTimePicker();

                    dgv_Search.Controls.Add(dateTimePicker1);

                    dateTimePicker1.Format = DateTimePickerFormat.Short;

                    Rectangle rectangle1 = dgv_Search.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    dateTimePicker1.Size = new Size(rectangle1.Width, rectangle1.Height);

                    dateTimePicker1.Location = new Point(rectangle1.X, rectangle1.Y);

                    dateTimePicker1.CloseUp += new EventHandler(datepicker_closeup);

                    dateTimePicker1.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                    dateTimePicker1.Visible = true;

                }

                var grid = (DataGridView)sender;

                if (e.RowIndex < 0)
                {
                    return;
                }

                if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
                {
                    var clickHandler = dgv_Search.Columns[e.ColumnIndex].Tag;
                    var person = dgv_Search.Rows[e.RowIndex].DataBoundItem;
                    if (e.RowIndex >= 0)
                    {

                        var select = new select();
                        select.ShowDialog();

                        dgv_Search.CurrentRow.Cells["tjcd"].Value = select.Passvalue;
                        dgv_Search.CurrentRow.Cells["order_tj_nm"].Value = select.Passvalue2;
                    }
                }
            }





            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message);

            }
        }

        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            dgv_Search.CurrentRow.Cells["order_date"].Value = dateTimePicker1.Text.ToString();

        }

        void datepicker_closeup(object sender, EventArgs e) {
            dateTimePicker1.Visible = false;
            dgv_Search2.CurrentCell = null;

        }



        private void select_dgv1(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_Search2.CurrentCell = null;
        }


        private void btn_delete_eve(object sender, EventArgs e)
        {
            if (dgv_Search.SelectedRows.Count == 0)
            {
                return;
            }
            else { 
                this.celldatasave = dgv_Search.CurrentRow.Cells["order_no"].Value.ToString();
            }

        }


        private void dgv_Search2_KeyUp(object sender, KeyEventArgs e)
        {  try { 
            if (dgv_Search2.CurrentRow.Cells["ol_price"].Value.ToString() != "")
            {
                string price = dgv_Search2.CurrentRow.Cells["ol_price"].Value.ToString();
                string cnt = dgv_Search2.CurrentRow.Cells["ol_cnt"].Value.ToString();
                dgv_Search2.CurrentRow.Cells["ol_price_cnt"].Value = Int32.Parse(cnt) * Int32.Parse(price);
            }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        }
    }

