package com.meihua.student.servlet;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;



import com.meihua.student.dao.StudentDao;
import com.meihua.student.domain.Student;


public class UpdateStudentServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
  
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		doPost(request, response);
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	
		//设置中文乱码
				request.setCharacterEncoding("UTF-8");
				response.setCharacterEncoding("UTF-8");
//				//获取学生信息

					String sname = request.getParameter("sname");
					String banji = request.getParameter("banji");
					String sex = request.getParameter("sex");
					String phone = request.getParameter("phone");
					String password = request.getParameter("password");
					String course = request.getParameter("course");
					int id = Integer.parseInt(request.getParameter("id"));
				
					
					if(sname !="" && banji!="" &&sex!="" && phone!=""&&password!=""&&course!="")
					{
						
				
						//获取的信息，我们需要创建一个对象模型，存储
		     		   	Student student = new Student();
						student.setSname(sname);
						student.setBanji(banji);
						student.setSex(sex);
						student.setId(id);	
						student.setPhone(phone);
						student.setPassword(password);
						student.setCourse(course);
				    	StudentDao dao = new StudentDao();
						int i=dao.updateStudent(student);
						if(i==1)//通过函数返回值 来判断是否修改成功
							response.getWriter().write("修改成功！");
						else response.getWriter().write("修改失败！");
					}
					else response.getWriter().write("修改失败！");
			
			

	}

}
