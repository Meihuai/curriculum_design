package com.meihua.student.servlet;

import java.io.IOException;


import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.meihua.student.dao.StudentDao;

/**
 * 删除学生连接对象
 */
public class DelStudentServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doPost(request, response);
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//设置中文乱码
		request.setCharacterEncoding("UTF-8");
		response.setCharacterEncoding("UTF-8");
		try{
			//删除操作，我就需要拿到对应删除的id
			String id = request.getParameter("id");
			
			//创建Dao对象，调用删除方法
			StudentDao studentDao = new StudentDao();
			//删除调用
			studentDao.delStudent(Integer.parseInt(id));
			response.getWriter().write("删除成功！");
			
		}
		
	catch (Exception e) {
		response.getWriter().write("删除失败！");
		e.printStackTrace();
	 }
		
		
	}

}
