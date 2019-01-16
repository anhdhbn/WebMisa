# WebMisa
## List API
### Phương thức GET

Đăng nhập: /api/login?username=<>&password=<><br/>
>	response: true or false<br/>

User<br/>
Lấy thông tin User: /api/user?id=<><br/> 
>	response: user có id tương ứng<br/> 

Lấy tên hiển thị của user: /api/user?id=<>&getName=true<br/> 
>	response: tên hiển thị kiểu string<br/>

Lấy URL của avatar: /api/user?id=<>&getAvatar=true<br/>
>	response: URL của avatar kiểu string<br/>

Status:<br/>
Lấy posts mới nhất: /api/posts<br/>
>	response: List<Post><br/>

Lấy post theo ID /api/posts?id=<><br/>
>	response: Post<br/>

Comment:
Lấy comment theo id: /api/comments?id=<><br/>
>	response: Comment<br/>

Lấy comment theo status id: /api/comments?statusId=<><br/>
>	response: List Comment <br/>

Like
Lấy like theo id: /api/likes?id=<><br/>
>	response: Comment<br/>

Lấy like theo status id: /api/likes?statusId=<><br/>
>	response: List Comment <br/>
	
Notification<br/>
Lấy thông báo từ hệ thống: /api/notify<br/>
>	response List Notification <br/>

Lấy thông báo cá nhân: /api/notify?id=<><br/>
>	response List Notification <br/>
