# WebMisa
## List API
### Phương thức GET
Đăng nhập: /api/login?username=<>&password=<>
	response: true or false
User
Lấy thông tin User: /api/user?id=<>
	response: user có id tương ứng
Lấy tên hiển thị của user: /api/user?id=<>&getName=true
	response: tên hiển thị kiểu string
Lấy URL của avatar: /api/user?id=<>&getAvatar=true
	response: URL của avatar kiểu string
Status:
Lấy posts mới nhất: /api/posts
	response: List<Post>
Lấy post theo ID /api/posts?id=<>
	response: Post
Comment:
Lấy comment theo id: /api/comments?id=<>
	response: Comment
Lấy comment theo status id: /api/comments?statusId=<>
	response: List<Comment>
Like
Lấy like theo id: /api/likes?id=<>
	response: Comment
Lấy like theo status id: /api/likes?statusId=<>
	response: List<Comment>
Notification
Lấy thông báo từ hệ thống: /api/notify
	response List<Notification>
Lấy thông báo cá nhân: /api/notify?id=<>
	response List<Notification>