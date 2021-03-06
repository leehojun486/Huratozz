
namespace wujudaesselleagi
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

         #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("코드마스터");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("품목");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("직원정보");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("거래처정보");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("기준정보", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("발주");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("발주현황");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("구매등록");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("영업관리", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Maroon;
            this.treeView1.ForeColor = System.Drawing.SystemColors.Window;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(1, 131);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "code_master";
            treeNode1.Text = "코드마스터";
            treeNode2.Name = "Item_list";
            treeNode2.Text = "품목";
            treeNode3.Name = "User_list";
            treeNode3.Text = "직원정보";
            treeNode4.Name = "buy_list";
            treeNode4.Text = "거래처정보";
            treeNode5.Name = "Item";
            treeNode5.Text = "기준정보";
            treeNode6.Name = "Bar_list";
            treeNode6.Text = "발주";
            treeNode7.Name = "Bar_now_list";
            treeNode7.Text = "발주현황";
            treeNode8.Name = "wh_order";
            treeNode8.Text = "구매등록";
            treeNode9.Name = "sales";
            treeNode9.Text = "영업관리";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(200, 999);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.double_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 132);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(200, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1607, 1069);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawItem_eve);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_eve);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 1061);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.Text = "후라토식당.ver1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TreeView treeView1;
    }
}

