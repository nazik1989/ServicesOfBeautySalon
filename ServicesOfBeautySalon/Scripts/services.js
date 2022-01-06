
function servicesInServiceType(id) {
//{
//    $("button").click(function () {

//    });
    var serviceType = document.getElementById(id).getElementsByTagName('h4')[0].innerText;
    var servicesDiv = document.getElementById("servicesinChoosenServiceType");

    while (servicesDiv.firstChild)
        {
            servicesDiv.removeChild(servicesDiv.firstChild);
        }

$.ajax({
    url: "~/serviceType/demo_test.txt", success: function (result) {
        $("#div1").html(result);
    }
});
        for (i = 0; i < 10; i++)
        {
            var oneServiceDiv = document.createElement('div');
            var buttonRegisterToService = document.createElement('button');

            oneServiceDiv.innerHTML = serviceType + " " + i + "        ";
            servicesDiv.appendChild(oneServiceDiv);
            oneServiceDiv.setAttribute("class", "currentServiceDiv");

            oneServiceDiv.appendChild(buttonRegisterToService);
            buttonRegisterToService.setAttribute("class", "ButtonRigisterService");
            //buttonRegisterToService.setAttribute("href", "registerToService.html");


        }

}