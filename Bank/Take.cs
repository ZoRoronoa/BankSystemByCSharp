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
    public partial class Take : Form
    {
        private Users anotherForm;
        public string CurUserName;
        //public Bank CurBank;
        public Take(string anotherName)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//mp10maroon.ssk";
            //this.CurBank = anotherBank;
            this.CurUserName = anotherName;
            ShowSelectedCard();
            ShowCardInfo();
            ShowOperations();
        }
        //返回按钮
        private void buttonTakeBack_Click(object sender, EventArgs e)
        {
            anotherForm = new Users(CurUserName);
            
            anotherForm.Show();//ShowDialog();
            this.Close();                   //Application.ExitThread();
        }
        public void ShowSelectedCard()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "select account_id from account where name = '" + CurUserName + "';";
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //if (dr["psw"].ToString() == user_psw) { CurUserName = user_name; CurUser = new User(dr["name"].ToString(), dr["id_card"].ToString(), dr["psw"].ToString(), dr["gender"].ToString(), dr["phone_number"].ToString()); }
                    //else res = 2;
                    this.comboBoxTake.Items.Add(dr[0].ToString());
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
            if(this.comboBoxTake.Items.Count > 0)
            {
                this.comboBoxTake.SelectedIndex = 0;
            }
            
        }
        //取钱按钮
        private void buttonTakeTake_Click(object sender, EventArgs e)
        {
            string card = this.comboBoxTake.SelectedItem.ToString();
            if (card.Length == 0) { MessageBox.Show("请选择卡号！"); return; }
            string card_balance = Bankcard.GetBalance(card);
            string money = this.textBoxTakeMoney.Text;
            if (!User.IsMoney(money)) { MessageBox.Show("请注意金额格式!"); this.textBoxTakeMoney.Text = ""; return; }
            decimal money_number = Convert.ToDecimal(money);
            if (Convert.ToDecimal(card_balance) < money_number) { MessageBox.Show("余额不足！"); return; }
            //decimal money_number = Convert.ToDecimal(money);
            try
            {
                int flag = User.WithDraw(CurUserName, card, money_number);
                if (flag == 0)
                {
                    MessageBox.Show("取钱成功！");
                }
                else if (flag == 1)
                {
                    MessageBox.Show("余额不足，请更换卡号！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            ShowCardInfo();
            ShowOperations();
        }
        //用户名下银行卡渲染；
        public void ShowCardInfo()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "select account_id as '卡号', balance as '余额' from account where name = '" + CurUserName + "';";
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataAdapter da = new MySqlDataAdapter(text, dbon);
                DataTable tmp = new DataTable();
                da.Fill(tmp);
                //this.dgvUsersStatus.DataSource = tmp;
                //this.dgvSaveStatus.DataSource = tmp;
                this.dgvTakeStatus.DataSource = tmp;
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
        //用户最近操作渲染, 待进行操作，包括列表数量的限制等
        public void ShowOperations()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "select account_id as '卡号', transtime as '操作时间', transtype as '操作类型', transmoney as '金额' from transinfo where name = '" + CurUserName + "';";
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataAdapter da = new MySqlDataAdapter(text, dbon);
                DataTable tmp = new DataTable();
                da.Fill(tmp);
                this.dgvTakeOperation.DataSource = tmp;
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
