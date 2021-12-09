package com.meihua.student.servlet;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.alibaba.fastjson.JSONObject;

import com.meihua.student.dao.StudentDao;
import com.meihua.student.domain.Banji;


public class BanjiselectServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
    
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doPost(request, response);
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	
		//设置中文乱码
				request.setCharacterEncoding("UTF-8");
				response.setCharacterEncoding("UTF-8");
				
				//通过持久层对象查询
				StudentDao dao = new StudentDao();
				//查询所有
				List<Banji> result = dao.selectbanji();
				//将查询到的结果，返回给当前的前端页面
				
				response.getWriter().write(JSONObject.toJSONString(result));
				
	}

}

 