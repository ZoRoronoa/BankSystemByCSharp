using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class login : Form
    {
        //public Bank CurBank;
        public string CurUserName;
        private logon anotherFormL;
        private Users anotherFormU;
        private AdminAccount anotherFormA;
        int tmp;
        public login()
        {
            tmp = Bank.initial();
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//mp10.ssk";
            //anotherFormL = new logon();
            //anotherFormU = new Users(CurUserName);
            //anotherFormA = new AdminAccount();
            //CurBank = new Bank();
        }

      /*  private void button1_Click(object sender, EventArgs e)
        {
            anotherForm = new logon();
            this.Hide();
            anotherForm.ShowDialog();
            Application.ExitThread();
        }
        */
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonlogon_Click(object sender, EventArgs e)
        {
            //联网失败

            if(tmp == 1)
            {
                MessageBox.Show("数据连接失败，请检查网络连接！");
                return;
            }
            anotherFormL = new logon();

            anotherFormL.Show();//ShowDialog();
                                //Application.ExitThread();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //联网失败
           if(tmp == 1)
            {
                MessageBox.Show("数据连接失败，请检查网络连接！");
                return;
            }
            //这里分开判断账号密码如果是管理员则用
            string this_name = this.TextboxAccout.Text;
            string this_psw = this.TextboxPassword.Text;
            try
            {
                int res = Bank.Login(this_name, this_psw);
                switch (res)
                {
                    case 0:
                        {
                            CurUserName = Bank.CurUserName;
                            anotherFormU = new Users(CurUserName);
                            anotherFormU.Show();            //ShowDialog();
                            this.Hide();
                            break;
                        }
                    case 1:
                        {
                            anotherFormA = new AdminAccount();
                            anotherFormA.Show();//ShowDialog();
                            this.Hide();
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("该用户不存在，请注册或检查并重试！");
                            break;
                        }
                    case 3:
                        {
                            MessageBox.Show("用户名与密码不匹配， 请检查并重试！");
                            break;
                        }

                }
                //formal edition
                /*if (res == 0)
                {
                    CurUserName = Bank.CurUserName;
                    anotherFormU = new Users(CurUserName);
                    anotherFormU.Show();            //ShowDialog();
                    this.Hide();                    //Application.ExitThread();
                }
                else if (res == 1)
                {
                    anotherFormA = new AdminAccount();
                    anotherFormA.Show();//ShowDialog();
                    this.Hide();
                }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            //关于普通用户和管理员的区别稍后再写；

            /*if (TextboxAccout.Text == "wzs")
            {
                anotherFormA = new AdminAccount();
                
                anotherFormA.Show();//ShowDialog();
                this.Hide();                    //Application.ExitThread();
            }//}
            if (TextboxAccout.Text == "cbj")
            {
                anotherFormU = new Users();
                anotherFormU.Show();//ShowDialog();
                this.Hide();                    //Application.ExitThread();
            }//}*/
            // else if （账号密码存在）

            //if (TextboxAccout.Text == "cbj")
            /*
                anotherForm2 = new Users();
                this.Hide();
                anotherForm2.ShowDialog();
                Application.ExitThread();
                */
            //else 弹出对话框 不存在账户？
        }

        private void TextboxAccout_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
