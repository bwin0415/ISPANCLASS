addEventListener('load', () => {
    //先跟html畫面產生關聯，再健事件聆聽功能

    let canvas = document.getElementById("canvas");
    let context = canvas.getContext("2d");
    // context.fillStyle = 'red';
    // context.strokeStyle = 'blue';
    // context.textBaseline='top | hanging | middle | alphabetic | ideographic | bottom';


    context.font = 'bold 50px Tahoma';

    // 第一個字
    context.fillText("omg", 100, 100);

    context.moveTo(100, 100);
    context.lineTo(400, 100);
    context.stroke();
    // 第二個字
    context.shadowColor = 'red';
    context.shadowOffsetX = 5;
    context.shadowOffsetY = 5;
    context.shadowBlur = 5;
    context.fillText("omg", 100, 250);
    
    // 第三個字 
    context.shadowColor = 'red';
    context.shadowOffsetX = 0;
    context.shadowOffsetY = 0;
    context.shadowBlur = 10;
    context.fillStyle='#fff';
    context.fillText("omg", 100, 400);
    
    // 第四個字 多重陰影
    context.fillText("omg", 100, 550);
    context.shadowColor = 'blue';
    context.shadowOffsetX = 0;
    context.shadowOffsetY = 0;
    context.shadowBlur = 10;
    context.fillStyle='#fff';
    context.fillText("omg", 100, 550);



    //橡皮擦
    //context.clearRect(0, 0, canvas.width, canvas.height);



})