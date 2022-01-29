$(() => { });

function commonJSFunc() { console.log("Function in common.js") }

function callAJAX(methodType, url, requestContentType, requestData, responseDataType, successFunction, errorFunction)
{
    $.ajax({
        type : methodType,
        url : url,
        contentType : requestContentType,
        data : requestData,
        dataType : responseDataType,
        success : successFunction,
        error : errorFunction
    })
}

function postForm(selector, url, successFunction, errorFunction)
{
    $.ajax({
        type : "POST",
        url : url,
        data : $(selector).serialize(),
        success: successFunction,
        error : errorFunction
    })
}

//$.ajax({
//    type: "GET",
//    url: '@Url.Action("GetCountForHomePage", "Home")',
//    contentType: "application/json; charset=utf-8",
//    data: { data: "yourdata" },
//    dataType: "json",
//    success: function (resData) {

//        document.getElementById("countOfServices").innerHTML = resData.ServicesCount + 500;
//        document.getElementById("countOfBeautySalons").innerHTML = resData.BeautySalonsCount + 500;
//        document.getElementById("countOfClients").innerHTML = resData.ClientCount + 500;
//        document.getElementById("countOfMasters").innerHTML = resData.MastersCount + 500;

//        function count($this) {

//            var current = parseInt($this.html(), 10);
//            current = current + 1; /* Where 1 is increment */

//            $this.html(++current);
//            if (current > $this.data('count')) {
//                $this.html($this.data('count'));
//            } else {
//                setTimeout(function () { count($this) }, 5);
//            }
//        }

//        $(".counter").each(function () {
//            $(this).data('count', parseInt($(this).html(), 10));
//            $(this).html('0');
//            count($(this));
//        });
//    },
//    error: function () { Console.log("An error has occurred when trying to get serviceCount!"); }
//});

