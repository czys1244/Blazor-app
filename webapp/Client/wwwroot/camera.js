﻿function camera() {
    player = document.getElementById('vid');
    const constraints = {
        video: true,
    };
    navigator.mediaDevices.getUserMedia(constraints).then((stream) => {
        player.srcObject = stream;
    });
}
