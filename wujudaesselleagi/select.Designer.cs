
namespace wujudaesselleagi
{
    partial class select
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
            this.label = new Infragistics.Win.Misc.UltraLabel();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.tj_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tj_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tj_leader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tj_addres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(23, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 33);
            this.label.TabIndex = 0;
            this.label.Text = "거래처 검색";
            // 
            // dgv_Search
            // 
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tj_cd,
            this.tj_nm,
            this.tj_leader,
            this.tj_addres});
            this.dgv_Search.Location = new System.Drawing.Point(12, 60);
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.RowTemplate.Height = 23;
            this.dgv_Search.Size = new System.Drawing.Size(443, 413);
            this.dgv_Search.TabIndex = 1;
            this.dgv_Search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_RowEnters);
            // 
            // tj_cd
            // 
            this.tj_cd.DataPropertyName = "tj_cd";
            this.tj_cd.HeaderText = "거래처코드";
            this.tj_cd.Name = "tj_cd";
            // 
            // tj_nm
            // 
            this.tj_nm.DataPropertyName = "tj_nm";
            this.tj_nm.HeaderText = "거래처명";
            this.tj_nm.Name = "tj_nm";
            // 
            // tj_leader
            // 
            this.tj_leader.DataPropertyName = "tj_leader";
            this.tj_leader.HeaderText = "대표자명";
            this.tj_leader.Name = "tj_leader";
            // 
            // tj_addres
            // 
            this.tj_addres.DataPropertyName = "tj_addres";
            this.tj_addres.HeaderText = "주소";
            this.tj_addres.Name = "tj_addres";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "선택";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_select_degree_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "조회";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_select_click);
            // 
            // TB2
            // 
            this.TB2.BackColor = System.Drawing.Color.LightGray;
            this.TB2.ForeColor = System.Drawing.Color.Gray;
            this.TB2.Location = new System.Drawing.Point(612, 628);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(101, 21);
            this.TB2.TabIndex = 4;
            // 
            // TB
            // 
            this.TB.BackColor = System.Drawing.Color.LightGray;
            this.TB.ForeColor = System.Drawing.Color.Gray;
            this.TB.Location = new System.Drawing.Point(642, 601);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(71, 21);
            this.TB.TabIndex = 5;
            // 
            // select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 555);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.label);
            this.Name = "select";
            this.Text = "select";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel label;
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn tj_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tj_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn tj_leader;
        private System.Windows.Forms.DataGridViewTextBoxColumn tj_addres;
    }
}