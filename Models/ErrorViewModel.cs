namespace TDTBaiThiLai.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    //Sử dụng code first (xây dựng class trước, từ class sinh ra CSDL) để ánh xạ các class vào CSDL
//Chạy lệnh dotnet ef migrations add Create_table_Person

//Chạy lệnh dotnet ef database update để cập nhật cơ sở dữ liệu
//* sinh mã tự động 
//dotnet aspnet-codegenerator controller -name EmployeeController -m Employee -dc MvcMovie.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
// 
}
