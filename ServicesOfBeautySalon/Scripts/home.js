//function goToRegisterUserPage()
//{
//    window.location.href = "registerUser.html"
//}
function successFunction(resData) {

    document.getElementById("countOfServices").innerHTML = resData.ServicesCount + 500;
    document.getElementById("countOfBeautySalons").innerHTML = resData.BeautySalonsCount + 500;
    document.getElementById("countOfClients").innerHTML = resData.ClientCount + 500;
    document.getElementById("countOfMasters").innerHTML = resData.MastersCount + 500;

    function count($this) {

        var current = parseInt($this.html(), 10);
        current = current + 1; /* Where 1 is increment */

        $this.html(++current);
        if (current > $this.data('count')) {
            $this.html($this.data('count'));
        } else {
            setTimeout(function () { count($this) }, 5);
        }
    }

    $(".counter").each(function () {
        $(this).data('count', parseInt($(this).html(), 10));
        $(this).html('0');
        count($(this));
    });
}

function errorFunction(){ console.log("An error has occurred when trying to get serviceCount!"); }

$(() => {
    callAJAX(
        "GET",
        "http://localhost/beauty/Home/GetCountForHomePage",
        "application/json; charset=utf-8",
        { data: "yourdata" },
        "json",
        successFunction,
        errorFunction

    );
    //commonJSFunc();
})
