
using System.Windows.Forms;

namespace wujudaesselleagi
{
    partial class Class1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save_item = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Add_item = new System.Windows.Forms.Button();
            this.select_litem = new System.Windows.Forms.Button();
            this.Delete_item = new System.Windows.Forms.Button();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.dgv_Search2 = new System.Windows.Forms.DataGridView();
            this.order_sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select_item = new System.Windows.Forms.DataGridViewButtonColumn();
            this.item_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ol_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ol_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ol_price_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt1 = new System.Windows.Forms.Button();
            this.order_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tjcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select_bt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.order_tj_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.Save_item);
            this.panel1.Controls.Add(this.Save_button);
            this.panel1.Controls.Add(this.Add_item);
            this.panel1.Controls.Add(this.select_litem);
            this.panel1.Controls.Add(this.Delete_item);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 131);
            this.panel1.TabIndex = 1;
            // 
            // Save_item
            // 
            this.Save_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Save_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save_item.Location = new System.Drawing.Point(337, 12);
            this.Save_item.Name = "Save_item";
            this.Save_item.Size = new System.Drawing.Size(75, 23);
            this.Save_item.TabIndex = 1;
            this.Save_item.Text = "저장";
            this.Save_item.UseVisualStyleBackColor = false;
            this.Save_item.Click += new System.EventHandler(this.btn_add_click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(1325, 9);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 5;
            this.Save_button.Text = "CSV저장";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // Add_item
            // 
            this.Add_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Add_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_item.Location = new System.Drawing.Point(508, 12);
            this.Add_item.Name = "Add_item";
            this.Add_item.Size = new System.Drawing.Size(75, 23);
            this.Add_item.TabIndex = 3;
            this.Add_item.Text = "추가";
            this.Add_item.UseVisualStyleBackColor = false;
            this.Add_item.Click += new System.EventHandler(this.Add_item_Click);
            // 
            // select_litem
            // 
            this.select_litem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.select_litem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.select_litem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.select_litem.Location = new System.Drawing.Point(256, 12);
            this.select_litem.Name = "select_litem";
            this.select_litem.Size = new System.Drawing.Size(75, 23);
            this.select_litem.TabIndex = 0;
            this.select_litem.Text = "조회";
            this.select_litem.UseVisualStyleBackColor = false;
            this.select_litem.Click += new System.EventHandler(this.btn_select_click);
            // 
            // Delete_item
            // 
            this.Delete_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Delete_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_item.Location = new System.Drawing.Point(418, 12);
            this.Delete_item.Name = "Delete_item";
            this.Delete_item.Size = new System.Drawing.Size(75, 23);
            this.Delete_item.TabIndex = 2;
            this.Delete_item.Text = "삭제";
            this.Delete_item.UseVisualStyleBackColor = false;
            this.Delete_item.Click += new System.EventHandler(this.btn_delete_eve);
            // 
            // dgv_Search
            // 
            this.dgv_Search.AllowUserToAddRows = false;
            this.dgv_Search.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_Search.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_Search.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_no,
            this.order_date,
            this.tjcd,
            this.select_bt,
            this.order_tj_nm});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Search.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Search.EnableHeadersVisualStyles = false;
            this.dgv_Search.Location = new System.Drawing.Point(0, 131);
            this.dgv_Search.Name = "dgv_Search";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Search.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgv_Search.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Search.RowTemplate.Height = 23;
            this.dgv_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Search.Size = new System.Drawing.Size(1385, 885);
            this.dgv_Search.TabIndex = 2;
            this.dgv_Search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_data_catch);
            this.dgv_Search.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHelloWorld_CellContentClick);
            this.dgv_Search.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select_dgv1);
            // 
            // dgv_Search2
            // 
            this.dgv_Search2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgv_Search2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Search2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_Search2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Search2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_sno,
            this.item_cd,
            this.Select_item,
            this.item_nm,
            this.ol_cnt,
            this.ol_price,
            this.ol_price_cnt});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Search2.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_Search2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Search2.EnableHeadersVisualStyles = false;
            this.dgv_Search2.Location = new System.Drawing.Point(0, 475);
            this.dgv_Search2.Name = "dgv_Search2";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search2.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_Search2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgv_Search2.RowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_Search2.RowTemplate.Height = 23;
            this.dgv_Search2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Search2.Size = new System.Drawing.Size(1385, 541);
            this.dgv_Search2.TabIndex = 4;
            this.dgv_Search2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_select_form);
            this.dgv_Search2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_Search2_KeyUp);
            // 
            // order_sno
            // 
            this.order_sno.DataPropertyName = "order_sno";
            this.order_sno.FillWeight = 10F;
            this.order_sno.HeaderText = "순번";
            this.order_sno.MinimumWidth = 10;
            this.order_sno.Name = "order_sno";
            // 
            // item_cd
            // 
            this.item_cd.DataPropertyName = "item_cd";
            this.item_cd.FillWeight = 40.19687F;
            this.item_cd.HeaderText = "품목코드";
            this.item_cd.MinimumWidth = 8;
            this.item_cd.Name = "item_cd";
            this.item_cd.ReadOnly = true;
            // 
            // Select_item
            // 
            this.Select_item.FillWeight = 10F;
            this.Select_item.HeaderText = "검색";
            this.Select_item.MinimumWidth = 10;
            this.Select_item.Name = "Select_item";
            this.Select_item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select_item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select_item.Text = "검색";
            // 
            // item_nm
            // 
            this.item_nm.DataPropertyName = "item_nm";
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.item_nm.DefaultCellStyle = dataGridViewCellStyle13;
            this.item_nm.FillWeight = 40.19687F;
            this.item_nm.HeaderText = "품목이름";
            this.item_nm.MinimumWidth = 8;
            this.item_nm.Name = "item_nm";
            this.item_nm.ReadOnly = true;
            // 
            // ol_cnt
            // 
            this.ol_cnt.DataPropertyName = "ol_cnt";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "C0";
            dataGridViewCellStyle14.NullValue = null;
            this.ol_cnt.DefaultCellStyle = dataGridViewCellStyle14;
            this.ol_cnt.FillWeight = 40.19687F;
            this.ol_cnt.HeaderText = "주문갯수";
            this.ol_cnt.MinimumWidth = 8;
            this.ol_cnt.Name = "ol_cnt";
            this.ol_cnt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ol_price
            // 
            this.ol_price.DataPropertyName = "ol_price";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "C0";
            dataGridViewCellStyle15.NullValue = null;
            this.ol_price.DefaultCellStyle = dataGridViewCellStyle15;
            this.ol_price.FillWeight = 30F;
            this.ol_price.HeaderText = "단가";
            this.ol_price.MinimumWidth = 10;
            this.ol_price.Name = "ol_price";
            this.ol_price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ol_price_cnt
            // 
            this.ol_price_cnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ol_price_cnt.DataPropertyName = "ol_price_cnt";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "C0";
            dataGridViewCellStyle16.NullValue = null;
            this.ol_price_cnt.DefaultCellStyle = dataGridViewCellStyle16;
            this.ol_price_cnt.FillWeight = 70F;
            this.ol_price_cnt.HeaderText = "주문금액";
            this.ol_price_cnt.MinimumWidth = 8;
            this.ol_price_cnt.Name = "ol_price_cnt";
            this.ol_price_cnt.ReadOnly = true;
            this.ol_price_cnt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ol_price_cnt.Width = 150;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(247, 131);
            this.panel9.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 983);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Visible = false;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(218, 983);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 35;
            this.bt1.Text = "button1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Visible = false;
            // 
            // order_no
            // 
            this.order_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.order_no.DataPropertyName = "order_no";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.order_no.DefaultCellStyle = dataGridViewCellStyle3;
            this.order_no.FillWeight = 50F;
            this.order_no.HeaderText = "발주번호";
            this.order_no.MaxInputLength = 50;
            this.order_no.MinimumWidth = 8;
            this.order_no.Name = "order_no";
            // 
            // order_date
            // 
            this.order_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.order_date.DataPropertyName = "order_date";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.order_date.DefaultCellStyle = dataGridViewCellStyle4;
            this.order_date.FillWeight = 68.77412F;
            this.order_date.HeaderText = "발주날짜";
            this.order_date.MinimumWidth = 8;
            this.order_date.Name = "order_date";
            this.order_date.ReadOnly = true;
            this.order_date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tjcd
            // 
            this.tjcd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tjcd.DataPropertyName = "tj_cd";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tjcd.DefaultCellStyle = dataGridViewCellStyle5;
            this.tjcd.FillWeight = 68.77412F;
            this.tjcd.HeaderText = "거래처코드";
            this.tjcd.MinimumWidth = 8;
            this.tjcd.Name = "tjcd";
            this.tjcd.ReadOnly = true;
            this.tjcd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // select_bt
            // 
            this.select_bt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.select_bt.DefaultCellStyle = dataGridViewCellStyle6;
            this.select_bt.FillWeight = 30.6032F;
            this.select_bt.HeaderText = "검색";
            this.select_bt.MinimumWidth = 10;
            this.select_bt.Name = "select_bt";
            this.select_bt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select_bt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.select_bt.Text = "검색";
            // 
            // order_tj_nm
            // 
            this.order_tj_nm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.order_tj_nm.DataPropertyName = "order_tj_nm";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.order_tj_nm.DefaultCellStyle = dataGridViewCellStyle7;
            this.order_tj_nm.FillWeight = 84.5436F;
            this.order_tj_nm.HeaderText = "거래처명";
            this.order_tj_nm.MinimumWidth = 8;
            this.order_tj_nm.Name = "order_tj_nm";
            this.order_tj_nm.ReadOnly = true;
            // 
            // Class1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1385, 1016);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgv_Search2);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Class1";
            this.Text = "발주";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save_item;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Add_item;
        private System.Windows.Forms.Button select_litem;
        private System.Windows.Forms.Button Delete_item;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgv_Search;
        private DataGridView dgv_Search2;
        private DataGridViewTextBoxColumn order_sno;
        private DataGridViewTextBoxColumn item_cd;
        private DataGridViewButtonColumn Select_item;
        private DataGridViewTextBoxColumn item_nm;
        private DataGridViewTextBoxColumn ol_cnt;
        private DataGridViewTextBoxColumn ol_price;
        private DataGridViewTextBoxColumn ol_price_cnt;
        private DateTimePicker dateTimePicker1;
        private Button bt1;
        private DataGridViewTextBoxColumn order_no;
        private DataGridViewTextBoxColumn order_date;
        private DataGridViewTextBoxColumn tjcd;
        private DataGridViewButtonColumn select_bt;
        private DataGridViewTextBoxColumn order_tj_nm;
    }
}