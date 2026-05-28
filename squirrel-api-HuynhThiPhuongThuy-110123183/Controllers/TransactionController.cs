using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace squirrel_api_hoten_mssv.Controllers
{
    [ApiController]
    [Route("api/giaodich")] // Đường dẫn để gọi API
    public class TransactionController : ControllerBase
    {
        // Khởi tạo cứng danh sách dữ liệu gồm 5 dòng giao dịch theo đề bài
        private static List<Transaction> _transactions = new List<Transaction>()
        {
            new Transaction { Id = 1, SoTaiKhoan = "102345678", SoTien = 500000, LoaiGiaoDich = "Nap tien" },
            new Transaction { Id = 2, SoTaiKhoan = "102345678", SoTien = 200000, LoaiGiaoDich = "Rut tien" },
            new Transaction { Id = 3, SoTaiKhoan = "109876543", SoTien = 1000000, LoaiGiaoDich = "Nap tien" },
            new Transaction { Id = 4, SoTaiKhoan = "109876543", SoTien = 150000, LoaiGiaoDich = "Rut tien" },
            new Transaction { Id = 5, SoTaiKhoan = "105556667", SoTien = 300000, LoaiGiaoDich = "Nap tien" }
        };

        // Phương thức GET để xuất ra danh sách giao dịch "Nap tien"
        [HttpGet]
        public ActionResult<IEnumerable<Transaction>> GetNapTienTransactions()
        {
            var result = _transactions.Where(t => t.LoaiGiaoDich == "Nap tien").ToList();
            return Ok(result); // Trả về mã lỗi 200 OK kèm chuỗi JSON
        }
    }
}