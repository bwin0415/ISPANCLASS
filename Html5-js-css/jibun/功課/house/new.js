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
        context.beginPath();
        context.fillRect(135, 570, 30, 10);
        context.fillRect(140, 560, 20, 10);
        context.beginPath();
        context.moveTo(145, 560);
        context.lineTo(155, 560);
        context.lineTo(158, 540);
        context.lineTo(142, 540);
        context.fill();
        context.closePath();
        context.beginPath();
        context.moveTo(145, 540);
        context.lineTo(155, 540);
        context.lineTo(155, 520);
        context.lineTo(150, 500);
        context.lineTo(145, 520);
        context.fill();
        context.closePath();
        context.beginPath();
        context.lineWidth = 5;
        context.strokeStyle = 'black';

        //聖家堂
        context.moveTo(250, 950);
        context.lineTo(650, 950);
        context.lineTo(630, 930);
        context.quadraticCurveTo(635, 700, 630, 600);
        context.lineTo(620, 550);
        context.lineTo(610, 600);
        context.quadraticCurveTo(605, 600, 610, 920);
        context.lineTo(580, 900);
        context.quadraticCurveTo(585, 725, 580, 550);
        context.lineTo(570, 500);
        context.lineTo(560, 550);
        context.quadraticCurveTo(548, 725, 550, 870);
        context.lineTo(515, 850);
        context.lineTo(515, 750);
        context.lineTo(450, 700);
        context.lineTo(385, 750);
        context.lineTo(385, 850);
        context.lineTo(350, 870);
        context.quadraticCurveTo(355, 725, 350, 550);
        context.lineTo(340, 500);
        context.lineTo(330, 550);
        context.quadraticCurveTo(320, 725, 320, 900);
        context.lineTo(300, 920);
        context.quadraticCurveTo(300, 725, 300, 600);
        context.lineTo(285, 550);
        context.lineTo(275, 600);
        context.quadraticCurveTo(275, 725, 275, 930);
        context.closePath();


        context.fill();
        context.fillStyle = 'white';
        context.beginPath();
        context.moveTo(274, 948);
        context.lineTo(300, 925);
        context.lineTo(300, 948);
        context.lineTo(274, 948);
        context.closePath();
        context.fill();
    }

}
window.addEventListener('load', doFirst);