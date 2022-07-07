function doFirst() {
    // barsize = 636
    barsize = parseInt(window.getComputedStyle(defaultBar).width)
    // 先跟 HTML 畫面產生關聯
    myMovie = document.getElementById('myMovie');
    playButton = document.getElementById("playButton");
    defaultBar = document.getElementById("defaultBar");
    progress = document.getElementById("progress");
    //再建事件聆聽功能
    playButton.addEventListener('click', playOrPause)
    defaultBar.addEventListener('click', clickedBar)





    document.getElementById('fullButton').addEventListener("click", () => {
        myMovie.webkitEnterFullScreen()
    })
}
function playOrPause() {
    if (!myMovie.paused && !myMovie.ended) {//影片正在跑
        myMovie.pause();
        playButton.innerText = 'play'
    } else {
        myMovie.play()
        playButton.innerText = 'pause'
        setInterval(update, 300);
    }
}
function update() {
    if (!myMovie.ended) {
        let size = barsize / myMovie.duration * myMovie.currentTime
        progress.style.width = `${size}px`
    } else {
        progress.style.width = `0px`
        myMovie.currentTime = 0
        playButton.innerText = 'play'

    }
}
function clickedBar(e) {
    let mouseX = e.pageX - defaultBar.offsetLeft
    progress.style.width = `${mouseX}px`
    let newTime=mouseX/ (barsize / myMovie.duration)
    myMovie.currentTime=newTime
}
window.addEventListener('load', doFirst)