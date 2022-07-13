//1. 匯入Express套件
var express = require("express");
//2. Creates an Express application.
var app = express();
//3. 設定路由(Routing)
app.get("/", function (req, res) {
    res.send("Hello World 哈囉世界...");
});
//app.get(path, callback)：
//設定「“GET”HTTP方法 + “根”路由路徑」的請求由指定的callback函式來處理。
//Express稱上述callback函式為「中介軟體函式(Middleware Functions)」。 

//4. 設定伺服器擬監聽的連線埠號
app.listen(1337, function () { console.log("Server listening on port 1337"); });
//5. 記得以UTF-5之字元編碼存檔
