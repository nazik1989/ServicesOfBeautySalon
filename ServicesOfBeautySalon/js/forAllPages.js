// JavaScript source code
function goMasterPage(id)
{

    var masterName = document.getElementById(id).getElementsByTagName('h3')[0].innerText;
    localStorage.setItem("masterNameinLocal", masterName);

    
   
    window.location.href = 'userAccount.html';

    var div = document.getElementById("specialMasterName");

    div.innerHTML = localStorage.getItem("masterNameinLocal")+"OK" +"kkkkkkkkkkkk"; 

}


function goBeautySalonPage(id)
{
    sessionStorage.setItem("beautySalonID", id);

    var beautySalonName = document.getElementById(sessionStorage.getItem("beautySalonID")).getElementsByTagName('h4')[0].innerText;
    sessionStorage.setItem("beautySalonNameinLocal", beautySalonName);

    var redirectWindow = window.open('beautySalonAccount.html', '_blank');
    redirectWindow.location;

    var div = document.getElementById("specialBeautySalonName");
    var oneChildDiv = document.createElement('div');
    oneChildDiv.innerHTML = sessionStorage.getItem("beautySalonNameinLocal") + "8888888888888 ";
    div.appendChild(oneChildDiv);


}