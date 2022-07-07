addEventListener('load', () => {
    //先跟html畫面產生關聯，再健事件聆聽功能

    let canvas = document.getElementById("canvas");
    context = canvas.getContext("2d");
    //格線功能
    context.beginPath();
    for (let index = 0; index < 100; index++) {
        let interval = index * 50;
        //水平
        context.moveTo(0, interval);
        context.lineTo(canvas.width, interval);
        context.fillText(interval, 0, interval);


        //垂直
        context.moveTo(interval, 0);
        context.lineTo(interval, canvas.height);
        context.fillText(interval, interval, 10);
    }
    context.strokeStyle = "rgba(0,0,0,0.3)";
    context.stroke();

    context.lineWidth = 20;
    context.strokeStyle = 'red';
    let gradient = context.createLinearGradient(100, 250, 600, 250);
    gradient.addColorStop(0, 'red');
    gradient.addColorStop(0.1, 'orange');
    gradient.addColorStop(0.2, 'yellow');
    gradient.addColorStop(0.3, 'green');
    gradient.addColorStop(0.4, 'blue');

    gradient.addColorStop(1, 'purple');




    context.beginPath();
    context.fillStyle = gradient
    context.fillRect(100, 100, 500, 300);

})