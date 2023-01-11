function memory() {
    document.getElementById('memory').innerHTML = ("Memory: ~" + navigator.deviceMemory + " GiB") || 'unknown';
}

