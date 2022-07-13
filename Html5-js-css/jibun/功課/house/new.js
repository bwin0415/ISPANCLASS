function doFirst() {
    let canvas = document.getElementById('canvas');
    let context = canvas.getContext('2d');

    canvas.width = 1000
    canvas.height = 1000

    drawHouse();

    function drawHouse() {


        context.clearRect(0, 0, canvas.width, canvas.height);
        // 格線開始
        context.beginPath();
        for (let i = 0; i < 100; i++) {
            let interval = i * 50
            // 水平
            context.moveTo(0, interval);
            context.lineTo(canvas.width, interval);
            context.fillText(interval, 0, interval);

            // 垂直
            context.moveTo(interval, 0);
            context.lineTo(interval, canvas.height);
            context.fillText(interval, interval, 10);
        }
        context.strokeStyle = 'rgba(0,0,0,0.3)';
        context.stroke();


        //劃 一層
        context.beginPath();
        context.moveTo(125, 850);
        context.lineTo(175, 850);
        context.lineTo(200, 950);
        context.lineTo(100, 950);
        context.lineTo(125, 850);
        context.fill();
        context.closePath();
        //第一層配件;
        context.beginPath();
        context.fillStyle = 'white';
        context.fillRect(135, 900, 30, 10);
        context.closePath();
        context.beginPath();
        context.beginPath();
        context.arc(150, 870, 10, 0, 360, false);
        context.fill();
        context.closePath();
        //劃 二層
        let n = 9;
        let y = 30;
        for (let i = 0; i < n; i++) {
            context.beginPath();
            context.fillStyle = 'black';
            context.moveTo(125, (850 - y) - (i * y));
            context.lineTo(175, (850 - y) - (i * y));
            context.lineTo(165, 850 - (i * y));
            context.lineTo(135, 850 - (i * y));
            context.fill();
            context.closePath();
        }
    }
}
window.addEventListener('load', doFirst);