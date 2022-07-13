addEventListener('load', () => {
    //先跟html畫面產生關聯，再健事件聆聽功能

    let canvas = document.getElementById("canvas");
    context = canvas.getContext("2d");
    theClock = 0;
    setInterval(A,)
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
    context.lineWidth = 15;
    context.strokeStyle = 'red';
    let gradient = context.createRadialGradient(350, 250, 70, 260, 250, 180);

    gradient.addColorStop(0, 'red');
    gradient.addColorStop(1, 'purple');

    context.beginPath();
    context.fillStyle = gradient
    context.fillRect(100, 100, 500, 300);
    function A() {
        theClock++





        let radius = 150;
        context.translate(250, 600);


        let circleGradient = context.createRadialGradient(0, 0, radius * 0.95, 0, 0, radius * 1.05);
        circleGradient.addColorStop(0, '#FFDF00');
        circleGradient.addColorStop(0.5, '#fff');
        circleGradient.addColorStop(1, '#FFDF00');
        context.strokeStyle = circleGradient;

        context.beginPath();
        context.arc(0, 0, radius, 0, Math.PI * 2);
        context.stroke();
        context.rotate(Math.PI / 4 * theClock);

        context.translate(-250, -600);
    }
})