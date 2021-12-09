package com.meihua.student.servlet;

import com.meihua.student.dao.StudentDao;
import com.meihua.student.domain.Application;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;


/**
 * Servlet implementation class AddApplicationservlet
 */

/**
 * 
* @author meihua: 
* @version 创建时间：2019年6月22日 下午10:37:58 
* Application 申请请求
 */

public class AddApplicationservlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
  
   
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		doPost(request, response);
	}


	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	
		request.setCharacterEncoding("UTF-8");
		response.setCharacterEncoding("UTF-8");
		
		//获取学生信息
		
		 int fraction = Integer.parseInt(request.getParameter("fraction"));
		 String p_name = request.getParameter("p_name");
		 String phone  = request.getParameter("phone");
		 String mail   = request.getParameter("mail");
		 String date1  = request.getParameter("date1");
		 String identity = request.getParameter("identity");
		 String major = request.getParameter("major");
		 String hobby = request.getParameter("hobby");
		 String ability = request.getParameter("ability");
	     String sex=request.getParameter("sex");
		 String other = request.getParameter("other");

		
		//获取的信息，我们需要创建一个对象模型，存储
		Application application = new Application();
	
		application.setFraction(fraction);  //高考分数
		application.setP_name(p_name);    //考生姓名
		application.setPhone(phone);    //手机号码
		application.setMail(mail);     //邮箱
		application.setDate1(date1);     //出生日期
		application.setIdentity(identity);  //身份证号
		application.setMajor(major);     //报考专业
		application.setHobby(hobby);     //爱好
		application.setAbility(ability);   //特长
		application.setSex(sex);       //性别
		application.setOther(other);    //其他补充
		
		
		//调用持久层对象，帮助我们添加
		StudentDao dao = new StudentDao();
		
		int i=dao.addApplication(application);   
		
		if(i==1)//通过函数返回值 来判断是否修改成功
			response.getWriter().write("提交成功！");
		else response.getWriter().write("提交数据时发生异常 提交失败 请仔细检查您的数据格式或稍后再试！");
		
		response.sendRedirect("/School/index.html");
		//跳转到首页面中
	
	}

}
