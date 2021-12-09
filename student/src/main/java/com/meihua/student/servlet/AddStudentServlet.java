package com.meihua.student.servlet;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;


import com.meihua.student.domain.Student;
import com.meihua.student.dao.StudentDao;

/**
 * 删除学生连接对象
 */
public class AddStudentServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doPost(request, response);
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//设置中文乱码
		request.setCharacterEncoding("UTF-8");
		response.setCharacterEncoding("UTF-8");
		//获取学生信息
		String sname = request.getParameter("sname");
		String banji = request.getParameter("banji");
		String sex = request.getParameter("sex");
		String phone = request.getParameter("phone");
		//获取的信息，我们需要创建一个对象模型，存储
		Student student = new Student();
		student.setSname(sname);
		student.setBanji(banji);
		student.setSex(sex);
		student.setPhone(phone);
		//调用持久层对象，帮助我们添加
		StudentDao dao = new StudentDao();
		dao.addStudent(student);
		//跳转到首页面中
		
		response.sendRedirect("/School/Console.jsp");
	}

}



