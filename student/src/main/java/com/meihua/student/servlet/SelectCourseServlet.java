package com.meihua.student.servlet;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.alibaba.fastjson.JSONObject;

import com.meihua.student.dao.StudentDao;
import com.meihua.student.domain.Course;

/**
 * Servlet implementation class SelectCourseServlet
 */

/**
 * 
* @author meihua: 
* @version 创建时间：2019年6月25日 上午11:01:37 
*
 */
public class SelectCourseServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
  
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		doPost(request, response);
	}



	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	
		request.setCharacterEncoding("UTF-8");
		response.setCharacterEncoding("UTF-8");
		
		//通过持久层对象查询
		StudentDao dao = new StudentDao();
		//查询所有
		List<Course> result = dao.selectCourse();
		//将查询到的结果，返回给当前的前端页面
		
		response.getWriter().write(JSONObject.toJSONString(result));
	}

}
