# 📱 Website Bán Điện Thoại - ASP.NET Core MVC

Hệ thống website thương mại điện tử chuyên doanh điện thoại di động, được xây dựng trên nền tảng .NET 8/9 với đầy đủ các tính năng từ quản lý sản phẩm đến thanh toán trực tuyến.

---

## 🚀 Tính năng nổi bật

### 👤 Người dùng (Customer)
* **Đăng nhập đa phương thức:** Hỗ trợ đăng ký hệ thống, đăng nhập qua Google và Facebook.
* **Mua sắm thông minh:** Tìm kiếm sản phẩm, lọc theo thương hiệu/danh mục.
* **Giỏ hàng & Thanh toán:** Quản lý giỏ hàng trực quan, tích hợp thanh toán qua **Ví MoMo**.
* **Tương tác:** Đánh giá sản phẩm (Rating) và để lại bình luận.

### 🛠 Quản trị (Admin/Employer)
* **Dashboard:** Thống kê và quản lý tổng quan.
* **Quản lý sản phẩm:** Thêm, sửa, xóa sản phẩm, quản lý kho hàng và hình ảnh.
* **Quản lý đơn hàng:** Tiếp nhận, xử lý và cập nhật trạng thái đơn hàng của khách.
* **Danh mục & Thương hiệu:** Quản lý hệ thống phân loại linh hoạt.

---

## 🛠 Công nghệ sử dụng

* **Backend:** ASP.NET Core MVC (.NET 8/9)
* **Database:** SQL Server với Entity Framework Core (Code First)
* **Identity:** Microsoft Identity Framework
* **Thanh toán:** MoMo API Payment SDK
* **Giao diện:** HTML5, CSS3, Bootstrap, Razor View Engine, FontAwesome
* **Kiến trúc:** Repository Pattern, Dependency Injection

---

## 📁 Cấu trúc Project chính

* `Controllers/`: Xử lý điều hướng và logic điều khiển.
* `Models/`: Chứa các thực thể dữ liệu (Product, Order, Category...).
* `Repositories/`: Lớp trừu tượng tương tác với Database.
* `Services/`: Xử lý các logic nghiệp vụ phức tạp (Payment, Image...).
* `Areas/`: Phân chia khu vực quản lý riêng cho Admin.
* `wwwroot/`: Chứa các tài nguyên tĩnh (CSS, JS, Images sản phẩm).

---

## ⚙️ Hướng dẫn cài đặt

1.  **Clone project:**
    ```bash
    git clone [https://github.com/Hoangphuc187/Website-Selling-Phones.git](https://github.com/Hoangphuc187/Website-Selling-Phones.git)
    ```
2.  **Cấu hình Database:**
    Mở file `appsettings.json`, thay đổi `DefaultConnection` phù hợp với SQL Server của bạn.
3.  **Update Database:**
    Mở *Package Manager Console* và chạy lệnh:
    ```powershell
    Update-Database
    ```
4.  **Chạy ứng dụng:** Nhấn `F5` trong Visual Studio.

---

## 👤 Minh Họa
<img width="1910" height="1034" alt="Ảnh chụp màn hình 2026-03-11 152019" src="https://github.com/user-attachments/assets/23f4f0b6-bb40-43af-a938-292767a2c952" />
<img width="1919" height="1055" alt="Ảnh chụp màn hình 2026-03-11 152028" src="https://github.com/user-attachments/assets/1ace1528-7ef1-465d-a15a-605c5f6c75bc" />

