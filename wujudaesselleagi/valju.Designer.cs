
using System.Windows.Forms;

namespace wujudaesselleagi
{
    partial class valju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(valju));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save_item = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Add_item = new System.Windows.Forms.Button();
            this.select_litem = new System.Windows.Forms.Button();
            this.Delete_item = new System.Windows.Forms.Button();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.order_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tjcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select_bt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.order_tj_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgv_Search2 = new System.Windows.Forms.DataGridView();
            this.item_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ol_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ol_price_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ol_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.Save_item);
            this.panel1.Controls.Add(this.Save_button);
            this.panel1.Controls.Add(this.Add_item);
            this.panel1.Controls.Add(this.select_litem);
            this.panel1.Controls.Add(this.Delete_item);
            this.panel1.Location = new System.Drawing.Point(255, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 131);
            this.panel1.TabIndex = 33;
            // 
            // Save_item
            // 
            this.Save_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Save_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save_item.Location = new System.Drawing.Point(91, 9);
            this.Save_item.Name = "Save_item";
            this.Save_item.Size = new System.Drawing.Size(75, 23);
            this.Save_item.TabIndex = 6;
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
            this.Add_item.Location = new System.Drawing.Point(262, 9);
            this.Add_item.Name = "Add_item";
            this.Add_item.Size = new System.Drawing.Size(75, 23);
            this.Add_item.TabIndex = 4;
            this.Add_item.Text = "추가";
            this.Add_item.UseVisualStyleBackColor = false;
            this.Add_item.Click += new System.EventHandler(this.Add_item_Click);
            // 
            // select_litem
            // 
            this.select_litem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.select_litem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.select_litem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.select_litem.Location = new System.Drawing.Point(10, 9);
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
            this.Delete_item.Location = new System.Drawing.Point(172, 9);
            this.Delete_item.Name = "Delete_item";
            this.Delete_item.Size = new System.Drawing.Size(75, 23);
            this.Delete_item.TabIndex = 3;
            this.Delete_item.Text = "삭제";
            this.Delete_item.UseVisualStyleBackColor = false;
            // 
            // dgv_Search
            // 
            this.dgv_Search.AllowUserToAddRows = false;
            this.dgv_Search.AllowUserToOrderColumns = true;
            this.dgv_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_Search.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_no,
            this.order_date,
            this.tjcd,
            this.select_bt,
            this.order_tj_nm});
            this.dgv_Search.Location = new System.Drawing.Point(2, 137);
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.RowHeadersWidth = 123;
            this.dgv_Search.RowTemplate.Height = 23;
            this.dgv_Search.Size = new System.Drawing.Size(1493, 293);
            this.dgv_Search.TabIndex = 35;
            this.dgv_Search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_data_catch);
            this.dgv_Search.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHelloWorld_CellContentClick);
            // 
            // order_no
            // 
            this.order_no.DataPropertyName = "order_no";
            this.order_no.FillWeight = 81.34752F;
            this.order_no.HeaderText = "발주번호";
            this.order_no.MinimumWidth = 8;
            this.order_no.Name = "order_no";
            // 
            // order_date
            // 
            this.order_date.DataPropertyName = "order_date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.order_date.DefaultCellStyle = dataGridViewCellStyle1;
            this.order_date.FillWeight = 81.34752F;
            this.order_date.HeaderText = "발주날짜";
            this.order_date.MinimumWidth = 8;
            this.order_date.Name = "order_date";
            // 
            // tjcd
            // 
            this.tjcd.DataPropertyName = "tj_cd";
            this.tjcd.FillWeight = 81.34752F;
            this.tjcd.HeaderText = "거래처코드";
            this.tjcd.MinimumWidth = 8;
            this.tjcd.Name = "tjcd";
            this.tjcd.ReadOnly = true;
            this.tjcd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // select_bt
            // 
            this.select_bt.FillWeight = 10F;
            this.select_bt.HeaderText = "검색";
            this.select_bt.MinimumWidth = 10;
            this.select_bt.Name = "select_bt";
            this.select_bt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select_bt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.select_bt.Text = "검색";
            // 
            // order_tj_nm
            // 
            this.order_tj_nm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.order_tj_nm.DataPropertyName = "order_tj_nm";
            this.order_tj_nm.HeaderText = "거래처명";
            this.order_tj_nm.MinimumWidth = 8;
            this.order_tj_nm.Name = "order_tj_nm";
            this.order_tj_nm.ReadOnly = true;
            this.order_tj_nm.Width = 150;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(2, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(247, 131);
            this.panel9.TabIndex = 34;
            // 
            // dgv_Search2
            // 
            this.dgv_Search2.AllowUserToAddRows = false;
            this.dgv_Search2.AllowUserToOrderColumns = true;
            this.dgv_Search2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Search2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_Search2.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Search2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_cd,
            this.item_nm,
            this.ol_cnt,
            this.ol_price_cnt,
            this.ol_price});
            this.dgv_Search2.Location = new System.Drawing.Point(-7, 436);
            this.dgv_Search2.Name = "dgv_Search2";
            this.dgv_Search2.RowHeadersWidth = 123;
            this.dgv_Search2.RowTemplate.Height = 23;
            this.dgv_Search2.Size = new System.Drawing.Size(1493, 285);
            this.dgv_Search2.TabIndex = 36;
            // 
            // item_cd
            // 
            this.item_cd.DataPropertyName = "item_cd";
            this.item_cd.FillWeight = 81.34752F;
            this.item_cd.HeaderText = "품목코드";
            this.item_cd.MinimumWidth = 8;
            this.item_cd.Name = "item_cd";
            // 
            // item_nm
            // 
            this.item_nm.DataPropertyName = "item_nm";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.item_nm.DefaultCellStyle = dataGridViewCellStyle2;
            this.item_nm.FillWeight = 81.34752F;
            this.item_nm.HeaderText = "품목이름";
            this.item_nm.MinimumWidth = 8;
            this.item_nm.Name = "item_nm";
            // 
            // ol_cnt
            // 
            this.ol_cnt.DataPropertyName = "ol_cnt";
            this.ol_cnt.FillWeight = 81.34752F;
            this.ol_cnt.HeaderText = "주문갯수";
            this.ol_cnt.MinimumWidth = 8;
            this.ol_cnt.Name = "ol_cnt";
            this.ol_cnt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ol_price_cnt
            // 
            this.ol_price_cnt.DataPropertyName = "ol_price_cnt";
            this.ol_price_cnt.FillWeight = 10F;
            this.ol_price_cnt.HeaderText = "단가";
            this.ol_price_cnt.MinimumWidth = 10;
            this.ol_price_cnt.Name = "ol_price_cnt";
            this.ol_price_cnt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ol_price
            // 
            this.ol_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ol_price.DataPropertyName = "ol_price";
            this.ol_price.HeaderText = "주문금액";
            this.ol_price.MinimumWidth = 8;
            this.ol_price.Name = "ol_price";
            this.ol_price.Width = 150;
            // 
            // valju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1487, 733);
            this.Controls.Add(this.dgv_Search2);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "valju";
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
        private DataGridViewTextBoxColumn order_no;
        private DataGridViewTextBoxColumn order_date;
        private DataGridViewTextBoxColumn tjcd;
        private DataGridViewButtonColumn select_bt;
        private DataGridViewTextBoxColumn order_tj_nm;
        private DataGridView dgv_Search2;
        private DataGridViewTextBoxColumn item_cd;
        private DataGridViewTextBoxColumn item_nm;
        private DataGridViewTextBoxColumn ol_cnt;
        private DataGridViewTextBoxColumn ol_price_cnt;
        private DataGridViewTextBoxColumn ol_price;
    }
}