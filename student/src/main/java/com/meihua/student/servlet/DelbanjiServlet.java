package com.meihua.student.servlet;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.meihua.student.dao.StudentDao;

/**
 * Servlet implementation class DelbanjiServlet
 */
/**
 * 
* @author meihua: 
* @version 创建时间：2019年6月23日 上午9:53:35 
*
 */
public class DelbanjiServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
   
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

		doPost(request, response);
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		//设置中文乱码
				request.setCharacterEncoding("UTF-8");
				response.setCharacterEncoding("UTF-8");
				
					//删除操作，我就需要拿到对应删除的id
					String banji_name = request.getParameter("banji_name");
					
					//创建Dao对象，调用删除方法
					StudentDao studentDao = new StudentDao();
					//删除调用
					int i=studentDao.delBanji(banji_name);
				if(i==1)
					response.getWriter().write("删除成功！");
				else {
					response.getWriter().write("删除失败！");
				}
	}

}
