package com.meihua.student.servlet;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.meihua.student.dao.StudentDao;
import com.meihua.student.domain.Course;

/**
 * Servlet implementation class AddcourseServlet
 */
/**
 * 
* @author meihua: 
* @version 创建时间：2019年6月25日 上午10:34:07 
*
 */
public class AddcourseServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
   
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doPost(request, response);
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	
		//设置中文乱码
				request.setCharacterEncoding("UTF-8");
				response.setCharacterEncoding("UTF-8");
				
				//获取班级信息
				String course_name = request.getParameter("course_name");
			    String teacher =request.getParameter("teacher");
			    String classroom =request.getParameter("classroom");	
			    String time =request.getParameter("time");
			    String credit =request.getParameter("credit");
			        
				//获取的信息，我们需要创建一个对象模型，存储
			    Course course =new Course();
			    
			    course.setCourse_name(course_name);
			    course.setCredit(credit);
			    course.setTeacher(teacher);
			    course.setTime(time);
				course.setClassroom(classroom);

				//调用持久层对象，帮助我们添加
				StudentDao dao = new StudentDao();
				dao.addCourse(course);
				//跳转到首页面中
			//	response.getWriter().write("添加成功！");
				response.sendRedirect("/School/Console.jsp");

				
	
	}

}
