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

    context.beginPath();
    context.strokeStyle = 'rgba(0,0,0,0.8)';
    context.moveTo(0, 400);
    context.lineTo(1000, 400);
    context.stroke();

    context.beginPath();
    context.strokeStyle = 'rgba(0,0,0,0.8)';
    context.moveTo(500, 0);
    context.lineTo(500, 800);
    context.stroke();

    context.font = 'bold 25px Courier New';
    context.fillText("arc()", 50, 50);
    context.fillText("arcTo()", 550, 50);
    context.fillText("quadraticCurveTo()", 50, 450);
    context.fillText("bezierCurveTo()", 550, 450);

    context.strokeStyle = 'darkblue';
    context.lineWidth = 5;

    //arc()
    context.beginPath();
    context.arc(250, 200, 150, 0.3 * Math.PI, Math.PI * 2, false);
    context.stroke();

    //arcTo
    context.beginPath();
    context.moveTo(600, 250);
    context.arcTo(750, 100, 850, 300, 100);
    context.stroke();
    //輔助線
    context.strokeStyle = 'red';
    context.lineWidth = 1;
    context.beginPath();
    context.moveTo(600, 250);
    context.lineTo(750, 100);
    context.lineTo(850, 300);
    context.stroke();
    // quadraticCurveTo -- 貝茲二次曲線
    context.strokeStyle = 'red';
    context.lineWidth = 5;

    context.beginPath();
    context.moveTo(100, 650);
    context.quadraticCurveTo(250, 500, 350, 700);
    context.stroke();

    // 輔助線
    context.strokeStyle = 'blue';
    context.lineWidth = 1;
    context.beginPath();
    context.moveTo(100, 650);
    context.lineTo(250, 500);
    context.lineTo(350, 700);
    context.stroke();


    //貝茲三次取縣

    context.strokeStyle = 'red';
    context.lineWidth = 5;

    context.beginPath();
    context.moveTo(600, 650);
    // context.bezierCurveTo(700, 500, 850, 450,950,700);
    context.bezierCurveTo(700, 500, 850, 800, 950, 700);
    context.stroke();

    // 輔助線
    context.strokeStyle = 'blue';
    context.lineWidth = 1;
    context.beginPath();
    context.moveTo(600, 650);
    context.lineTo(700, 500);
    // context.lineTo(850, 450);
    context.lineTo(850, 800);
    context.lineTo(950, 700);
    context.stroke();







})