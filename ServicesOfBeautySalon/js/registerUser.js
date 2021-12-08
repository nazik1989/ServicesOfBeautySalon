
function preview_image(event) {
									var reader = new FileReader();
									reader.onload = function ()
									{
									var output = document.getElementById('output_image');
									output.src = reader.result;
									}
									reader.readAsDataURL(event.target.files[0]);
}

function showPSWCheckboxFunction()
{
	var x = document.getElementById("userPassword");
	if (x.type === "password") {
		x.type = "text";
	} else {
		x.type = "password";
	}
}
								
