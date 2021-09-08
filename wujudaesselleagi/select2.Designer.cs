
namespace wujudaesselleagi
{
    partial class select2
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.label = new Infragistics.Win.Misc.UltraLabel();
            this.item_cd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_nm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_cf1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_og1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_sales1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_use1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "조회";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_select_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "선택";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_select_degree_click);
            // 
            // dgv_Search
            // 
            this.dgv_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_cd1,
            this.item_nm1,
            this.item_cf1,
            this.item_og1,
            this.item_sales1,
            this.item_use1});
            this.dgv_Search.Location = new System.Drawing.Point(1, 46);
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.RowTemplate.Height = 23;
            this.dgv_Search.Size = new System.Drawing.Size(513, 422);
            this.dgv_Search.TabIndex = 5;
            this.dgv_Search.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_RowEnters);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(12, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 33);
            this.label.TabIndex = 4;
            this.label.Text = "품목검색";
            // 
            // item_cd1
            // 
            this.item_cd1.DataPropertyName = "item_cd1";
            this.item_cd1.HeaderText = "폼목코드";
            this.item_cd1.Name = "item_cd1";
            // 
            // item_nm1
            // 
            this.item_nm1.DataPropertyName = "item_nm1";
            this.item_nm1.HeaderText = "품목명";
            this.item_nm1.Name = "item_nm1";
            // 
            // item_cf1
            // 
            this.item_cf1.DataPropertyName = "item_cf1";
            this.item_cf1.HeaderText = "품목구분";
            this.item_cf1.Name = "item_cf1";
            // 
            // item_og1
            // 
            this.item_og1.DataPropertyName = "item_og1";
            this.item_og1.HeaderText = "원산지";
            this.item_og1.Name = "item_og1";
            // 
            // item_sales1
            // 
            this.item_sales1.DataPropertyName = "item_sales1";
            this.item_sales1.HeaderText = "가격";
            this.item_sales1.Name = "item_sales1";
            // 
            // item_use1
            // 
            this.item_use1.DataPropertyName = "item_use1";
            this.item_use1.HeaderText = "사용여부";
            this.item_use1.Name = "item_use1";
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(705, 302);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(100, 21);
            this.TB.TabIndex = 8;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(705, 346);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(100, 21);
            this.TB2.TabIndex = 9;
            // 
            // select2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 551);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.label);
            this.Name = "select2";
            this.Text = "select2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_Search;
        private Infragistics.Win.Misc.UltraLabel label;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_cd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_nm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_cf1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_og1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_sales1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_use1;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.TextBox TB2;
    }
}