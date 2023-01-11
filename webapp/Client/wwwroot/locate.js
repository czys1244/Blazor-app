function locate() {
    navigator.geolocation.getCurrentPosition(showGeolocation);
}
function showGeolocation(position) {
    var x = document.getElementById("target");
    x.innerHTML = "Latitude: " + position.coords.latitude +
        "<br>Longitude: " + position.coords.longitude;
}