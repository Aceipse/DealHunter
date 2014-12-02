//As per request by Tjn
var toggle = true;
setInterval(function () {
	if (toggle) {
		$("#flash").css("background-color", "red");
	} else {
		$("#flash").css("background-color", "yellowgreen");
	}
	toggle = !toggle;
}, 300);