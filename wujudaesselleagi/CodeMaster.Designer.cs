
namespace wujudaesselleagi
{
    partial class CodeMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeMaster));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save_item = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Add_item = new System.Windows.Forms.Button();
            this.select_litem = new System.Windows.Forms.Button();
            this.Delete_item = new System.Windows.Forms.Button();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.major_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major_basic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Search2 = new System.Windows.Forms.DataGridView();
            this.minor_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major_cds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minor_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minor_basic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(248, 133);
            this.panel9.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.Save_item);
            this.panel1.Controls.Add(this.Save_button);
            this.panel1.Controls.Add(this.Add_item);
            this.panel1.Controls.Add(this.select_litem);
            this.panel1.Controls.Add(this.Delete_item);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1709, 131);
            this.panel1.TabIndex = 36;
            // 
            // Save_item
            // 
            this.Save_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Save_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save_item.Location = new System.Drawing.Point(358, 9);
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
            this.Add_item.Location = new System.Drawing.Point(529, 9);
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
            this.select_litem.Location = new System.Drawing.Point(277, 9);
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
            this.Delete_item.Location = new System.Drawing.Point(439, 9);
            this.Delete_item.Name = "Delete_item";
            this.Delete_item.Size = new System.Drawing.Size(75, 23);
            this.Delete_item.TabIndex = 3;
            this.Delete_item.Text = "삭제";
            this.Delete_item.UseVisualStyleBackColor = false;
            this.Delete_item.Click += new System.EventHandler(this.btn_delete_eve);
            // 
            // dgv_Search
            // 
            this.dgv_Search.AllowUserToAddRows = false;
            this.dgv_Search.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgv_Search.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_Search.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.major_cd,
            this.major_nm,
            this.major_basic});
            this.dgv_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_Search.EnableHeadersVisualStyles = false;
            this.dgv_Search.Location = new System.Drawing.Point(0, 131);
            this.dgv_Search.Name = "dgv_Search";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Search.RowHeadersWidth = 40;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgv_Search.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Search.RowTemplate.Height = 23;
            this.dgv_Search.Size = new System.Drawing.Size(734, 849);
            this.dgv_Search.TabIndex = 37;
            this.dgv_Search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_data_catch);
            this.dgv_Search.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select_dgv1);
            // 
            // major_cd
            // 
            this.major_cd.DataPropertyName = "major_cd";
            this.major_cd.FillWeight = 81.34752F;
            this.major_cd.HeaderText = "주코드";
            this.major_cd.MinimumWidth = 8;
            this.major_cd.Name = "major_cd";
            // 
            // major_nm
            // 
            this.major_nm.DataPropertyName = "major_nm";
            this.major_nm.FillWeight = 81.34752F;
            this.major_nm.HeaderText = "코드명";
            this.major_nm.MinimumWidth = 8;
            this.major_nm.Name = "major_nm";
            this.major_nm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // major_basic
            // 
            this.major_basic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.major_basic.DataPropertyName = "major_basic";
            this.major_basic.HeaderText = "기본어명";
            this.major_basic.MinimumWidth = 8;
            this.major_basic.Name = "major_basic";
            this.major_basic.Width = 150;
            // 
            // dgv_Search2
            // 
            this.dgv_Search2.AllowUserToAddRows = false;
            this.dgv_Search2.AllowUserToOrderColumns = true;
            this.dgv_Search2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_Search2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Search2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.minor_cd,
            this.major_cds,
            this.minor_nm,
            this.minor_basic});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Search2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Search2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_Search2.EnableHeadersVisualStyles = false;
            this.dgv_Search2.Location = new System.Drawing.Point(731, 131);
            this.dgv_Search2.Name = "dgv_Search2";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Search2.RowHeadersWidth = 40;
            this.dgv_Search2.RowTemplate.Height = 23;
            this.dgv_Search2.Size = new System.Drawing.Size(978, 849);
            this.dgv_Search2.TabIndex = 38;
            // 
            // minor_cd
            // 
            this.minor_cd.DataPropertyName = "minor_cd";
            this.minor_cd.FillWeight = 81.34752F;
            this.minor_cd.HeaderText = "부코드";
            this.minor_cd.MinimumWidth = 8;
            this.minor_cd.Name = "minor_cd";
            // 
            // major_cds
            // 
            this.major_cds.HeaderText = "주코드";
            this.major_cds.Name = "major_cds";
            this.major_cds.Visible = false;
            // 
            // minor_nm
            // 
            this.minor_nm.DataPropertyName = "minor_nm";
            this.minor_nm.FillWeight = 81.34752F;
            this.minor_nm.HeaderText = "코드명";
            this.minor_nm.MinimumWidth = 8;
            this.minor_nm.Name = "minor_nm";
            this.minor_nm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // minor_basic
            // 
            this.minor_basic.DataPropertyName = "major_basic";
            this.minor_basic.FillWeight = 35F;
            this.minor_basic.HeaderText = "기본어명";
            this.minor_basic.MinimumWidth = 10;
            this.minor_basic.Name = "minor_basic";
            this.minor_basic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CodeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1709, 980);
            this.Controls.Add(this.dgv_Search2);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeMaster";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "CodeMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save_item;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Add_item;
        private System.Windows.Forms.Button select_litem;
        private System.Windows.Forms.Button Delete_item;
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.DataGridView dgv_Search2;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_basic;
        private System.Windows.Forms.DataGridViewTextBoxColumn minor_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_cds;
        private System.Windows.Forms.DataGridViewTextBoxColumn minor_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn minor_basic;
    }
}