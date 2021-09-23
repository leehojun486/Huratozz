
namespace wujudaesselleagi
{
    partial class valju_now
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(valju_now));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.select_litem = new System.Windows.Forms.Button();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.order_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tjcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_tj_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ol_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ol_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ol_price_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csv_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(0, -5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(250, 136);
            this.panel9.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.csv_button);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.select_litem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1928, 131);
            this.panel1.TabIndex = 36;
            // 
            // select_litem
            // 
            this.select_litem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.select_litem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.select_litem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.select_litem.Location = new System.Drawing.Point(256, 3);
            this.select_litem.Name = "select_litem";
            this.select_litem.Size = new System.Drawing.Size(75, 23);
            this.select_litem.TabIndex = 0;
            this.select_litem.Text = "조회";
            this.select_litem.UseVisualStyleBackColor = false;
            this.select_litem.Click += new System.EventHandler(this.select_val_now);
            // 
            // dgv_Search
            // 
            this.dgv_Search.AllowUserToAddRows = false;
            this.dgv_Search.AllowUserToOrderColumns = true;
            this.dgv_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_Search.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_no,
            this.order_date,
            this.tjcd,
            this.order_tj_nm,
            this.item_cd,
            this.item_nm,
            this.ol_cnt,
            this.ol_price,
            this.ol_price_cnt});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Search.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Search.EnableHeadersVisualStyles = false;
            this.dgv_Search.Location = new System.Drawing.Point(0, 131);
            this.dgv_Search.Name = "dgv_Search";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_Search.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgv_Search.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_Search.RowTemplate.Height = 23;
            this.dgv_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Search.Size = new System.Drawing.Size(1928, 969);
            this.dgv_Search.TabIndex = 37;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle13.Format = "D";
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.order_date.DefaultCellStyle = dataGridViewCellStyle13;
            this.order_date.FillWeight = 81.34752F;
            this.order_date.HeaderText = "발주날짜";
            this.order_date.MinimumWidth = 8;
            this.order_date.Name = "order_date";
            this.order_date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // order_tj_nm
            // 
            this.order_tj_nm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.order_tj_nm.DataPropertyName = "order_tj_nm";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.order_tj_nm.DefaultCellStyle = dataGridViewCellStyle14;
            this.order_tj_nm.HeaderText = "거래처명";
            this.order_tj_nm.MinimumWidth = 8;
            this.order_tj_nm.Name = "order_tj_nm";
            this.order_tj_nm.ReadOnly = true;
            this.order_tj_nm.Width = 150;
            // 
            // item_cd
            // 
            this.item_cd.DataPropertyName = "item_cd";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.item_cd.DefaultCellStyle = dataGridViewCellStyle15;
            this.item_cd.HeaderText = "품목코드";
            this.item_cd.Name = "item_cd";
            // 
            // item_nm
            // 
            this.item_nm.DataPropertyName = "item_nm";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.item_nm.DefaultCellStyle = dataGridViewCellStyle16;
            this.item_nm.HeaderText = "품목명";
            this.item_nm.Name = "item_nm";
            // 
            // ol_cnt
            // 
            this.ol_cnt.DataPropertyName = "ol_cnt";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = null;
            this.ol_cnt.DefaultCellStyle = dataGridViewCellStyle17;
            this.ol_cnt.HeaderText = "주문갯수";
            this.ol_cnt.Name = "ol_cnt";
            // 
            // ol_price
            // 
            this.ol_price.DataPropertyName = "ol_price";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "C0";
            dataGridViewCellStyle18.NullValue = null;
            this.ol_price.DefaultCellStyle = dataGridViewCellStyle18;
            this.ol_price.HeaderText = "단가";
            this.ol_price.Name = "ol_price";
            // 
            // ol_price_cnt
            // 
            this.ol_price_cnt.DataPropertyName = "ol_price_cnt";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "C0";
            dataGridViewCellStyle19.NullValue = null;
            this.ol_price_cnt.DefaultCellStyle = dataGridViewCellStyle19;
            this.ol_price_cnt.HeaderText = "주문금액";
            this.ol_price_cnt.Name = "ol_price_cnt";
            // 
            // csv_button
            // 
            this.csv_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.csv_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.csv_button.Location = new System.Drawing.Point(256, 32);
            this.csv_button.Name = "csv_button";
            this.csv_button.Size = new System.Drawing.Size(75, 32);
            this.csv_button.TabIndex = 36;
            this.csv_button.Text = "CSV추출";
            this.csv_button.UseVisualStyleBackColor = false;
            this.csv_button.Click += new System.EventHandler(this.csv_save);
            // 
            // valju_now
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1928, 1100);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "valju_now";
            this.Text = "valju_now";
            this.Load += new System.EventHandler(this.valju_now_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button select_litem;
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn tjcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_tj_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ol_cnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ol_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ol_price_cnt;
        private System.Windows.Forms.Button csv_button;
    }
}