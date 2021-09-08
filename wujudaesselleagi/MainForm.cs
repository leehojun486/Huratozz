using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Draw = System.Drawing;

namespace wujudaesselleagi
{
    public partial class MainForm : Form
    {
        public static Dictionary<string, int> DICT_REMOVE_INDEX = new Dictionary<string, int>(); // DICT_REMOVE_INDEX Dictionary 에 키,페이지번호 저장
        // 닫기버튼 이미지 위치
        private Draw.Point _imageLocation = new Draw.Point(15, 5); 
        private Draw.Point _imgHitArea = new Draw.Point(13, 2);  

        public MainForm()
        {
            InitializeComponent();
                        this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;  // Tab컨트롤 상속
            this.tabControl1.ItemSize = new Draw.Size(100, 20);
            this.tabControl1.SizeMode = TabSizeMode.Fixed;

            // Add the Handler to draw the Image on Tab Pages
            tabControl1.DrawItem += DrawItem_eve;


        }

        /* private Form ShowOrActiveForm(Form form, Type t)
         {
             if (form == null)
             {
                 form = (Form)Activator.CreateInstance(t);
                 form.MdiParent = this;
                 form.WindowState = FormWindowState.Maximized;
                 form.Show();
             }
             else
             {
                 if (form.IsDisposed)
                 {
                     form = (Form)Activator.CreateInstance(t);
                     form.MdiParent = this;
                     form.WindowState = FormWindowState.Maximized;
                     form.Show();
                 }
                 else
                 {
                     form.Activate();
                 }
             }
             return form;
         } */


        // TreeView 노드 더블클릭 이벤트
        private void double_click(object sender, TreeNodeMouseClickEventArgs e)
          {
         

             
              if (e.Node.Name.Contains("Item_list"))  // item_list 노드를 클릭했을 경우
              {
                if (!DICT_REMOVE_INDEX.ContainsKey(e.Node.Text))  // 딕셔너리 key에 node.text 가 없다면
                {
                    Item_form item = new Item_form();   //item폼 객체생성
                    item.TopLevel = false;  // 다른컨트롤에 폼포함 가능
                    
                    tabControl1.TabPages.Add(e.Node.Text);  // node.text 이름의 페이지 추가
                    tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);  // tabpgde 에 item 폼 출력
                    tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                    tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);

                    // 딕셔너리 에 노드 text, 컨트롤 인덱스 저장
                    DICT_REMOVE_INDEX.Add(e.Node.Text, tabControl1.SelectedIndex);

                    item.Dock = DockStyle.Fill;
                    item.Show();
           


                }
                else
                {

                    /*  Item_form item = new Item_form();
                      item.TopLevel = false;
                      tabControl1.TabPages.Add(e.Node.Text);
                      tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);
                      tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                      tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);

                      item.Name = "itemz";
                      item.Text = "itemz1";



                      item.Show(); */
                  
                        tabControl1.SelectedTab = tabControl1.TabPages[DICT_REMOVE_INDEX["품목"]];
                    
  
                   }

            }

              if (e.Node.Name.Contains("User_list"))
              {


                if (!DICT_REMOVE_INDEX.ContainsKey(e.Node.Text))
                {
                    staff_list item = new staff_list();
                    item.TopLevel = false;

                    tabControl1.TabPages.Add(e.Node.Text);
                    tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);
                    tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                    tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);

                    DICT_REMOVE_INDEX.Add(e.Node.Text, tabControl1.SelectedIndex);

