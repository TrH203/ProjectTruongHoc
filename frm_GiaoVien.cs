using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTruongHoc
{
    public partial class frm_GiaoVien : Form
    {
        public frm_GiaoVien()
        {
            InitializeComponent();
        }

        private void giaoBàiTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_GiaoBaiTap"] == null)
            {
                frm_GiaoBaiTap bt = new frm_GiaoBaiTap();
                bt.MdiParent = this;
                bt.Show();
            }
            else { Application.OpenForms["frm_GiaoBaiTap"].Activate(); }
        }
    }
}
