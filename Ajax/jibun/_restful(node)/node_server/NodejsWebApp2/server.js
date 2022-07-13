let express = require("express");
let app = express();
app.listen(1337, function () {
    console.log("Express Server is listening on port 1337....")
})

//設定routing(method +path=>route)
app.get("/api/greeting", function (req, res) {
    res.send("<h1>歡迎光臨</h1>")
})

app.get("/api/greeting", function (req, res) {
    res.send("<h1>歡迎光臨</h1>")
})