                    item.Dock = DockStyle.Fill;
                    item.Show();



                }
                else
                {

                    tabControl1.SelectedTab = tabControl1.TabPages[DICT_REMOVE_INDEX["직원정보"]];
                }


            }

              if (e.Node.Name.Contains("buy_list"))
              {
                if (!DICT_REMOVE_INDEX.ContainsKey(e.Node.Text))
                {
                    TJ_Form item = new TJ_Form();
              
                    item.TopLevel = false;

                    tabControl1.TabPages.Add(e.Node.Text);
                    tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);
                    tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                    tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);

                    DICT_REMOVE_INDEX.Add(e.Node.Text, tabControl1.SelectedIndex);

                    item.Dock = DockStyle.Fill; 
                    item.Show();



                }
                else
                {

                    tabControl1.SelectedTab = tabControl1.TabPages[DICT_REMOVE_INDEX["거래처정보"]];
                }


            }
           /*   if (e.Node.Text.Contains("발주"))
              {
                  if (ActiveMdiChild != null)  // 자식폼이 열려 있으면
                  {
                      if (this.ActiveMdiChild != mChildForm4)  // 열려있는 자식폼이 Form1 이 아니면
                      {
                          ActiveMdiChild.Close(); // 현재 활성화된 창을 닫아라

                      }
                      mChildForm4 = ShowOrActiveForm(mChildForm4, typeof(valju)) as valju;

                  }
                  else
                  {
                      mChildForm4 = ShowOrActiveForm(mChildForm4, typeof(valju)) as valju;

                  }

              } */
            if (e.Node.Name.Contains("Bar_list"))
            {

                if (!DICT_REMOVE_INDEX.ContainsKey(e.Node.Text))
                {
                    valju item = new valju();
                    item.TopLevel = false;

                    tabControl1.TabPages.Add(e.Node.Text);
                    tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);
                    tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                    tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);

                    DICT_REMOVE_INDEX.Add(e.Node.Text, tabControl1.SelectedIndex);

                    item.Dock = DockStyle.Fill;
                    item.Show();



                }
                else
                {

                    tabControl1.SelectedTab = tabControl1.TabPages[DICT_REMOVE_INDEX[e.Node.Text]];
                }


            }

        }
        private void DeleteTabpage(string temp)  //탭삭제시 텝 Dicnary 삭제 
        {
            int aint = 0;
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                if (tabControl1.TabPages[i].Text == temp)
                {
                    aint = i;
                }
            }
            tabControl1.TabPages.RemoveAt(aint);

            int index = DICT_REMOVE_INDEX[temp];

            DICT_REMOVE_INDEX.Remove(temp);

            //탭페이지를 앞으로 한칸씩땡긴다.
            if (DICT_REMOVE_INDEX.Count > 2)
            {
                for (int i = index; i < DICT_REMOVE_INDEX.Count; i++)
                {
                    string tempstring = DICT_REMOVE_INDEX.FirstOrDefault(x => x.Value == i + 1).Key;
                    int tempint = DICT_REMOVE_INDEX[tempstring];
                    DICT_REMOVE_INDEX.Remove(tempstring);
                    DICT_REMOVE_INDEX.Add(tempstring, tempint - 1);
                }
            }
            tabControl1.SelectedIndex = aint - 1;
        }

        int tabindex = 0;


        private void DrawItem_eve(object sender, DrawItemEventArgs e)  // 
      /*  {
               e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
               e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
               e.DrawFocusRectangle();
           }*/
       {
            try
            {
                Draw.Image img;

                Draw.Font f = this.Font;

                Draw.Rectangle r = e.Bounds;
                Draw.Brush titleBrush = new Draw.SolidBrush(Draw.Color.Black);
                string title = this.tabControl1.TabPages[e.Index].Text;



                r = this.tabControl1.GetTabRect(e.Index);
                r.Offset(2, 2);



                // SelectedTab의 Background Color 는 White으로 처리
                if (this.tabControl1.SelectedIndex == e.Index)
                    e.Graphics.FillRectangle(new Draw.SolidBrush(Draw.Color.White), e.Bounds);


                // 각 Tab별로 close button 에 대한 image값 
                if (this.tabControl1.SelectedTab == this.tabControl1.TabPages[e.Index])
                    img = Properties.Resources.delete;
                else
                    img = Properties.Resources.delete;

                // TabPage Text
                e.Graphics.DrawString(title+ " ", f, titleBrush, new Draw.PointF(r.X, r.Y));


                // TabPage 의 닫기 버튼
                e.Graphics.DrawImage(img, new Draw.Point(r.X + this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X, _imageLocation.Y));

                img.Dispose();
                img = null;
            }


            catch (Exception)
            {
            }
           
        }

           private void Mouse_Down_eve(object sender, MouseEventArgs e)
        {

            System.Windows.Forms.TabControl tc = (System.Windows.Forms.TabControl)sender;
            tabindex = tc.SelectedIndex;
            Draw.Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl1.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X);
            Draw.Rectangle r = this.tabControl1.GetTabRect(tc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (r.Contains(p))
            {
                TabPage TabP = (TabPage)tc.TabPages[tc.SelectedIndex];
                tc.TabPages.Remove(TabP);



                //MessageBox.Show(TabP.Text);
                int index = DICT_REMOVE_INDEX[TabP.Text];
                DICT_REMOVE_INDEX.Remove(TabP.Text);

                //탭페이지를 앞으로 한칸씩땡긴다.
                for (int i = index; i < DICT_REMOVE_INDEX.Count; i++)
                {
                    string tempstring = DICT_REMOVE_INDEX.FirstOrDefault(x => x.Value == i + 1).Key;
                    int tempint = DICT_REMOVE_INDEX[tempstring];
                    DICT_REMOVE_INDEX.Remove(tempstring);
                    DICT_REMOVE_INDEX.Add(tempstring, tempint - 1);
                }
            }
        }

    }
   }
      
    

