function GetTest() {
    $.ajax({
        type: "POST",
        url: window.location.origin + "/Home/PostTest",
        data: JSON.stringify(),
        contentType: "application/json; charset=utf-8",
        Accept: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            alert(data);
        }
    });
}


function CheckAddress() {
    code = "123-123-123";
    $.ajax({
        type: "POST",
        url: window.location.origin + "/Home/CheckAddress",
        data: JSON.stringify(code),
        contentType: "application/json; charset=utf-8",
        Accept: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            alert(data);
        }
    });
}