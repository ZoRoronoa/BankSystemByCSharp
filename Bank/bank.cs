using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BankSystem
{
    public class Bank
    { 
        //public static User CurUser;
        public static string CurUserName;
        //连接你自己的数据库
        public const string ConnectStr = "server = ********; port = 3306;user = bank;password = ****; database = ****;";
        static public int initial()
        {
            int res = 0;
            //数据库连接和建表初始化
            //建表
            try
            {
            MySqlConnection dbon = new MySqlConnection(ConnectStr);
            dbon.Open();
            //string insertDB = "INSERT INTO user VALUE(" + account.u_id0 + ",'" + account.u_pwd0 + "'," + "'" + account.u_Sex + "'," + account.IDCard + "," + account.U_PN + "," + account.u_Money + ");";
            string createtable_custom = "create table if not exists custom ( name varchar(15), id_card char(18), psw varchar(25), gender varchar(4), phone_number char(11), primary key(name));";
            MySqlCommand cmd = new MySqlCommand(createtable_custom, dbon);
            cmd.ExecuteNonQuery();
            string createtable_account = "create table if not exists account ( account_id char(15), balance decimal(19, 2), create_time TIMESTAMP default current_timestamp, name varchar(15), state varchar(6), primary key (account_id), foreign key (name) references custom(name));";
            cmd = new MySqlCommand(createtable_account, dbon);
            cmd.ExecuteNonQuery();
            string createtable_transinfo = "create table if not exists transinfo ( id INT auto_increment, transtime TIMESTAMP default current_timestamp, account_id char(15), transtype varchar(6), transmoney float(2), name varchar(15), primary key (id), foreign key (account_id) references account(account_id), foreign key (name) references custom(name));";
            cmd = new MySqlCommand(createtable_transinfo, dbon);
            cmd.ExecuteNonQuery();
            string createtable_product = "create table if not exists product ( account_id char(15),Pname char(4), POwn INT(4));";
            cmd = new MySqlCommand(createtable_product, dbon);
            cmd.ExecuteNonQuery();
            //管理员初始化,注意语法
            string admin_reset = "insert into custom(name, psw) select 'admin', 'admin' from dual where not exists (select * from custom where name = 'admin')";
            cmd = new MySqlCommand(admin_reset, dbon);
            cmd.ExecuteNonQuery();

            dbon.Close();
            }
            catch
            {
                res = 1;
            }
            return res;
        }

        //用户登陆, 返回值
        //0：普通用户
        //1：管理员用户 
        //2: 用户不存在
        //3：账户密码错误
        public static int Login(string user_name, string user_psw)
        {
            MySqlConnection dbon = new MySqlConnection(ConnectStr);
            int res = 0;
            try
            {
                dbon.Open();
                string text = "select * from custom where name = '" + user_name + "';";
                MySqlCommand cmd_login = new MySqlCommand(text, dbon);
                MySqlDataReader dr;
                dr = cmd_login.ExecuteReader();
                bool null_flag = true;
                while (dr.Read())
                {
                    null_flag = false;
                    if (dr["psw"].ToString() == user_psw)
                    {
                        if (user_name == "admin") res = 1;
                        else
                        {
                            CurUserName = dr["name"].ToString();
                        }//CurUser = new User(dr["name"].ToString(), dr["id_card"].ToString(), dr["psw"].ToString(), dr["gender"].ToString(), dr["phone_number"].ToString());
                    }
                    else res = 3;
                }
                dr.Close();
                //用户不存在！
                if (null_flag) res = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbon.Close();
            }
            return res;
        }
        //用户注册 
        //0: 注册成功
        //1: 该昵称已被占用
        //2：身份证不合法，请重新输入
        //3：电话号码不合法，请重新输入
        //4： 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user_name"></param>
        /// <param name="psw"></param>
        /// <param name="id_card"></param>
        /// <param name="phone_number"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        public static int Register(string user_name, string psw, string id_card, string phone_number, string gender)
        {
            MySqlConnection dbon = new MySqlConnection(ConnectStr);
            int res = 0;
            try
            {
                dbon.Open();
                string insert_custom = "insert into custom values ('" + user_name + "', '" + id_card + "', '" + psw + "', '" + gender + "', '" + phone_number + "');";
                MySqlCommand cmd_insert = new MySqlCommand(insert_custom, dbon);
                cmd_insert.ExecuteNonQuery();

            }
            //异常可能有多种，这里先给出一个显式的错误；
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                res = 1;
            }
            finally { dbon.Close(); }
            return res;
        }

        public static void productinitial(string acID)//理财产品初始化 
        {
            MySqlConnection dbon = new MySqlConnection(ConnectStr);
            try
            {
                dbon.Open();
                string initial_product = "insert into product values ('" + acID + "','美元',0);";
                MySqlCommand cmd_initial = new MySqlCommand(initial_product, dbon);
                cmd_initial.ExecuteNonQuery();
                string initial_product0 = "insert into product values ('" + acID + "','欧元',0);";
                cmd_initial = new MySqlCommand(initial_product0, dbon);
                cmd_initial.ExecuteNonQuery();
                string initial_product1 = "insert into product values ('" + acID + "','日元',0);";
                cmd_initial = new MySqlCommand(initial_product1, dbon);
                cmd_initial.ExecuteNonQuery();
                string initial_product2 = "insert into product values ('" + acID + "','英镑',0);";
                cmd_initial = new MySqlCommand(initial_product2, dbon);
                cmd_initial.ExecuteNonQuery();
                dbon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

