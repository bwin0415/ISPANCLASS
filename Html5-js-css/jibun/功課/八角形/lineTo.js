addEventListener('load', () => {
    //先跟html畫面產生關聯，再健事件聆聽功能

    let canvas = document.getElementById("canvas");
    context = canvas.getContext("2d");
    //格線功能
    // context.beginPath();
    // for (let index = 0; index < 100; index++) {
    //     let interval = index * 50;
    //     //水平
    //     context.moveTo(0, interval);
    //     context.lineTo(canvas.width, interval);
    //     context.fillText(interval, 0, interval);


    //     //垂直
    //     context.moveTo(interval, 0);
    //     context.lineTo(interval, canvas.height);
    //     context.fillText(interval, interval, 10);
    // }
    // context.strokeStyle = "rgba(0,0,0,0.3)";
    // context.stroke();
    context.beginPath();
    drawStar(550,400,8,300,90)
    // drawStar(0,0,8,0,90)
    function drawStar(x,y,n,R,r) {
    context.beginPath();
    context.translate(x,y);  
    for(let i=0;i<n;i++){  
    context.lineTo(Math.cos(((1/4 + i)*2*Math.PI/n))*R,-Math.sin(((1/4 + i)*2*Math.PI/n))*R);  //外圈
    context.lineTo(Math.cos(((3/4 + i)*2*Math.PI/n))*r,-Math.sin(((3/4 + i)*2*Math.PI/n))*r);  //內圈
    }
    context.closePath();  
    context.stroke();  
    context.restore();    
}

})