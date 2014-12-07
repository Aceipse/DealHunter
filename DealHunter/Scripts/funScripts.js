//Shorthand for $( document ).ready()
$(function () {
	
	//Clicking on button sends the URL to the controller, which gets the raw html
	$("#iframeBtn").click(function () {
		//User inputted URL
		var userUrl = $("#iframeUrl").val();

		//HomeController/GetHtml expects a string named "url"
		var asMsg = { "url": userUrl };

		//Asynchounous call to HomeController/GetHtml
		$.ajax({
			type: "GET",
			url: "Home/GetHtml",
			data: asMsg,		//we're sending this to controller
			dataType: "text",	//we're expecting text as answer (html)
			//Upon completion, run this function, data is returned value from controller
			complete: function (data) {

				//http://softwareas.com/injecting-html-into-an-iframe/
				//Find iframe, take 0 element to get non-jquery
				var iframe = $("#iframe")[0];
				var doc = iframe.document;
				if (iframe.contentDocument) {
					doc = iframe.contentDocument; // For NS6
				} else if (iframe.contentWindow) {
					doc = iframe.contentWindow.document; // For IE5.5 and IE6
				}
				// Put the content in the iframe
				doc.open();
				doc.writeln(data.responseText);
				doc.close();
			},
			error: function () {
				console.log("ajax failed");
			}
		});
	});

    //This strategy has to change depending on the url, this works for komplett
	$("#findPriceBtn").click(function () {
	    var iframe = $("#iframe").contents();
	    //Find the price
	    var price = iframe.find("span[itemprop=price]").text();
	    var priceFormatted = parseFloat(price.replace(".", ""));
	    console.log(priceFormatted);

	    var name = iframe.find("h1[itemprop=name]").text();
	    console.log(name);
	    //Put it into the input
	    $("#foundPriceInput").val(priceFormatted);
	    $("#foundNameInput").val(name);
	});

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
});