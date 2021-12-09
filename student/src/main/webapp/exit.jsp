<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>安全退出功能实现页</title>

</head>
<body>

	<%
		session.invalidate();                 //清除session信息 达到退出用户的作用
		response.sendRedirect("LOGIN.html");  //返回到登录页
	%>



</body>
</html>