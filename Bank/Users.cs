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
    public partial class Users : Form
    {
        public string CurUserName;
        private login anotherFormB;
        private Save anotherFormS;
        private Take anotherFormTa;
        private Transfer anotherFormTr;
        private Product anotherFormP;
        private Apply anotherFormA;
        private Change anotherFormC;

        public Users(string anotherName)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//mp10purple.ssk";
            this.CurUserName = anotherName;
            ShowName();
            ShowCardInfo();
            ShowOperations();
            /*anotherFormB = new login();
            anotherFormS = new Save();
            anotherFormTa = new Take();
            anotherFormTr = new Transfer();
            anotherFormP = new Product();
            */
            //this.dgvUsersStatus 操作

        }

        private void buttonUsersBack_Click(object sender, EventArgs e)
        {
            anotherFormB = new login();
            this.Close();
            anotherFormB.Show();//ShowDialog();
                                //Application.ExitThread();
        }

        private void buttonUsersSave_Click(object sender, EventArgs e)
        {
            //string this_card = this
            anotherFormS = new Save(CurUserName);
            this.Close();
            anotherFormS.Show();//ShowDialog();
            //Application.ExitThread();
        }

        private void buttonUsersTake_Click(object sender, EventArgs e)
        {
            anotherFormTa = new Take(CurUserName);
            this.Close();
            anotherFormTa.Show();//ShowDialog();
            //Application.ExitThread();
        }

        private void buttonUsersTransfer_Click(object sender, EventArgs e)
        {
            anotherFormTr = new Transfer(CurUserName);
            this.Close();
            anotherFormTr.Show();//ShowDialog();
            //Application.ExitThread();
        }

        private void buttonUsersProduct_Click(object sender, EventArgs e)
        {
            anotherFormP = new Product(CurUserName);
            this.Close();
            anotherFormP.Show();//ShowDialog();
            //Application.ExitThread();
        }

        private void buttonUsersApply_Click(object sender, EventArgs e)
        {
            anotherFormA = new Apply(CurUserName);
            this.Close();
            anotherFormA.Show();//ShowDialog();
            //Application.ExitThread();
        }
        
        //用户名下银行卡渲染；
        public void ShowCardInfo()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "select account_id as '卡号', balance as '余额' from account where name = '" + CurUserName + "';";
                //string text = "select account_id, balance, create_time, state from account where name = '" + CurUserName + "';";
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataAdapter da = new MySqlDataAdapter(text, dbon);
                DataTable tmp = new DataTable();
                da.Fill(tmp);
                this.dgvUsersStatus.DataSource = tmp;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbon.Close();
            }
        }

        //用户最近操作渲染, 待进行操作，包括列表数量的限制等
        public void ShowOperations()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "select account_id as '卡号', transtime as '操作时间', transtype as '操作类型', transmoney as '金额' from transinfo where name = '" + CurUserName + "';";
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataAdapter da = new MySqlDataAdapter(text, dbon);
                DataTable tmp = new DataTable();
                da.Fill(tmp);
                this.dgvUsersOperation.DataSource = tmp;
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

        public void ShowName()
        {
            this.labelUsersAccount.Text = CurUserName;
        }

        private void buttonUsersChange_Click(object sender, EventArgs e)
        {
            anotherFormC = new Change(CurUserName);
            this.Close();
            anotherFormC.Show();//ShowDialog();
            //Application.ExitThread();
        }
    }
}
