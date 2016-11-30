using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GUI_Maker_ECManagement.Entity
{
    public class HocVien
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HocVienId { get; set; }
        [Key]
        public string MaHs { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string PhuHuynh { get; set; }
        public string DTPhuHuynh { get; set; }
        public string EmailPhuHuynh { get; set; }
        public string FaceBookPhuHuynh { get; set; }
        public string GhiChu { get; set; }
        [Required,ForeignKey("User.Id")]
        public int InputUserID { get; set; }
        [Required]
        public DateTime InputDate { get; set; }
        public string NhomHocVien { get; set; }
        public string TenTiengAnh { get; set; }
        public string NgayLienHe { get; set; }
    }
    
}
