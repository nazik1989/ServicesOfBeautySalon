function previewBeautySalonImage(event) {
	document.getElementById("labelForImage").style.display = "none";
	var reader = new FileReader();
	reader.onload = function () {
		document.getElementById('outputBeautySalonImage').setAttribute("style", "width:100px");
		var output = document.getElementById('outputBeautySalonImage');
		output.src = reader.result;
	}
	reader.readAsDataURL(event.target.files[0]);
}

function showAdminPSWCheckboxFunction() {
	var x = document.getElementById("superAdminPassword");
	if (x.type === "password") {
		x.type = "text";
	} else {
		x.type = "password";
	}
}
