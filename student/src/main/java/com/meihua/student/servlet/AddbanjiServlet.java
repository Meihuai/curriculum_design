package com.meihua.student.servlet;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.meihua.student.dao.StudentDao;
import com.meihua.student.domain.Banji;


/**
 * Servlet implementation class AddbanjiServlet
 */
/**
 * 
* @author meihua: 
* @version 创建时间：2019年6月23日 上午8:51:22 
*
 */
public class AddbanjiServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
   
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doPost(request, response);

	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//设置中文乱码
		request.setCharacterEncoding("UTF-8");
		response.setCharacterEncoding("UTF-8");
		
		//获取班级信息
		String banji_name = request.getParameter("banji_name");
		String xueyaun = request.getParameter("xueyaun");
	
		//获取的信息，我们需要创建一个对象模型，存储
		Banji banji =new Banji();
		banji.setBanji_name(banji_name);
	   banji.setXueyuan(xueyaun);

		//调用持久层对象，帮助我们添加
		StudentDao dao = new StudentDao();
		dao.addbanji(banji);
		//跳转到首页面中
	//	response.getWriter().write("添加成功！");
		response.sendRedirect("/School/Console.jsp");

		
	}

}
