//if (!localStorage.getItem("UserID")) {
//    location.href = "/Html/loginAmis.html";
//}
$(document).ready(function () {
    var userID = localStorage.getItem("UserID");
    indexJS.loadUserData(userID);
    indexJS.loadNotification(userID);
})
var indexJS = Object.create({
    loadUserData: function (id) {
        loadAvatarURL(id);
        loadDisplayName(id);
    },
    loadNotification: function (id) {
        loadSystemNotification(id);
    }
})

function loadDisplayName(id) {
    $.ajax({
        method: "GET",
        url: "/user/name/" + id,
        success: function (response) {
            
        },
        fail: function (response) {
            
        }
    });
}
function loadAvatarURL(id) {
    $.ajax({
        method: "GET",
        url: "/user/image/" + id,
        success: function (response) {
            if (response) {
                $("#person-photo").attr("src", response);
            }
            else {
                $("#person-photo").attr("src", "/Content/Image/default.jpeg");
            }
        },
        error: function (response) {
            $("#person-photo").attr("src", "/Content/Image/default.jpeg");
        }
    });
}
function loadSystemNotification(id) {
    $.ajax({
        method: "GET",
        url: "/notify/global/" + id,
        success: function (response) {
            if (response.length > 0) {
                var htmlElement = "";
                htmlElement += '<div class="title_chung">' +
                    '<div class="row">' +
                    '<img src="/Content/Image/annoucement.png" height="27px" />' +
                    '<div id="text_chung"> <b>THÔNG BÁO</b></div>' +
                    '</div></div>';
                response.each(function (item, index) {
                    htmlElement += '<div class="content">' +
                        '<div class="notify-item">' + item.ContentNotification +
                        '</div></div>';
                });
                $('.module-box').prepend(htmlElement);
            }
        },
        fail: function (response) {

        }
    });
}