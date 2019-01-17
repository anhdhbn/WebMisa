$(document).ready(function () {
    var userID = getUrlVars['id'];
    if (userID != "") {
        localStorage.setItem("UserID", userID);
    } else {
        userID = localStorage.getItem("UserID");
    }

})
var indexJS = Object.create({
    loadData: function (id) {
        $("#avatar").attr("src", loadAvatarURL(id));
    }
})
function getUrlVars() {
    var vars = {};
    var parts = window.location.href.replace(/[?&]+([^=&]+)=([^&]*)/gi, function (m, key, value) {
        vars[key] = value;
    });
    return vars;
}
function loadDisplayName(id) {
    $.ajax({
        method: "GET",
        url: "/api/user?id=" + id + "&getName=true",
        success: function (response) {
            return response;
        },
        fail: function (response) {
            return "";
        }
    })
}
function loadAvatarURL(id) {
    $.ajax({
        method: "GET",
        url: "/api/user?id=" + id + "&getAvatar=true",
        success: function (response) {
            if (response == "") {
                return "default.jpeg";
            }
            return response;
        },
        fail: function (response) {
            return "default.jpeg";
        }
    })
}