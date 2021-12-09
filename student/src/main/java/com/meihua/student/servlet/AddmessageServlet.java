package com.meihua.student.servlet;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.meihua.student.dao.StudentDao;
import com.meihua.student.domain.Message;

/**
 * Servlet implementation class AddmessageServlet
 */

/**
 * 
* @author meihua: 
* @version 创建时间：2019年6月26日 下午8:14:56 
*
 */
public class AddmessageServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
   
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		doPost(request, response);
	}



	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		request.setCharacterEncoding("UTF-8");
		response.setCharacterEncoding("UTF-8");
		
		Message message =new Message();
		
		
		message.setId(request.getParameter("id"));
		message.setTeacher(request.getParameter("teacher"));
		message.setMessage(request.getParameter("message"));
		
		
		StudentDao studentDao= new StudentDao();
		
		studentDao.addmessage(message);
		
		response.sendRedirect("/School/student.jsp");
	
	        
		
	}

}
