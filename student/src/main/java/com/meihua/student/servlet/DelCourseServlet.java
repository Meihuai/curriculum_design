package com.meihua.student.servlet;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.meihua.student.dao.StudentDao;


/**
 * Servlet implementation class DelCourseServlet
 */
/**
 * 
* @author meihua: 
* @version 创建时间：2019年6月26日 下午9:10:24 
*
 */
public class DelCourseServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    
   
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doPost(request, response);
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		request.setCharacterEncoding("utf-8");
		response.setCharacterEncoding("utf-8");
		
		
		StudentDao studentDao=new StudentDao();
		
		String course_name=request.getParameter("course_name");
		int i=studentDao.delcourse(course_name);
		
	     
		if(i==1)
			response.getWriter().write("删除成功！");
		else {
			response.getWriter().write("删除失败！");
		}
		
		
	}

}
