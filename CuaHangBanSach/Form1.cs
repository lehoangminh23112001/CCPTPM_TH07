using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanSach
{
    public partial class frmCuaHangBanSach : Form
    {
        private int selectedSach;
        private List<Sach> sach = new List<Sach>();
        public frmCuaHangBanSach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sach.RemoveAt(dgvLstSach.SelectedRows[0].Index);
            dgvLstSach.DataSource = new List<Sach>();
            dgvLstSach.DataSource = sach;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sach a = new Sach();
            a.TenSach = txtTenSach.Text;
            a.MaSach = txtMaSach.Text;
            a.LoaiSach = txtLoaiSach.Text;
            a.GiaTien = txtGiaSach.Text;
            a.SoLuongTonKho = txtSoLuongTonKho.Text;
            sach.Add(a);
            dgvLstSach.DataSource = new List<Sach>();
            dgvLstSach.DataSource = sach;
        }

        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    int i = selectedSach;
        //    sach[i].TenSach = txtTenSach.Text;
        //    sach[i].MaSach = txtMaSach.Text;
        //    sach[i].LoaiSach = txtLoaiSach.Text;
        //    sach[i].GiaTien = txtGiaSach.Text;
        //    sach[i].SoLuongTonKho = txtSoLuongTonKho.Text;
        //    dgvLstSach.DataSource = new List<Sach>();
        //    dgvLstSach.DataSource = sach;
        //}

        private void dgvLstSach_DoubleClick(object sender, EventArgs e)
        {
            selectedSach = dgvLstSach.SelectedRows[0].Index;
            Sach a = sach[selectedSach];
            txtMaSach.Text = a.MaSach;
            txtTenSach.Text = a.TenSach;
            txtLoaiSach.Text = a.LoaiSach;
            txtGiaSach.Text = a.GiaTien;
            txtSoLuongTonKho.Text = a.SoLuongTonKho;
        }

        private void frmCuaHangBanSach_Load(object sender, EventArgs e)
        {
            lblSoCuonSach.Text = lblSoLuongTonKho.Text = lblTongTienHangTonKho.Text = "";
            sach.Add(new Sach
            {
                MaSach = "123",
                TenSach = "Doraemon",
                LoaiSach = "Truyện tranh",
                GiaTien = "20000",
                SoLuongTonKho = "500",
            });
            sach.Add(new Sach
            {
                MaSach = "124",
                TenSach = "Conan",
                LoaiSach = "Truyện tranh",
                GiaTien = "20000",
                SoLuongTonKho = "500",
            });
            sach.Add(new Sach
            {
                MaSach = "125",
                TenSach = "Hóa Học 12",
                LoaiSach = "Sách Giáo Khoa",
                GiaTien = "20000",
                SoLuongTonKho = "500",
            });
            sach.Add(new Sach
            {
                MaSach = "126",
                TenSach = "Vật Lí 12",
                LoaiSach = "Sách Giáo Khoa",
                GiaTien = "20000",
                SoLuongTonKho = "500",
            });
            sach.Add(new Sach
            {
                MaSach = "127",
                TenSach = "Fairy Tails",
                LoaiSach = "Truyện tranh",
                GiaTien = "20000",
                SoLuongTonKho = "500",
            });
            dgvLstSach.DataSource = sach;
        }

        private void đếmSốCuốnSáchTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int tongSoLuong = 0;
            foreach (var item in sach)
            { 
                
                tongSoLuong += Convert.ToInt32(item.SoLuongTonKho);
            }
            lblSoCuonSach.Text ="Số cuốn sách trong kho: " + tongSoLuong.ToString();
            
        }

        private void đếmTổngSốLượngTồnKhoCủaTấtCảCácSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tongSoLuong = 0;
            foreach (var item in sach)
            {

                tongSoLuong += Convert.ToInt32(item.SoLuongTonKho);
            }
            lblSoLuongTonKho.Text = "Tổng số lượng tồn kho của tất cả các sách: "+ tongSoLuong.ToString();
        }

        private void tínhTổngTiềnHàngTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            foreach(var item in sach)
            {
                tongTien += Convert.ToInt32( item.GiaTien) * Convert.ToInt32( item.SoLuongTonKho);
            }
            lblTongTienHangTonKho.Text = "Tổng tiền hàng tồn kho: "+ tongTien.ToString();
        }
    }
}
