using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_TTN
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            
        }
        private void addControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(c);
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:mm:ss");
            lblDate.Text = dt.ToString("dd/MM/yyyy");
        }

        private void iconButtonDocGia_Click(object sender, EventArgs e)
        {
            UC_DocGia uC_DocGia = new UC_DocGia();
            addControlToPanel(uC_DocGia);
        }

        private void iconButtonSach_Click(object sender, EventArgs e)
        {
            UC_Sach uC_Sach = new UC_Sach();
            addControlToPanel(uC_Sach);
        }

        private void iconButtonTheThuVien_Click(object sender, EventArgs e)
        {
            UC_TheThuVien uC_TheThuVien = new UC_TheThuVien();
            addControlToPanel(uC_TheThuVien);
        }

        

        private void iconButtonNhanVien_Click(object sender, EventArgs e)
        {
            UC_NhanVien uC_NhanVien = new UC_NhanVien();
            addControlToPanel(uC_NhanVien);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UC_Desktop uC_Desktop = new UC_Desktop();
            addControlToPanel(uC_Desktop);
        }
    }
}
