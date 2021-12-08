
namespace wujudaesselleagi
{
    partial class select_valju
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
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label = new Infragistics.Win.Misc.UltraLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.order_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tj_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_tj_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ol_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ol_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ol_price_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Search
            // 
            this.dgv_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_no,
            this.order_date,
            this.tj_cd,
            this.order_tj_nm,
            this.item_cd,
            this.item_nm,
            this.ol_cnt,
            this.ol_price,
            this.ol_price_cnt});
            this.dgv_Search.Location = new System.Drawing.Point(3, 38);
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.RowHeadersWidth = 123;
            this.dgv_Search.RowTemplate.Height = 23;
            this.dgv_Search.Size = new System.Drawing.Size(916, 422);
            this.dgv_Search.TabIndex = 6;
            this.dgv_Search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_RowEnters);
            this.dgv_Search.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barogo);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "조회";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_select_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "선택";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_select_degree_click);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(3, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 20);
            this.label.TabIndex = 8;
            this.label.Text = "발주현황";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 12;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(237, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 13;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(346, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 14;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(25, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 15;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(131, 124);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 16;
            this.textBox6.Visible = false;
            // 
            // order_no
            // 
            this.order_no.DataPropertyName = "order_no";
            this.order_no.HeaderText = "발주번호";
            this.order_no.MinimumWidth = 15;
            this.order_no.Name = "order_no";
            // 
            // order_date
            // 
            this.order_date.DataPropertyName = "order_date";
            this.order_date.HeaderText = "발주날짜";
            this.order_date.MinimumWidth = 15;
            this.order_date.Name = "order_date";
            // 
            // tj_cd
            // 
            this.tj_cd.DataPropertyName = "tj_cd";
            this.tj_cd.HeaderText = "거래처코드";
            this.tj_cd.MinimumWidth = 15;
            this.tj_cd.Name = "tj_cd";
            // 
            // order_tj_nm
            // 
            this.order_tj_nm.DataPropertyName = "order_tj_nm";
            this.order_tj_nm.HeaderText = "거래처명";
            this.order_tj_nm.Name = "order_tj_nm";
            // 
            // item_cd
            // 
            this.item_cd.DataPropertyName = "item_cd";
            this.item_cd.HeaderText = "품목코드";
            this.item_cd.MinimumWidth = 15;
            this.item_cd.Name = "item_cd";
            // 
            // item_nm
            // 
            this.item_nm.DataPropertyName = "item_nm";
            this.item_nm.HeaderText = "품목명";
            this.item_nm.MinimumWidth = 15;
            this.item_nm.Name = "item_nm";
            // 
            // ol_cnt
            // 
            this.ol_cnt.DataPropertyName = "ol_cnt";
            this.ol_cnt.HeaderText = "주문수량";
            this.ol_cnt.MinimumWidth = 15;
            this.ol_cnt.Name = "ol_cnt";
            // 
            // ol_price
            // 
            this.ol_price.DataPropertyName = "ol_price";
            this.ol_price.HeaderText = "단가";
            this.ol_price.Name = "ol_price";
            // 
            // ol_price_cnt
            // 
            this.ol_price_cnt.DataPropertyName = "ol_price_cnt";
            this.ol_price_cnt.HeaderText = "합계";
            this.ol_price_cnt.Name = "ol_price_cnt";
            // 
            // select_valju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 547);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dgv_Search);
            this.Name = "select_valju";
            this.Text = "select_valju";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Infragistics.Win.Misc.UltraLabel label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn tj_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_tj_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ol_cnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ol_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ol_price_cnt;
    }
}