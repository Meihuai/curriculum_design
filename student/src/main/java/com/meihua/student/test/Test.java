package com.meihua.student.test;

import java.sql.SQLException;
import java.util.List;

import org.apache.commons.dbutils.QueryRunner;
import org.apache.commons.dbutils.handlers.BeanHandler;
import org.apache.commons.dbutils.handlers.BeanListHandler;

import com.meihua.student.domain.Student;
import com.meihua.student.utils.JdbcUtils;

/**
 * 测试类
 * @author zhangbin
 */
public class Test {

	public void test() throws SQLException{
		//创建数据库帮助工具对象
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		
		//执行查询语句：查询所有
		List<Student> stus = queryRunner.query("select * from student", 
				new BeanListHandler<Student>(Student.class));
		//查询结果
		System.out.println(stus);
		
		//执行查询语句：查询单个
		Student stu = queryRunner.query("select * from student where id = ?", 
				new BeanHandler<Student>(Student.class),3);
		//查询结果显示
		System.out.println(stu);
	}
}
