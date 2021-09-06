
namespace wujudaesselleagi
{
    partial class Item_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_form));
            this.select_litem = new System.Windows.Forms.Button();
            this.Delete_item = new System.Windows.Forms.Button();
            this.Add_item = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save_item = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.item_cd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_nm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_cf1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_og1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_sales1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_use1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // select_litem
            // 
            this.select_litem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.select_litem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.select_litem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.select_litem.Location = new System.Drawing.Point(14, 14);
            this.select_litem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.select_litem.Name = "select_litem";
            this.select_litem.Size = new System.Drawing.Size(107, 34);
            this.select_litem.TabIndex = 0;
            this.select_litem.Text = "조회";
            this.select_litem.UseVisualStyleBackColor = false;
            this.select_litem.Click += new System.EventHandler(this.btn_select_click);
            // 
            // Delete_item
            // 
            this.Delete_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Delete_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_item.Location = new System.Drawing.Point(246, 14);
            this.Delete_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete_item.Name = "Delete_item";
            this.Delete_item.Size = new System.Drawing.Size(107, 34);
            this.Delete_item.TabIndex = 3;
            this.Delete_item.Text = "삭제";
            this.Delete_item.UseVisualStyleBackColor = false;
            this.Delete_item.Click += new System.EventHandler(this.btn_click_delete);
            // 
            // Add_item
            // 
            this.Add_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Add_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_item.Location = new System.Drawing.Point(361, 14);
            this.Add_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_item.Name = "Add_item";
            this.Add_item.Size = new System.Drawing.Size(107, 34);
            this.Add_item.TabIndex = 4;
            this.Add_item.Text = "추가";
            this.Add_item.UseVisualStyleBackColor = false;
            this.Add_item.Click += new System.EventHandler(this.Add_item_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.Save_item);
            this.panel1.Controls.Add(this.Save_button);
            this.panel1.Controls.Add(this.Add_item);
            this.panel1.Controls.Add(this.select_litem);
            this.panel1.Controls.Add(this.Delete_item);
            this.panel1.Location = new System.Drawing.Point(364, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 58);
            this.panel1.TabIndex = 5;
            // 
            // Save_item
            // 
            this.Save_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Save_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save_item.Location = new System.Drawing.Point(130, 14);
            this.Save_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save_item.Name = "Save_item";
            this.Save_item.Size = new System.Drawing.Size(107, 34);
            this.Save_item.TabIndex = 6;
            this.Save_item.Text = "저장";
            this.Save_item.UseVisualStyleBackColor = false;
            this.Save_item.Click += new System.EventHandler(this.btn_add_click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(1893, 14);
            this.Save_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(107, 34);
            this.Save_button.TabIndex = 5;
            this.Save_button.Text = "CSV저장";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.CSV_SAVE_click);
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
            this.item_cd1,
            this.item_nm1,
            this.item_cf1,
            this.item_og1,
            this.item_sales1,
            this.item_use1});
            this.dgv_Search.Location = new System.Drawing.Point(3, 210);
            this.dgv_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.RowHeadersWidth = 123;
            this.dgv_Search.RowTemplate.Height = 23;
            this.dgv_Search.Size = new System.Drawing.Size(1810, 928);
            this.dgv_Search.TabIndex = 6;
            // 
            // item_cd1
            // 
            this.item_cd1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_cd1.DataPropertyName = "item_cd1";
            this.item_cd1.FillWeight = 30F;
            this.item_cd1.HeaderText = "폼목코드";
            this.item_cd1.MinimumWidth = 15;
            this.item_cd1.Name = "item_cd1";
            // 
            // item_nm1
            // 
            this.item_nm1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_nm1.DataPropertyName = "item_nm1";
            this.item_nm1.FillWeight = 30F;
            this.item_nm1.HeaderText = "품목이름";
            this.item_nm1.MinimumWidth = 15;
            this.item_nm1.Name = "item_nm1";
            // 
            // item_cf1
            // 
            this.item_cf1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_cf1.DataPropertyName = "item_cf1";
            this.item_cf1.FillWeight = 30F;
            this.item_cf1.HeaderText = "품목구분";
            this.item_cf1.MinimumWidth = 15;
            this.item_cf1.Name = "item_cf1";
            // 
            // item_og1
            // 
            this.item_og1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_og1.DataPropertyName = "item_og1";
            this.item_og1.FillWeight = 30F;
            this.item_og1.HeaderText = "원산지";
            this.item_og1.MinimumWidth = 15;
            this.item_og1.Name = "item_og1";
            // 
            // item_sales1
            // 
            this.item_sales1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_sales1.DataPropertyName = "item_sales1";
            this.item_sales1.FillWeight = 30F;
            this.item_sales1.HeaderText = "가격";
            this.item_sales1.MinimumWidth = 15;
            this.item_sales1.Name = "item_sales1";
            // 
            // item_use1
            // 
            this.item_use1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_use1.DataPropertyName = "item_use1";
            this.item_use1.FillWeight = 30F;
            this.item_use1.HeaderText = "사용여부";
            this.item_use1.MinimumWidth = 15;
            this.item_use1.Name = "item_use1";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(3, 4);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(353, 196);
            this.panel9.TabIndex = 32;
            // 
            // Item_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1817, 1142);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dgv_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Item_form";
            this.Padding = new System.Windows.Forms.Padding(286, 0, 0, 0);
            this.Text = "품목";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
         
        private System.Windows.Forms.Button select_litem;
        private System.Windows.Forms.Button Delete_item;
        private System.Windows.Forms.Button Add_item;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_cd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_nm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_cf1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_og1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_sales1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_use1;
        private System.Windows.Forms.Button Save_item;
    }
}