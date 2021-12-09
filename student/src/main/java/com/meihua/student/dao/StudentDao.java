package com.meihua.student.dao;


import java.sql.SQLException;
import java.util.List;

import com.meihua.student.domain.*;
import com.meihua.student.utils.JdbcUtils;
import org.apache.commons.dbutils.QueryRunner;
import org.apache.commons.dbutils.handlers.BeanListHandler;



/**
 * 
* @author meihua: 
* @version 创建时间：2019年6月19日 上午10:59:13 
*
 */

public class StudentDao {

	/*
	 * 查询所有学生操作
	 */
	public List<Student> selectAll(){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//如果没有异常，直接返回结果

			return queryRunner.query("select * from student ", new BeanListHandler<Student>(Student.class));
		} catch (SQLException e) {
			e.printStackTrace();
			//出现了异常，直接返回空
			return null;
		}
	}
	
	/*
	 * 查询所有课程信息
	 */
	public List<Course> selectCourse(){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//如果没有异常，直接返回结果

			return queryRunner.query("select * from course ", new BeanListHandler<Course>(Course.class));
		} catch (SQLException e) {
			e.printStackTrace();
			//出现了异常，直接返回空
			return null;
		}
	}
	
	
	/*
	 * 删除对应学生信息
	 */
	public void delStudent(int id){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//删除操作！
			queryRunner.update("delete from student where id = ?",id);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	/*
	 * 修改学生信息
	 */
	public int updateStudent(Student student){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//修改操作！
			queryRunner.update("update student set sname=?,banji=?,sex=?,phone =?,password =?,course=? where id= ? ",
					student.getSname(),
					student.getBanji(),
					student.getSex(),
			        student.getPhone(),
         	        student.getPassword(),
         	        student.getCourse(),
         	     	student.getId());
			
			return 1;  //修改成功 返回状态1
		} catch (SQLException e) {
			e.printStackTrace();
			return 0;  //修改失败 返回状态 0
		}
	}
	
	
	/*
	 * 添加学生信息
	 */
	public void addStudent(Student student){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//添加学生信息
		
			queryRunner.update("insert into student values(null,?,?,?,?,12345678,?)",
					student.getSname(),
					student.getBanji(),
					student.getSex(),
			        student.getPhone(),
			        "你还没有选择课程-请尽快选课！"
					);
			
			
			
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
	}
	
	
	/*
	 * 添加课程信息
	 */
	public void addCourse(Course course){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//添加课程信息
			queryRunner.update("insert into course values(?,?,?,?,?)",  //使用sql语句将获取到的课程信息添加到数据库中
				    course.getCourse_name(),  //获取课程名
				    course.getTeacher(),      //获取教师
				    course.getClassroom(),    //获取教室
					course.getTime(),         //获取上课时间
				    course.getCredit());      //取得课程学分
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
	}
	

	
	/*
	 * 添加报考申请
	 */
	public int addApplication(Application application){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//添加报考学生信息
			queryRunner.update("insert into application values(?,?,?,?,?,?,?,?,?,?,?)",
					application.getFraction(),  //高考分数
					application.getP_name(),    //考生姓名
					application.getPhone(),     //手机号码
					application.getMail(),      //邮箱
					application.getDate1(),     //出生日期
					application.getIdentity(),  //身份证号
					application.getMajor(),     //报考专业
					application.getHobby(),     //爱好
					application.getAbility(),   //特长
					application.getSex(),       //性别
					application.getOther());    //其他补充
			return 1;  //添加成功 返回状态1
		} catch (SQLException e) {
			e.printStackTrace();
			return 0;  //添加失败 返回状态0
		}
		
	}
	
	/*
	 * 查询所有报考信息
	 */
	public List<Application> selectApplication(){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//如果没有异常，直接返回结果
            //查询申请报考表
			return queryRunner.query("select * from application ", new BeanListHandler<Application>(Application.class));
		} catch (SQLException e) {
			e.printStackTrace();
			//出现了异常，直接返回空
			return null;
		}
	}
	
	/**
	 * 查询所有班级信息
	 * @return
	 */
	public List<Banji> selectbanji(){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//如果没有异常，直接返回结果
            //查询申请报考表
			return queryRunner.query("select * from banji ", new BeanListHandler<Banji>(Banji.class));
		} catch (SQLException e) {
			e.printStackTrace();
			//出现了异常，直接返回空
			return null;
		}
	}
	/*
	 * 添加班级信息
	 */
	public int addbanji(Banji banji){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//添加报考学生信息
			queryRunner.update("insert into banji values(?,?)",
					banji.getBanji_name(),  //高考分数
					banji.getXueyuan());    //其他补充
			return 1;  //添加成功 返回状态1
		} catch (SQLException e) {
			e.printStackTrace();
			return 0;  //添加失败 返回状态0
		}
		
	}
	
	/*
	 * 删除对应班级信息
	 */
	public int delBanji(String banji_name){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//删除操作！
			queryRunner.update("delete from banji where banji_name = ?",banji_name);
			return 1;
		} catch (SQLException e) {
			e.printStackTrace();
			return 0;
		}
	}
	
	
	/*
	 * 删除课程信息
	 */
	public int delcourse(String course_name){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//删除操作！
			queryRunner.update("delete from course where course_name = ?",course_name);
			return 1;
		} catch (SQLException e) {
			e.printStackTrace();
			return 0;
		}
	}
	
	/*
	 * 查询搜索信息
	 */
	public List<Student> lookupStudent(Student student){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//如果没有异常，直接返回结果
			String id=student.getLookup();
			
			return queryRunner.query("select * from student where id =? or sname =? or banji=? or sex = ? or phone =? or password = ? or course=?",new BeanListHandler<Student>(Student.class),id,id,id,id,id,id,id);
			
		} catch (SQLException e) {
			e.printStackTrace();
			//出现了异常，直接返回空
			return null;
		}
	
		
	}
	
	/*
	 * 添加留言信息
	 */
	public int addmessage(Message message){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//添加学生留言信息
			queryRunner.update("insert into message values(?,?,?)",
					message.getId(),  //学生id
					message.getTeacher(),//
					message.getMessage());//留言内容
			return 1;  //添加成功 返回状态1
		} catch (SQLException e) {
			e.printStackTrace();
			return 0;  //添加失败 返回状态0
		}
		
	}
	
	/*
	 * 查询留言信息
	 */
	public List<Message> Selectmessage(){
		QueryRunner queryRunner = new QueryRunner(JdbcUtils.getDataSource());
		try {
			//如果没有异常，直接返回结果
			return queryRunner.query("select * from message ", new BeanListHandler<Message>(Message.class));
			
		} catch (SQLException e) {
			e.printStackTrace();
			//出现了异常，直接返回空
			return null;
		}
	
		
	}
	

	
}
