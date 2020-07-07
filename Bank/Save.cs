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
    public partial class Save : Form
    {
        private Users anotherForm;
        public Bank CurBank;
        public string CurUserName;
        public Save(string anotherName)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//mp10.ssk";
            //this.CurBank = anotherBank;
            this.CurUserName = anotherName;
            //渲染问题，主要是当前用户下的卡号渲染；
            ShowSelectedCard();
            ShowCardInfo();
            ShowOperations();
        }

        //返回按钮；
        private void buttonSaveBack_Click(object sender, EventArgs e)
        {
            /*string card = this.comboBoxSave.SelectedItem.ToString();
            string money = this.textBoxSaveMoney.Text;
            decimal money_number = Convert.ToDecimal(money);
            try
            {
                bool flag = this.CurBank.CurUser.Save(card, money_number);
                if (flag)
                {
                    MessageBox.Show("存钱成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }*/
            anotherForm = new Users(CurUserName); //TODO：
            anotherForm.Show();//ShowDialog();
            this.Close();                   //Application.ExitThread();
        }

        //可选择卡片的渲染；
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
                dr = cmd.ExecuteReader()    ;
                while (dr.Read())
                {
                    //if (dr["psw"].ToString() == user_psw) { CurUserName = user_name; CurUser = new User(dr["name"].ToString(), dr["id_card"].ToString(), dr["psw"].ToString(), dr["gender"].ToString(), dr["phone_number"].ToString()); }
                    //else res = 2;
                    this.comboBoxSave.Items.Add(dr[0].ToString());
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
            if(this.comboBoxSave.Items.Count > 0)
            {
                this.comboBoxSave.SelectedIndex = 0;
            }
            
        }
        //存钱按钮
        private void buttonSaveSave_Click(object sender, EventArgs e)
        {
            string card = this.comboBoxSave.SelectedItem.ToString();
            if(card.Length == 0) { MessageBox.Show("请选择卡号！");return; }
            string money = this.textBoxSaveMoney.Text;
            if (!User.IsMoney(money)) { MessageBox.Show("请注意金额格式!");this.textBoxSaveMoney.Text = ""; return; }
            decimal money_number = Convert.ToDecimal(money);
            try
            {
                //bool flag = this.CurBank.CurUser.Save(card, money_number);
                bool flag = User.Save(CurUserName, card, money_number);
                if (flag)
                {
                    MessageBox.Show("存钱成功！");
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
                this.dgvSaveStatus.DataSource = tmp;
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
                //string text = "select account_id, transtime, transtype, transmoney from transinfo where name = '" + CurUserName + "';";
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataAdapter da = new MySqlDataAdapter(text, dbon);
                DataTable tmp = new DataTable();
                da.Fill(tmp);
                
                this.dgvSaveOperation.DataSource = tmp;
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

        private void dgvSaveOperation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Save_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSaveMoney_TextChanged(object sender, EventArgs e)
        {

        }
        //正则验证， 即金额输入是否格式正确；
        /*public static bool IsMoney(string input)
        {
            string pattern = @"^([1-9]\d{0,9}|0)(\.\d{1,2})?$";
            //^ ([1 - 9]\d{ 0,9}| 0)([.] ?| (\.\d{ 1,2})?)$
            //^[1-9]([0-9]+)?(\.[0-9]{1,2})?$)|(^(0){1}$)|(^[0-9]\.[0-9]([0-9])?$
            //@"^([1-9]\d{0,9}|0)(\.\d{1,2})?$"
            return System.Text.RegularExpressions.Regex.IsMatch(input, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }*/
    }
}
