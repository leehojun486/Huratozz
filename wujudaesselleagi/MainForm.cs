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

namespace wujudaesselleagi
{
    public partial class MainForm : Form
    {
        public static Dictionary<string, int> DICT_REMOVE_INDEX = new Dictionary<string, int>();
        /*   private Item_form mChildForm1 = null;
           private TJ_Form mChildForm2 = null;
           private staff_list mChildForm3 = null;
           private valju mChildForm4 = null; */
        public MainForm()
        {
            InitializeComponent();
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


        private void double_click(object sender, TreeNodeMouseClickEventArgs e)
          {
             
              if (e.Node.Name.Contains("Item_list"))
              {
                if (!DICT_REMOVE_INDEX.ContainsKey(e.Node.Text))
                {
                    Item_form item = new Item_form();
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

                    /*  Item_form item = new Item_form();
                      item.TopLevel = false;
                      tabControl1.TabPages.Add(e.Node.Text);
                      tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);
                      tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                      tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);

                      item.Name = "itemz";
                      item.Text = "itemz1";



                      item.Show(); */
                    tabControl1.SelectedTab = tabControl1.TabPages[DICT_REMOVE_INDEX[e.Node.Text]];
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

                    tabControl1.SelectedTab = tabControl1.TabPages[DICT_REMOVE_INDEX[e.Node.Text]];
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

                    tabControl1.SelectedTab = tabControl1.TabPages[DICT_REMOVE_INDEX[e.Node.Text]];
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
            if (e.Node.Text.Contains("발주"))
            {
                
                valju item = new valju();
                item.TopLevel = false;
                tabControl1.TabPages.Add((tabControl1.TabPages.Count + 1).ToString());
                tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);

                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(item);
                item.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                item.Show();



            }

        }

        private void DrawItem_eve(object sender, DrawItemEventArgs e)
        {
               e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
               e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
               e.DrawFocusRectangle();
           }

           private void Mouse_Down_eve(object sender, MouseEventArgs e)
           {
               for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
               {
                   Rectangle r = tabControl1.GetTabRect(i);
                   //Getting the position of the "x" mark.
                   Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                   if (closeButton.Contains(e.Location))
                   {
                           this.tabControl1.TabPages.RemoveAt(i);
                           break;

                   }
               }  
         
        
    } 
    }
   }
      
    

