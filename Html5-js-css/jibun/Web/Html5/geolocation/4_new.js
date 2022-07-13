function doFirst() {
    let area = document.getElementById("map");
    let position = new google.maps.LatLng(22.6282173, 120.2911991)
    let options = {
        zoom: 14,
        center: position,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    }
    let map = new google.maps.Map(area, options)
    let marker = new google.maps.Marker({
        position,
        map,
    })
    marker.setTitle('這是哪裡?')
    marker.setIcon('../../images/number/dgtp.gif')
    
}
window.addEventListener('load', doFirst)
