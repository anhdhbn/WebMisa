if (localStorage.getItem("UserID")) {
    location.href = "/Html/index.html";
}
$(document).ready(function () {
    $("#login").click(checkUserInfo);
});
function checkUserInfo() {
    var username = $("#username").val();
    var password = $("#password").val();
    $.ajax({
        method: "GET",
        url: "/login?userName=" + username.toString() + "&password=" + password,
        success: function (response) {
            if (response) {
                localStorage.setItem("UserID", response);
                location.href = "/Html/index.html";
            } else {
                alert("Tên đăng nhập hoặc mật khẩu không chính xác");
            }
        },
        fail: function (response) {
            alert("Lỗi xảy ra trong quá trình đăng nhập");
        }
    });
}