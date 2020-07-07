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
    public partial class AdminCard : Form
    {
        private login anotherFormL;
        //private AdminCard anotherFormC;
        private AdminOperation anotherFormO;
         private AdminAccount anotherFormA;
        public AdminCard()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//EighteenColor1.ssk";
        }

        private void buttonApplyBack_Click(object sender, EventArgs e)
        {
            anotherFormL = new login();
            this.Close();
            anotherFormL.Show();//ShowDialog();
                                //Application.ExitThread()
        }

        private void buttonAdminCardAccount_Click(object sender, EventArgs e)
        {
            anotherFormA = new AdminAccount();
            this.Close();
            anotherFormA.Show();//ShowDialog();
                                //Application.ExitThread()
        }

        private void buttonAdminCardCard_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdminCardOperation_Click(object sender, EventArgs e)
        {
            anotherFormO = new AdminOperation();
            this.Close();
            anotherFormO.Show();//ShowDialog();
                                //Application.ExitThread()
        }

        private void AdminCard_Load(object sender, EventArgs e)
        {

        }
    }
}
