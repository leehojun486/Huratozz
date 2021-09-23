
namespace wujudaesselleagi
{
    partial class TJ_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TJ_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save_item = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Add_item = new System.Windows.Forms.Button();
            this.select_litem = new System.Windows.Forms.Button();
            this.Delete_item = new System.Windows.Forms.Button();
            this.Update_item = new System.Windows.Forms.Button();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.tj_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tj_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tj_leader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tj_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
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
            this.panel1.Controls.Add(this.Update_item);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1470, 151);
            this.panel1.TabIndex = 36;
            // 
            // Save_item
            // 
            this.Save_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Save_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save_item.Location = new System.Drawing.Point(512, 9);
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
            this.Add_item.Location = new System.Drawing.Point(593, 9);
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
            this.select_litem.Location = new System.Drawing.Point(269, 9);
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
            this.Delete_item.Location = new System.Drawing.Point(431, 9);
            this.Delete_item.Name = "Delete_item";
            this.Delete_item.Size = new System.Drawing.Size(75, 23);
            this.Delete_item.TabIndex = 3;
            this.Delete_item.Text = "삭제";
            this.Delete_item.UseVisualStyleBackColor = false;
            this.Delete_item.Click += new System.EventHandler(this.btn_click_delete);
            // 
            // Update_item
            // 
            this.Update_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Update_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update_item.Location = new System.Drawing.Point(350, 9);
            this.Update_item.Name = "Update_item";
            this.Update_item.Size = new System.Drawing.Size(75, 23);
            this.Update_item.TabIndex = 2;
            this.Update_item.Text = "수정";
            this.Update_item.UseVisualStyleBackColor = false;
            this.Update_item.Click += new System.EventHandler(this.btn_update_click);
            // 
            // dgv_Search
            // 
            this.dgv_Search.AllowUserToAddRows = false;
            this.dgv_Search.AllowUserToOrderColumns = true;
            this.dgv_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_Search.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tj_cd,
            this.tj_nm,
            this.tj_leader,
            this.tj_address});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Search.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Search.EnableHeadersVisualStyles = false;
            this.dgv_Search.Location = new System.Drawing.Point(0, 151);
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
            this.dgv_Search.RowTemplate.Height = 23;
            this.dgv_Search.Size = new System.Drawing.Size(1470, 582);
            this.dgv_Search.TabIndex = 37;
            // 
            // tj_cd
            // 
            this.tj_cd.DataPropertyName = "tj_cd";
            this.tj_cd.HeaderText = "거래처코드";
            this.tj_cd.MinimumWidth = 8;
            this.tj_cd.Name = "tj_cd";
            // 
            // tj_nm
            // 
            this.tj_nm.DataPropertyName = "tj_nm";
            this.tj_nm.HeaderText = "거래처이름";
            this.tj_nm.MinimumWidth = 8;
            this.tj_nm.Name = "tj_nm";
            // 
            // tj_leader
            // 
            this.tj_leader.DataPropertyName = "tj_leader";
            this.tj_leader.HeaderText = "대표자명";
            this.tj_leader.MinimumWidth = 8;
            this.tj_leader.Name = "tj_leader";
            // 
            // tj_address
            // 
            this.tj_address.DataPropertyName = "tj_address";
            this.tj_address.HeaderText = "주소";
            this.tj_address.MinimumWidth = 8;
            this.tj_address.Name = "tj_address";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(256, 151);
            this.panel9.TabIndex = 38;
            // 
            // TJ_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1470, 733);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TJ_Form";
            this.Text = "거래처정보";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save_item;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Add_item;
        private System.Windows.Forms.Button select_litem;
        private System.Windows.Forms.Button Delete_item;
        private System.Windows.Forms.Button Update_item;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn tj_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tj_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn tj_leader;
        private System.Windows.Forms.DataGridViewTextBoxColumn tj_address;
    }
}