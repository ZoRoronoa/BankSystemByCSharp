using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BankSystem
{
    public partial class Product : Form
    {
        private Users anotherForm;
        public string CurUserName;
        public const string ConnectStr = "server = 112.74.32.104; port = 3306;user = bank;password = Bank(123); database = bank;";
        public string edit = "";//记录上一次选择的产品
        
        //public Bank CurBank;
        public Product(string anotherName)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//mp10purple.ssk";
            //this.CurBank = anotherBank;
            this.CurUserName = anotherName;
            this.labelACCOUNT.Text = CurUserName;
            labelACCOUNT.Text = anotherName;
            ShowCardInfo();
            ShowSelectedCard();
            showpro();
        }

        private void buttonProductBack_Click(object sender, EventArgs e)
        {
            anotherForm = new Users(CurUserName);
            this.Close();
            anotherForm.Show();//ShowDialog();
                               //Application.ExitThread();
        }

        public void showproductcost(string money)
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "SELECT money,val from pro where money = '" + money + "';";
                MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.productcoast.Text = dr["val"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void showproductValue()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                double a = double.Parse(this.productcoast.Text.ToString());
                double b = double.Parse(this.labelProductHaveNumber.Text.ToString());
                double result = a * b;
                this.labelProductHaveMoney.Text = result.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
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
                    this.comboBoxProduct.Items.Add(dr[0].ToString());
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
            if (this.comboBoxProduct.Items.Count > 0)
            {
                this.comboBoxProduct.SelectedIndex = 0;
            }

        }

       void showProductown(string money,string id)
        {
            MySqlConnection dbon = new MySqlConnection(ConnectStr);
            try
            {
                dbon.Open();
                string sql = "SELECT * FROM product WHERE Pname = '" + money + "'AND account_id = '" + id + "' ;";
                MySqlCommand cmd_login = new MySqlCommand(sql, dbon);
                MySqlDataReader dr;
                dr = cmd_login.ExecuteReader();
                while (dr.Read())
                {
                    this.labelProductHaveNumber.Text = dr["POwn"].ToString();
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        void BuyProduct(int buytings, decimal allcoast, string id, string mname)
        {
            MySqlConnection dbon = new MySqlConnection(ConnectStr);
            dbon.Open();
            string bala = Bankcard.GetBalance(id);
            string cost = this.labelProductBuyMoney.Text;
            decimal costnum = Convert.ToDecimal(cost);
            if (Convert.ToDecimal(bala) < costnum) { MessageBox.Show("余额不足！"); }
            else
            {
                try
                {
                    string text = "update product set POwn = POwn + " + buytings + " where account_id = '" + id + "' AND Pname = '" + mname + "';";
                    MySqlCommand cmd = new MySqlCommand(text, dbon);
                    cmd.ExecuteNonQuery();
                    string text0 = "update account set balance = balance - " + allcoast + " where account_id = '" + id + "';";
                    MySqlCommand cmd1 = new MySqlCommand(text0, dbon);
                    cmd1.ExecuteNonQuery();
                    string text2 = "insert into transinfo(account_id, transtype, transmoney, name) values ('" + id + "', '购买 " + mname + "'," + allcoast + ",'" + CurUserName + "');";
                    cmd1 = new MySqlCommand(text2, dbon);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("购买 " +buytings.ToString()+" 百元份"+ mname + "成功,共花费" + allcoast.ToString() +"元人民币");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void buttonProductGold_Click(object sender, EventArgs e)//美元
        {
            try
            {
                string a = this.comboBoxProduct.Text.ToString();
                edit = this.buttonProductGold.Text.ToString();
                showProductown(edit, a);
                showproductcost(edit);
                showproductValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonProductSilver_Click(object sender, EventArgs e)//欧元
        {
            try
            {
                string a = this.comboBoxProduct.Text.ToString();
                edit = this.buttonProductSilver.Text.ToString();
                showProductown(edit, a);
                showproductcost(edit);
                showproductValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonProductDollars_Click(object sender, EventArgs e)//日元
        {
            try
            {
                string a = this.comboBoxProduct.Text.ToString();
                edit = this.buttonProductDollars.Text.ToString();
                showProductown(edit, a);
                showproductcost(edit);
                showproductValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonProductOil_Click(object sender, EventArgs e)//英镑
        {
            try
            {
                string a = this.comboBoxProduct.Text.ToString();
                edit = this.buttonProductOil.Text.ToString();
                showProductown(edit, a);
                showproductcost(edit);
                showproductValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonProductCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double A = double.Parse(this.productcoast.Text.ToString());
                int B = int.Parse(this.textBoxProductNumber.Text.ToString());
                double result = A * B;
                this.labelProductBuyMoney.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonProductBuy_Click(object sender, EventArgs e)
        {
            float fla = float.Parse(this.productcoast.Text.ToString());
            if (fla != 0)
            {
                try
                    {
               
                    int a = int.Parse(this.textBoxProductNumber.Text.ToString());
                    string b = this.comboBoxProduct.Text.ToString();
                    string user = this.comboBoxProduct.Text.ToString();
                    decimal allc = decimal.Parse(this.labelProductBuyMoney.Text.ToString());
                        if (allc != 0)
                        {
                            BuyProduct(a, allc, b, edit);
                            showProductown(edit, user);
                            ShowCardInfo();
                            showproductValue();
                        }
                        else { MessageBox.Show("失败，请输入购买数额"); }
               
                }
                catch 
                {
                    MessageBox.Show("购买失败，请输入具体购买数额");
                }
            }
            else { MessageBox.Show("购买失败，请选择要购买的外汇产品"); }
        }

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
                this.dgvProductStatus.DataSource = tmp;
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

        public void showpro()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "select money as '外汇', val as '价格', tim '更新时间' from pro;";
                MySqlDataAdapter da = new MySqlDataAdapter(text, dbon);
                DataTable tmp = new DataTable();
                da.Fill(tmp);
                this.dataGridView1.DataSource = tmp;
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

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void textBoxProductNumber_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxProductNumber.Text != "")
            {
                float fla = float.Parse(this.productcoast.Text.ToString());
                if (fla != 0)
                {
                    try
                    {

                        double A = double.Parse(this.productcoast.Text.ToString());
                        int B = int.Parse(this.textBoxProductNumber.Text.ToString());
                        double result = A * B;
                        this.labelProductBuyMoney.Text = result.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("输入错误，请输入整数。");
                    }
                }
                else { MessageBox.Show("Tips！请选择外汇产品后再输入购买数额！"); }
            }
            else
            {
                this.labelProductBuyMoney.Text = "0";
            }
        }
    }
}
