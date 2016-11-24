using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Maker_ECManagement.Entity
{
    class HocVien
    {
        private int id;
        private string maHS;
        private string hoTen;
        private bool gioiTinh;
        private string diaChi;
        private string phuHuynh;
        private string dtPhuHuynh;
        private string emailPhuHuynh;
        private string faceBookPhuHuynh;
        private string ghiChu;
        private string inputUser;
        private DateTime inputDate;
        private string nhomHocVien;
        private string tenTiengAnh;
        private DateTime ngayLienHe;
        private string classID;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string MaHS
        {
            get
            {
                return maHS;
            }

            set
            {
                maHS = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public bool GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string PhuHuynh
        {
            get
            {
                return phuHuynh;
            }

            set
            {
                phuHuynh = value;
            }
        }

        public string DtPhuHuynh
        {
            get
            {
                return dtPhuHuynh;
            }

            set
            {
                dtPhuHuynh = value;
            }
        }

        public string EmailPhuHuynh
        {
            get
            {
                return emailPhuHuynh;
            }

            set
            {
                emailPhuHuynh = value;
            }
        }

        public string FaceBookPhuHuynh
        {
            get
            {
                return faceBookPhuHuynh;
            }

            set
            {
                faceBookPhuHuynh = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public string InputUser
        {
            get
            {
                return inputUser;
            }

            set
            {
                inputUser = value;
            }
        }

        public DateTime InputDate
        {
            get
            {
                return inputDate;
            }

            set
            {
                inputDate = value;
            }
        }

        public string NhomHocVien
        {
            get
            {
                return nhomHocVien;
            }

            set
            {
                nhomHocVien = value;
            }
        }

        public string TenTiengAnh
        {
            get
            {
                return tenTiengAnh;
            }

            set
            {
                tenTiengAnh = value;
            }
        }

        public DateTime NgayLienHe
        {
            get
            {
                return ngayLienHe;
            }

            set
            {
                ngayLienHe = value;
            }
        }

        public string ClassID
        {
            get
            {
                return classID;
            }

            set
            {
                classID = value;
            }
        }
    }
}
