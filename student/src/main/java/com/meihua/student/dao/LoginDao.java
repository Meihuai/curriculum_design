package com.meihua.student.dao;



import java.sql.SQLException;

import com.meihua.student.domain.Admin;
import com.meihua.student.utils.JdbcUtils;
import org.apache.commons.dbutils.QueryRunner;
import org.apache.commons.dbutils.handlers.BeanHandler;



/** 
* @author meihua: 
* @version 创建时间：2019年6月19日 下午5:15:18 
* 
*/ 
public class LoginDao {

	/*
	 * 登录操作
	 */
	public Admin login(String username, String password){
		//创建一个JDBC链接对象
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			Admin admin = queryRunner.query("select * from admin where username = ? and password = ?", 
					new BeanHandler<Admin>(Admin.class),username,password);
			//如果没有异常，我就讲对象返回
			return admin;
		} catch (SQLException e) {
			e.printStackTrace();
			//如果出现了意外
			return null;
		}
	}
	
	/*
	 * 登录操作 学生
	 */
	public Admin Studentlogin(String id, String password){
		//创建一个JDBC链接对象
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			Admin admin = queryRunner.query("select * from student where id = ? and password = ?", 
					new BeanHandler<Admin>(Admin.class),id,password);
			//如果没有异常，我就讲对象返回
			return admin;
		} catch (SQLException e) {
			e.printStackTrace();
			//如果出现了意外
			return null;
		}
	}
	
	
	
	
}