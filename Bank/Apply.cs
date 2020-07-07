using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BankSystem
{
    public partial class Apply : Form
    {
        private Users anotherForm;
        public string CurUserName;
        //public Bank CurBank;
        public Apply(string anotherName)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//mp10pink.ssk";
            //this.CurBank = anotherBank;
            this.CurUserName = anotherName;
            ShowCard();
            ShowMessage();
        }

        private void buttonApplyBack_Click(object sender, EventArgs e)
        {
            anotherForm = new Users(CurUserName);
            this.Close();
            anotherForm.Show();//ShowDialog();
                               //Application.ExitThread();
        }

        //申请开户
        private void buttonApplyCheck_Click(object sender, EventArgs e)
        {
            string allocated_card = this.labelApplyCard.Text;
            try
            {
                bool flag = User.Register_Card(CurUserName, allocated_card);
                Bank.productinitial(allocated_card);
                if (flag)
                {
                    MessageBox.Show("申请成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowCard()
        {
            string tmp = RadCardId();
            this.labelApplyCard.Text = tmp;
        }

        //分配卡号函数
        string RadCardId()
        {
            Random rd = new Random();
            int a = rd.Next(100000000, 1000000000);
            return "622700" + a.ToString();
        }

        private void buttonApplyReset_Click(object sender, EventArgs e)
        {
            ShowCard();
        }

        void ShowMessage()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "select * from custom where name = '" + CurUserName + "';";
                
                MySqlCommand cmd_login = new MySqlCommand(text, dbon);
                MySqlDataReader dr;
                dr = cmd_login.ExecuteReader();
                while (dr.Read())
                {
                    this.labelApplyAccount.Text = dr["name"].ToString();
                    //this.labelApplyAccount.Text = "testtesteststestest";
                    this.labelApplyIdentity.Text = dr["id_card"].ToString();
                    this.labelApplyPhone.Text = dr["phone_number"].ToString();
                    this.labelApplySex.Text = dr["gender"].ToString();
                    //{ CurUserName = user_name; CurUser = new User(dr["name"].ToString(), dr["id_card"].ToString(), dr["psw"].ToString(), dr["gender"].ToString(), dr["phone_number"].ToString()); }
                    
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbon.Close();
            }
            
        }
    }
}
