//Shorthand for $( document ).ready()
$(function() {
	//Iframe
	$("#iframeBtn").click(function () {
		console.log("inside click iframe");
		var userUrl = $("#iframeUrl").val();
		console.log(userUrl);
		$("#iframe").attr("src", userUrl);
	});

	$("#findPriceBtn").click(function() {
		var price = $("#iframe").contents().find("span[itemprop=price]").val().trim();
		$("#foundPriceInput").val(price);
	});

//As per request by Tjn
	var toggle = true;
	setInterval(function() {
		if (toggle) {
			$("#flash").css("background-color", "red");
		} else {
			$("#flash").css("background-color", "yellowgreen");
		}
		toggle = !toggle;
	}, 300);
});