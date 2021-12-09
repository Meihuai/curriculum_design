package com.meihua.student.servlet;

import java.io.IOException;


import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;



import com.meihua.student.dao.LoginDao;

import com.meihua.student.domain.Admin;


/**
 * 登录操作，前端页面与服务器连接对象操作。
 */
public class LoginServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       

	/**
	 * get请求处理
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//不管是什么请求，都交给post请求处理
		doPost(request,response);
	}

	/**
	 * post请求处理
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//获取用户输入的账号与密码
		String username = request.getParameter("username");
		String password = request.getParameter("password");
		
		//调用持久层对象，帮助我们查询
		LoginDao loginDao = new LoginDao();
		//调用查询
		Admin admin = loginDao.login(username, password);
		Admin student = loginDao.Studentlogin(username, password);
		//判断对象是否为空
		if(admin != null){
			//登录成功，跳转首页
			request.getSession().setAttribute("username", username);
			response.sendRedirect("/School/Console.jsp"); 
			
		}
		else if(student!=null)
		{
			request.getSession().setAttribute("id", username);
			response.sendRedirect("/School/student.jsp"); 
		}
		else{
			
			request.setCharacterEncoding("UTF-8");
			response.setCharacterEncoding("UTF-8");
			
			//将失败结果，返回给当前的前端页面   
			response.sendRedirect("LOGIN.html?noshibai");
		}
		
		
		
		
		
	}

}
