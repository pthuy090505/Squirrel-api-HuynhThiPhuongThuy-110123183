var builder = WebApplication.CreateBuilder(args);

// Khai báo dịch vụ để hệ thống tự quét nhận diện TransactionController
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();
app.UseAuthorization();

// Khớp nối các đường dẫn API định nghĩa trong Controller
app.MapControllers();

// Khởi chạy ứng dụng Web API
app.Run();