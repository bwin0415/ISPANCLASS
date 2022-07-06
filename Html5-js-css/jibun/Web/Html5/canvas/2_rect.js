addEventListener('load', () => {
    //先跟html畫面產生關聯，再健事件聆聽功能

    let canvas = document.getElementById("canvas");
    let context = canvas.getContext("2d");
    context.fillStyle='red';
    context.strokeStyle='blue';
    
    
    
    context.fillRect(100, 100, 300, 200);
    context.clearRect(150, 150, 50, 50);


    context.rect(700, 500, 300, 300);
    context.stroke();




    //橡皮擦
    // context.clearRect(0, 0, canvas.width, canvas.height);



})