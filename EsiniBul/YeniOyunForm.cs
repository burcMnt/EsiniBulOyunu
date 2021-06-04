using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBul
{
    public partial class YeniOyunForm : Form
    {
        public YeniOyunForm()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            ZorlukSeviye zs = rbKolay.Checked ? ZorlukSeviye.Kolay : (rbOrta.Checked ? ZorlukSeviye.Orta : ZorlukSeviye.Zor);
            Hide();
           // new Form1().Show(this);
            Form1 frmOyun = new Form1(zs);
            //bu formu. frmoyun formunun Owneri yap
            frmOyun.Show(this);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
