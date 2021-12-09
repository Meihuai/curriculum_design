package com.meihua.student.domain;



public class Student {

	private int id;
	private String sname;
	private String banji;
	private String sex;
	private String phone;
	private String password;
	private String course;
	public String getCourse() {
		return course;
	}
	public void setCourse(String course) {
		this.course = course;
	}
	private String lookup;
	/*
	 * 当前属性设置好了以后，我们需要传递数据，需要设置get和set
	 */
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getSname() {
		return sname;
	}
	public void setSname(String sname) {
		this.sname = sname;
	}
	public String getBanji() {
		return banji;
	}
	public void setBanji(String banji) {
		this.banji = banji;
	}
	public String getSex() {
		return sex;
	}
	public void setSex(String sex) {
		this.sex = sex;
	}
	
	public String getLookup() {
		return lookup;
	}
	public void setLookup(String lookup) {
		this.lookup = lookup;
	}
	
	public String getPhone() {
		return phone;
	}
	public void setPhone(String phone) {
		this.phone = phone;
	}
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	/*
	 * 直接打印对象，就能显示内容
	 */
	@Override
	public String toString() {
		return "Student [id=" + id + ", sname=" + sname + ", banji=" + banji + ", sex=" + sex + ", phone=" + phone
				+ ", password=" + password + ", course=" + course + ", lookup=" + lookup + "]";
	}

	
	
	
}
