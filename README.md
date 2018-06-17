# Getting Started
```
// create new solution
dotnet new sln``` 
โครงสร้างของ Dotnet เรียกว่า Solution ซึ่งจะเก็บแต่ละส่วนแยกกัน เช่น  
api ก็จะสร้าง project คลุมไว้
unit test ก็จะสร้างอีก project คลุมไว้
```
// สร้าง api project สำหรับจัดการ code 
dotnet new console -n api -o src/api
// สร้าง api.Unittest สำหรับจัดการ test เพื่อทดสอบ api project
dotnet new xunit -n api.Unittest -o test/api.Unittest
```
แล้วใช้ solution เป็นตัวเชื่อม
```
// เชื่อม project เข้ากับ solution
dotnet sln add src/api/api.csproj
dotnet sln add test/api.Unittest/api.Unittest.csproj
// ลอง list ดูว่ามี project อะไรอยู่ใน solution บ้าง
dotnet list 
```

เริ่มเขียน unittest แต่ต้องเชื่อม reference กับ source code 
```
cd test/api.Unittest
dotnet add reference ../../src/api/api.csproj
```
รัน test
```
dotnet test
```