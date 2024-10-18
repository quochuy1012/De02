using De02.Enititites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De02
{
    public partial class Form1 : Form
    {
        StudentModelDB studentmodeldb = new StudentModelDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sanpham> listSanpham = studentmodeldb.Sanphams.ToList();
            List<LoaiSP> listLoaiSP = studentmodeldb.LoaiSPs.ToList();
            filldgvSanpham(listSanpham);
            fillcboLoaiSP(listLoaiSP);
        }
        private void fillcboLoaiSP(List<LoaiSP> listLoaiSP)
        {
            cboLoaiSP.DataSource = listLoaiSP;
            //đặt tên hiển thị
            cboLoaiSP.DisplayMember = "TenLoai";
            //đặt tên xử lí 
            cboLoaiSP.SelectedItem = "Maloai";
        }

        private void filldgvSanpham(List<Sanpham> listSanpham)
        {
            dgvSanpham.Rows.Clear();//Xóa trắng bảng
            foreach (Sanpham student in listSanpham)
            {
                int newRows = dgvSanpham.Rows.Add();
                dgvSanpham.Rows[newRows].Cells[0].Value = student.MaSP;
                dgvSanpham.Rows[newRows].Cells[1].Value = student.TenSP;
                dgvSanpham.Rows[newRows].Cells[2].Value = student.NgayNhap;
                dgvSanpham.Rows[newRows].Cells[3].Value = student.LoaiSP;

            }
        }

        private void dgvSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvSanpham.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaSP.Text = dgvSanpham.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenSP.Text = dgvSanpham.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dtNgaynhap.Text = dgvSanpham.Rows[e.RowIndex].Cells[2].Value.ToString();

                    // Lấy mã loại từ đối tượng sản phẩm
                    cboLoaiSP.Text = dgvSanpham.Rows[e.RowIndex].Cells[3].Value.ToString();

                    // Tìm mục trong ComboBox theo mã loại và chọn mục đó

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng sinh viên mới từ các thông tin nhập
            Sanpham sanpham = new Sanpham()
            {
                MaSP = txtMaSP.Text,
                TenSP = txtTenSP.Text,
                MaLoai = (cboLoaiSP.SelectedItem as LoaiSP).Maloai,
                NgayNhap = dtNgaynhap.Value,
            };

            // Thêm vào database context
            studentmodeldb.Sanphams.Add(sanpham);

            // Lưu thay đổi vào cơ sở dữ liệu
            studentmodeldb.SaveChanges();

            // Cập nhật lại danh sách sinh viên trên giao diện
            filldgvSanpham(studentmodeldb.Sanphams.ToList());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaSP = txtMaSP.Text;
            Sanpham sanpham = studentmodeldb.Sanphams.FirstOrDefault(s => s.MaSP == MaSP);

            if (sanpham != null)
            {

                sanpham.TenSP = txtTenSP.Text;
                sanpham.MaLoai = (cboLoaiSP.SelectedItem as LoaiSP).Maloai;


                // Lưu thay đổi vào cơ sở dữ liệu
                studentmodeldb.SaveChanges();


                filldgvSanpham(studentmodeldb.Sanphams.ToList());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã sản phẩm từ textbox
            string MaSP = txtMaSP.Text;

            // Tìm sản phẩm cần xóa
            Sanpham sanpham = studentmodeldb.Sanphams.FirstOrDefault(s => s.MaSP == MaSP);

            if (sanpham != null)
            {
                // Xóa sản phẩm khỏi DbSet
                studentmodeldb.Sanphams.Remove(sanpham);

                // Lưu thay đổi vào cơ sở dữ liệu
                studentmodeldb.SaveChanges();

                // Cập nhật lại DataGridView sau khi xóa
                filldgvSanpham(studentmodeldb.Sanphams.ToList());

                // Xóa sạch các trường nhập liệu
                txtMaSP.Clear();
                txtTenSP.Clear();
                cboLoaiSP.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txttim.Text.Trim(); // Lấy từ khóa tìm kiếm từ TextBox

            // Tìm kiếm sản phẩm theo tên
            var searchResults = studentmodeldb.Sanphams
                .Where(s => s.TenSP.Contains(keyword)) // Sử dụng Contains để tìm kiếm
                .ToList();

            // Cập nhật DataGridView với kết quả tìm kiếm
            filldgvSanpham(searchResults);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            string MaSP = txtMaSP.Text;
            string TenSP = txtTenSP.Text;
            DateTime NgayNhap = dtNgaynhap.Value; // giả sử có DateTimePicker cho ngày nhập
            LoaiSP selectedLoaiSP = cboLoaiSP.SelectedItem as LoaiSP;

            // Kiểm tra xem mã sản phẩm đã tồn tại chưa
            Sanpham existingSanpham = studentmodeldb.Sanphams.FirstOrDefault(s => s.MaSP == MaSP);

            if (existingSanpham == null)
            {
                // Tạo mới sản phẩm nếu chưa có
                Sanpham newSanpham = new Sanpham
                {
                    MaSP = MaSP,
                    TenSP = TenSP,
                    NgayNhap = NgayNhap,
                    Maloai = selectedLoaiSP?.Maloai // Lấy mã loại sản phẩm từ ComboBox
                };

                // Thêm sản phẩm mới vào DbSet
                studentmodeldb.Sanphams.Add(newSanpham);

                // Lưu thay đổi vào cơ sở dữ liệu
                studentmodeldb.SaveChanges();

                // Cập nhật lại DataGridView sau khi lưu
                filldgvSanpham(studentmodeldb.Sanphams.ToList());

                // Xóa sạch các trường nhập liệu
                txtMaSP.Clear();
                txtTenSP.Clear();
                dtNgaynhap.Value = DateTime.Now;
                cboLoaiSP.SelectedIndex = -1;

                MessageBox.Show("Lưu sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}