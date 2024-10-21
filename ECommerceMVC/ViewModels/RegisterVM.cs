using ECommerceMVC.Data;
using System.ComponentModel.DataAnnotations;

namespace ECommerceMVC.ViewModels
{
    public class RegisterVM
    {
        [Display(Name ="Ten dang nhap")]
        [Required(ErrorMessage="*")]
        [MaxLength(20, ErrorMessage="Tối đa 20 kí tự")]
        public string MaKh { get; set; } = null!;

        [Required(ErrorMessage = "*")]
        [Display(Name ="Mat khau")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }

        [Display(Name = "Ho ten")]
        [Required(ErrorMessage = "*")]
        [MaxLength(50, ErrorMessage = "Tối đa 50 kí tự")]
        public string HoTen { get; set; } = null!;

        public bool GioiTinh { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime? NgaySinh { get; set; }

        [Display(Name = "Địa chỉ")]
        [MaxLength(60, ErrorMessage = "Tối đa 60 kí tự")]
        public string DiaChi { get; set; }

        [Display(Name = "Điện thoại")]
        [MaxLength(24, ErrorMessage = "Tối đa 24 kí tự")]
        [RegularExpression(@"0[98753]\d{8}", ErrorMessage ="Chưa đúng định dạng số VN")]
        public string DienThoai { get; set; }
        [EmailAddress(ErrorMessage ="Chưa đúng định dạng email")]
        public string Email { get; set; } = null!;

        public string? Hinh { get; set; }

    }
}
