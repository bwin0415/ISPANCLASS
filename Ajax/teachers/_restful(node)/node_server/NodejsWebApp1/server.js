//1. 匯入Express套件
var express = require("express");
//2. Creates an Express application.
var app = express();
//4. 設定伺服器擬監聽的連線埠號
app.listen(1337, function () { console.log("Server listening on port 1337"); });//Binds and listens for connections on the specified port.
//5. 記得以UTF-5之字元編碼存檔
//----------------------------------------------------------------------------------//

//6. 匯入cors套件以支援CORS政策
var cors = require('cors');
app.use(cors());
//cors()回傳一個中介軟體函式，該函式會處理跨來源的HTTP請求，在回應的訊息中預設添加下列標頭：
//Access-Control-Allow-Origin: *
//Access-Control-Allow-Methods: GET, HEAD, PUT, PATCH, POST, DELETE
//----------------------------------------------------------------------------------//

//3. 設定路由(Routing)
//----------------------------------------------------------------------------------//
app.get('/', function (req, res, next) {
    res.send('<h1 style="text-align:center;">Express Web Server 運作中...</h1>');
    next();
});

//查詢所有員工
app.get('/api/employees/', function (req, res, next) {    
    res.send(employees);
});
//查詢指定員工
app.get('/api/employees/:id', function (req, res, next) {
    var emp = employees.find(function (value, index) {
        return value.員工編號 == req.params.id;
    });
    //arr.find(callback) 方法會對每個元素執行一次 callback 函式，直到找到一個讓 callback 函式回傳 true 的元素。
    //當元素被找到的時候，find 會立刻回傳該元素，否則 find 會回傳 undefined。
    if (emp == undefined)
        emp = null;
    res.writeHead(200, { 'content-type': 'application/json;charset=utf-8' });
    res.end(JSON.stringify(emp));
});
//新增
app.post('/api/employees', function (req, res, next) {
    try {
        let emp = {
            "員工編號": req.query.employeeid,
            "名字": req.query.firstname,
            "姓氏": req.query.lastname,
            "職稱": req.query.title,
            "生日": req.query.birthdate,
            "到職日": req.query.hiredate,
            "地址-街道": req.query.address,
            "地址-市鎮": req.query.city
        }
        employees.push(emp);
        res.send({ "insert-status": "success" });
    }
    catch (ex) {
        res.send({ "insert-status": "fail" });
    } 
});
//修改
app.put('/api/employees/:id', function (req, res, next) {
    try {
        var emp = employees.find(function (value, index) {
            return value.員工編號 == req.params.id;
        });
        if (emp) {
            emp["員工編號"] = req.params.id;
            emp["名字"] = req.query.firstname;
            emp["姓氏"] = req.query.lastname;
            emp["職稱"] = req.query.title;
            emp["生日"] = req.query.birthdate;
            emp["到職日"] = req.query.hiredate;
            emp["地址-街道"] = req.query.address;
            emp["地址-市鎮"] = req.query.city; 
            res.send({ "update-status": "success" });
        }
        else 
            res.send({ "update-status": "fail" });
    }
    catch (ex) {
        res.send({ "update-status": "fail" });
    }
});
//----------------------------------------------------------------------------------/
//定義資料來源
let employees =
    [
        {
            "員工編號": "1", "名字": "Nancy", "姓氏": "Davolio", "職稱": "Sales Representative",
            "生日": "1948-12-08", "到職日": "1992-05-01", "地址-街道": "507 - 20th Ave. E. Apt. 2A", "地址-市鎮": "Seattle"
        },

        {
            "員工編號": "2", "名字": "Andrew", "姓氏": "Fuller", "職稱": "Vice President, Sales",
            "生日": "1952-02-19", "到職日": "1992-08-14", "地址-街道": "908 W. Capital Way", "地址-市鎮": "Tacoma"
        },
        {
            "員工編號": "3", "名字": "Janet", "姓氏": "Leverling", "職稱": "Sales Representative",
            "生日": "1963-08-30", "到職日": "1992-04-01", "地址-街道": "722 Moss Bay Blvd.", "地址-市鎮": "Kirkland"
        },
        {
            "員工編號": "4", "名字": "Margaret", "姓氏": "Peacock", "職稱": "Sales Representative",
            "生日": "1937-09-19", "到職日": "1993-05-03", "地址-街道": "4110 Old Redmond Rd.", "地址-市鎮": "Redmond"
        },
        {
            "員工編號": "5", "名字": "Steven", "姓氏": "Buchanan", "職稱": "Sales Manager",
            "生日": "1955-03-04", "到職日": "1993-10-17", "地址-街道": "14 Garrett Hill", "地址-市鎮": "London"
        },
        {
            "員工編號": "6", "名字": "Michael", "姓氏": "Suyama", "職稱": "Sales Representative",
            "生日": "1963-07-02", "到職日": "1993-10-17", "地址-街道": "Coventry House Miner Rd.", "地址-市鎮": "London"
        },
        {
            "員工編號": "7", "名字": "Robert", "姓氏": "King", "職稱": "Sales Representative",
            "生日": "2015-03-11", "到職日": "1994-01-02", "地址-街道": "Edgeham Hollow Winchester Way", "地址-市鎮": "London"
        },
        {
            "員工編號": "8", "名字": "Laura", "姓氏": "Callahan", "職稱": "Inside Sales Coordinator",
            "生日": "2015-03-19", "到職日": "1994-03-05", "地址-街道": "4726 - 11th Ave. N.E.", "地址-市鎮": "Seattle"
        },
        {
            "員工編號": "9", "名字": "anne", "姓氏": "Dodsworth", "職稱": "Sales Representative",
            "生日": "2015-03-04", "到職日": "1994-11-15", "地址-街道": "7 Houndstooth Rd.", "地址-市鎮": "London"
        }
    ];
//let empColName = ["員工編號", "名字", "姓氏", "職稱", "生日", "到職日", "地址-街道", "地址-市鎮"];
//----------------------------------------------------------------------------------/