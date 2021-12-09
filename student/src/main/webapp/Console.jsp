<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
	String username = (String) session.getAttribute("username"); //判断用户是否已登陆
	if (username == null) { //用户未登陆

		response.sendRedirect("LOGIN.html"); // 跳转到登录界面

	}
%>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>

<head>
<meta charset="UTF-8">
<title></title>
<meta name="renderer" content="webkit">
<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
<meta name="viewport"
	content="width=device-width, initial-scale=1, maximum-scale=1">
<link rel="stylesheet" href="css/layui.css" media="all">
<link rel="stylesheet" href="img/style.css" />
<script src="js/jquery.min.js"></script>
<script src="js/script.js"></script>
<script src="/School/js/jquery.1.9.min.js"></script>
<script src="/School/js/bootstrap.js"></script>
<link href="/School/css/bootstrap.css" rel="stylesheet">
<link rel="stylesheet" href="css/style.css">
<link rel="stylesheet" href="./css/fz-video.css">
<link rel="stylesheet" href="./font/iconfont.css">
<style type="text/css">
.clearfix {
	*zoom: 1;
}

* /
			
			body {
	font-family: "微软雅黑";
	background-color: #292929;
}

#testBox {
	width: 500px;
	height: 339px;
	margin: 0 auto;
}

lx {
	float: left;
	list-style: none
}

.dibu {
	height: 20em;
}
</style>





</head>

<body>

	<div class="layui-row">
		<div class="layui-col-xs12 layui-col-md12">
			<div class="grid-demo grid-demo-bg1">

				<ul class="layui-nav layui-bg-green ">
					<li class="layui-nav-item"><a href="index.html"><img
							src="img/LOGO.png"></a></li>
					<li class="layui-nav-item "><a href=""></a></li>
					<li class="layui-nav-item"><a href=""></a></li>

					<li class="layui-nav-item" layui-this><a
						href="Application.html">报考我校</a></li>
					<li class="layui-nav-item "><a href="student.jsp">学生服务</a></li>
					<li class="layui-nav-item"><a
						href="http://mail.qq.com/cgi-bin/qm_share?t=qm_mailme&email=AjM0MzYyOjQ1NDNCc3MsYW1v"
						target="_blank">校长信箱</a></li>
					<li class="layui-nav-item"><a href="">教务系统</a>
						<dl class="layui-nav-child">
							<dd>
								<a href="LOGIN.html">用户登录</a>
							</dd>
							<dd>
								<a href="register.html">用户注册</a>
							</dd>
							<dd>
								<a
									href="http://mail.qq.com/cgi-bin/qm_share?t=qm_mailme&email=AjM0MzYyOjQ1NDNCc3MsYW1v"
									target="_blank">用户反馈</a>
							</dd>

						</dl></li>
					<li class="layui-nav-item"><a href="">欢迎您: <%=username%></a>
					</li>
					<li class="layui-nav-item"><a href="exit.jsp"> 安全退出</a></li>

				</ul>

			</div>
		</div>

		<div class="layui-col-xs6 layui-col-md12" text align="center" id="tp">
			<div class="grid-demo grid-demo-bg2">

				<!--	移动：6/12、桌面：12/12-->

			</div>
		</div>

	</div>

	<div class="layui-container">
		<!--	中框架12/12-->

		<div class="layui-row">

			<div class="layui-col-md12">
				<div class="layui-tab">
					<div class="layui-tab layui-tab-brief" lay-filter="docDemoTabBrief">
						<ul class="layui-tab-title">
							<li class="layui-this">学生信息管理</li>
							<li>留言查看</li>
							<li>添加学生</li>
							<li>申请信息</li>
							<li>课程管理</li>
							<li>班级管理</li>

						</ul>
						<div class="layui-tab-content" style="height: 100px;">
							<div class="layui-tab-item layui-show">

								<div>

									<form class="form-inline row">
										<p class="text-center">
											<input type="text" class="form-control" id="select"
												placeholder="关键字">
											<button type="button" onclick="complete()"
												class="layui-btn layui-btn-primary layui-btn-radius">
												<i class="layui-icon layui-icon-search"
													style="font-size: 30px; color: #xe615;"></i>
											</button>
										</p>
									</form>



									<table id="t1" class="table table-hover">
										<tr>
											<td>学号</td>
											<td>姓名</td>
											<td>班级</td>
											<td>性别</td>
											<td>联系方式</td>
											<td>登录密码</td>
											<td>所选课程</td>
											<td>操作</td>
										</tr>
									</table>


								</div>
								<lx> </lx>
							</div>

							<div class="layui-tab-item ">
								<div>
									<table id="message" class="table table-hover">
										<tr>
											<td>学号</td>
											<td>留言教师</td>
										    <td>留言内容</td>
										</tr>
									</table>
								</div>
								<lx> </lx>



							</div>
							<div class="layui-tab-item ">
								<!-- 添加学生页面 -->
								<div>
									<form method="post" action="/School/AddStudentServlet">
										<div class="form-group">
											<label for="exampleInputEmail1">学生姓名：</label> <input
												type="text" class="form-control" name="sname"
												placeholder="请输入学生姓名">
										</div>

										<label for="exampleInputEmail1">学生班级：</label> <select
											class="form-control" id="banji" name="banji">

										</select>

										<div class="form-group">
											<label for="exampleInputEmail1">学生性别：</label> <select
												class="form-control" id="banji" name="sex">
												<option value="男">男</option>
												<option value="女">女</option>
											</select>
											<div class="form-group">
												<label for="exampleInputEmail1">学生联系方式：</label> <input
													type="text" class="form-control" name="phone"
													placeholder="联系方式">
											</div>

										</div>
										<div>
											<input type="submit" value="添加学生" class="btn btn-info" />
										</div>
									</form>
								</div>

								<lx> </lx>
							</div>

							<div class="layui-tab-item">

								<div>
									<table id="t2" class="table table-hover">
										<tr>
											<td>姓名</td>
											<td>高考成绩</td>
											<td>选填志愿</td>
											<td>身份证号</td>
											<td>爱好</td>
											<td>特长</td>
											<td>性别</td>
											<td>出生日期</td>
											<td>手机号</td>
											<td>邮箱</td>
											<td>个人说明</td>

										</tr>
									</table>
								</div>


								<lx> </lx>
							</div>

							<div class="layui-tab-item ">




								<div>




									<table id="kecheng" class="table table-hover">
										<tr>
											<td>课程名称</td>
											<td>任课教师</td>
											<td>上课地点</td>
											<td>上课时间</td>
											<td>课程学分</td>
											<td>操作</td>
										</tr>
									</table>
								</div>



								<div>
									<form method="post" action="/School/AddcourseServlet">

										<div class="form-group">
											<label for="exampleInputEmail1">课程名称：</label> <input
												type="text" class="form-control" name="course_name"
												placeholder="请输入课程名(唯一不可重复)">
										</div>

										<div class="form-group">
											<label for="exampleInputEmail1">任课教师：</label> <select
												class="form-control" id="teacher" name="teacher">
												<option value="杨明熙 副教授-硕士生导师">杨明熙 副教授-硕士生导师 -网络安全
													-计算机网络方向</option>
												<option value="张韧 博士 -高等数学-概率论-数基理学方向">张韧 博士 -高等数学-概率论-数基理学方向</option>
												<option value="Meihua 首席架构师">Meihua 首席架构师
													AI-大数据-人工智能方向</option>
												<option value="刘琳琳 高级实验师">刘琳琳 高级实验师
													STM32机器人-实验室科研方向</option>
												<option value="向胜涛 团总支书记">向胜涛 团总支书记 大学生心理-职业规划方向</option>
												<option value="邱珊 教授">邱珊 教授 java高级 C# 面向对象方向</option>
												<option value="司晓梅 教授">司晓梅 教授 C语言-数据结构-算法研究方向</option>
												<option value="张亮 教授">张亮 教授 -马克思主义方向</option>
												<option value="周涛 科学家">周涛 科学家 -701研究所方向</option>
												<option value="李校长 党委书记">李校长 党委书记 -典礼 发表讲话</option>
											</select>
										</div>

										<div class="form-group">
											<label for="exampleInputEmail1">上课地点：</label> <select
												class="form-control" id="classroom" name="classroom">
												<option value="教学楼3-301">教学楼3-301</option>
												<option value="教学楼2-201">教学楼2-201</option>
												<option value="教学楼1-101">教学楼1-101</option>
												<option value="学术报告厅">学术报告厅</option>
												<option value="701科学研究室">701科学研究室</option>
												<option value="232机房">232机房</option>
												<option value="523计算机实验室">523计算机实验室</option>
												<option value=" 443网络实验室">443网络实验室</option>
												<option value="商学院实验中心">商学院实验中学</option>
												<option value="外国语实验中心">外国语实验中心</option>
											</select>
										</div>

										<div class="form-group">
											<label for="exampleInputEmail1">上课时间：</label> <select
												class="form-control" id="time" name="time">
												<option value="下午七八节">下午七八节</option>
												<option value="下午五六节">下午五六节</option>
												<option value="上午三四节">上午三四节</option>
												<option value="晚自习">晚自习</option>
												<option value="上午一二节">上午一二节</option>
											</select>
										</div>

										<div class="form-group">
											<label for="exampleInputEmail1">课程学分：</label> <select
												class="form-control" id="credit" name="credit">
												<option value="5.0">5.0</option>
												<option value="4.5">4.5</option>
												<option value="4.0">4.0</option>
												<option value="3.5">3.5</option>
												<option value="3.0">3.0</option>
												<option value="2.5">2.5</option>
												<option value="1">1</option>
											</select>
										</div>


										<div>
											<input type="submit" value="添加课程" class="btn btn-info" />
										</div>
									</form>
								</div>








								<lx> </lx>
							</div>
							<div class="layui-tab-item ">


								<div>




									<table id="t5" class="table table-hover">
										<tr>
											<td>班级名</td>
											<td>所属学院</td>
											<td>操作</td>


										</tr>
									</table>
								</div>



								<div>
									<form method="post" action="/School/AddbanjiServlet">

										<div class="form-group">
											<label for="exampleInputEmail1">班级名称：</label> <input
												type="text" class="form-control" name="banji_name"
												placeholder="请输入班级名(唯一不可重复)">
										</div>
										<div class="form-group">
											<label for="exampleInputEmail1">所属学院：</label> <select
												class="form-control" id="xueyuan" name="xueyaun">
												<option value="信息工程学院">信息工程学院</option>
												<option value="外国语学院">外国语学院</option>
												<option value="机电工程学院">机电工程学院</option>
												<option value="商学院">商学院</option>
												<option value="土木工程学院">土木工程学院</option>
												<option value="汽车工程学院">汽车工程学院</option>
												<option value="生物与制药学院">生物与制药学院</option>
												<option value="体育学院">体育学院</option>
												<option value="大数据学院">大数据学院</option>
												<option value="makesi">马克思主义学院</option>
											</select>
										</div>
										<div>
											<input type="submit" value="添加班级" class="btn btn-info" />
										</div>
									</form>
								</div>




								<lx> </lx>
							</div>



						</div>


					</div>
				</div>

			</div>
		</div>



	</div>



	<script src="layui.js" charset="utf-8"></script>

	<!-- 我们需要用到当前的jQuery对象，进行数据的访问，通过AJAX -->
	<script type="text/javascript">
	

	
	
		var json, p, temp;
		var abcd = [ "1", "", "", "", "", "", "", "" ]; //设置一个数组
		p = 1; //给p赋初值 目的从第二个元素开始记录
		function complete() {

			var select = $("#select").val();

			$
					.post(
							"/School/SelectStudentServlet",
							{
								"select" : select
							},
							function(data) {
								//第一步：将字符串封装成集合对象

								$('#t1').empty(); //清空对应的子节点

								$("#t1")
										.append(
												"<td>学号</td><td>姓名</td><td>班级</td><td>性别</td><td>联系方式</td><td>登录密码</td><td>操作</td>");

								var datap = eval("(" + data + ")");
								//循环遍历的里面

								for (var i = 0; i < datap.length; i++) {
									//第二步：将一个个的集合对象内容，封装到表格当中
									$("#t1")
											.append(
													"<tr ><td>"
															+ datap[i].id
															+ "</td><td class='dongtai'>"
															+ datap[i].sname
															+ "</td><td class='dongtai'>"
															+ datap[i].banji
															+ "</td><td class='dongtai' >"
															+ datap[i].sex
															+ "</td><td class='dongtai'>"
															+ datap[i].phone
															+ "</td><td class='dongtai'>"
															+ datap[i].password
															+ "</td><td class='dongtai'>"
															+ datap[i].course
															+ "</td><td class='anniu'>"
															+ "<input type='button' onclick='update("
															+ datap[i].id
															+ ")' class='btn btn-info' value='修改'> <button type='button' onclick='del("
															+ datap[i].id
															+ ")' class='btn btn-danger'>删除</button> </td></tr>");
								}

							});

		}

		function update(id) {
			//利用函数传值，获取到当前的学号主键
			temp = id;
		}

		$.post("/School/BanjiselectServlet",function(data) {
							//第一步：将字符串封装成集合对象
							var datap = eval("(" + data + ")");
							//循环遍历的里面
							for (var i = 0; i < datap.length; i++) {
								//将一个个的集合对象内容，封装到表格与下拉列表当中

								$("#t5").append("<tr><td>"
														+ datap[i].banji_name
														+ "</td><td>"
														+ datap[i].xueyuan
														+ "</td><td>"
														+ "<button type='button' onclick='delbanji(&quot"
														+ datap[i].banji_name
														+ "&quot)' class='btn btn-danger'>删除</button> </td></tr>"); //将数据动态添加到表格 
								$("#banji").append(
										"<option value="+datap[i].banji_name+">"
												+ datap[i].banji_name
												+ "</option>"); //动态添加到下拉列表
							}
						});
		
		
		
		$.post("/School/SelectMessageservlet",function(data) {
			//第一步：将字符串封装成集合对象
			var datap = eval("(" + data + ")");
			//循环遍历的里面
			for (var i = 0; i < datap.length; i++) {
				//将一个个的集合对象内容，封装到表格与下拉列表当中

				$("#message").append("<tr><td>"
										+ datap[i].id
										+ "</td><td>"
										+ datap[i].teacher
										+ "</td><td>"
										+datap[i].message
										+"</td></tr>"); //将数据动态添加到表格 
			}
		});
		
		
		
		
		

		function delbanji(banji_name) {
			//通过异步请求，AJAX删除当前的操作
			//利用对话框返回的值 （true 或者 false）  
			if (confirm("你确定删除吗？")) {

				$.post("/School/DelbanjiServlet", {
					"banji_name" : banji_name
				}, function(data) {
					alert(data);
					//重新刷新一下界面
					window.location.reload();
				});
			} else {
			}
		}

		//通过ajax去请求服务器，获取对应的学生数据
		$
				.post(
						"/School/StudentServlet",
						function(data) {
							//第一步：将字符串封装成集合对象
							json = eval("(" + data + ")");
							//循环遍历的里面
							for (var i = 0; i < json.length; i++) {
								//第二步：将一个个的集合对象内容，封装到表格当中
								$("#t1")
										.append(
												"<tr ><td>"
														+ json[i].id
														+ "</td><td class='dongtai'>"
														+ json[i].sname
														+ "</td><td class='dongtai' >"
														+ json[i].banji
														+ "</td><td class='dongtai' >"
														+ json[i].sex
														+ "</td><td class='dongtai'>"
														+ json[i].phone
														+ "</td><td class='dongtai'>"
														+ json[i].password
														+ "</td><td class='dongtai'>"
														+ json[i].course
														+ "</td><td class='anniu'>"
														+ "<input type='button' onclick='update("
														+ json[i].id
														+ ")' class='btn btn-info' value='修改'> <button type='button' onclick='del("
														+ json[i].id
														+ ")' class='btn btn-danger'>删除</button> </td></tr>");
							}

							//给input 按钮添加点击事件

							//利用对话框返回的值 （true 或者 false）  

							$("input:button")
									.click(
											function() {

												str = $(this).val() == "修改" ? "保存"
														: "修改";

												if ($(this).val() == "保存") {
													p = 1;
													if (confirm("你确定保存吗？")) {

														//遍历 aDiv的中所有元素并且将所有class为“test”的元素的字体颜色设置为“red”

														abcd[1] = $(".1").val(); //将 class 1 文本框中的值传入数组

														abcd[2] = $(".2").val(); //将 class 2 文本框中的值传入数组

														abcd[3] = $(".3").val(); //将 class 3 文本框中的值传入数组

														abcd[4] = $(".4").val(); //将 class 3 文本框中的值传入数组

														abcd[5] = $(".5").val(); //将 class 3 文本框中的值传入数组
														
														abcd[6] = $(".6").val();

														if (abcd[1] == ""
																|| abcd[2] == ""
																|| abcd[3] == ""
																|| (abcd[3] != "男" && abcd[3] != "女")) {

															alert("修改失败：请严格检查您输入的字符！  \n如主要信息不能为空 \n字符串超出规定范围 \n性别不为男或女 等等 ");
														} else {
															$
																	.post(
																			"/School/UpdateStudentServlet",
																			{
																				"id" : abcd[0],
																				"sname" : abcd[1],
																				"banji" : abcd[2],
																				"sex" : abcd[3],
																				"phone" : abcd[4],
																				"password" : abcd[5],
																			    "course" : abcd[6]
																			},
																			function(
																					data) {
																				alert(data); //接收页面发过来的成功信息
																				//重新刷新一下界面
																				window.location
																						.reload();//刷新页面
																			});
														}

													} else {

														window.location
																.reload();//取消 则进行撤销操作 刷新页面
													}

												}

												$(this).val(str); // 按钮被点击后，在“编辑”和“确定”之间切换

												abcd[0] = temp;// 读取id 存入数组
												//alert(abcd[0]);  //输出测试

												$(this)
														.parent()
														.siblings(".dongtai")
														.each(
																function() { // 获取当前行的其他单元格

																	obj_text = $(
																			this)
																			.find(
																					"input:text"); // 判断单元格下是否有文本框

																	if (!obj_text.length) // 如果不是文本框类型，则将值转为文本框使之可以编辑

																	{
																		abcd[p] = $(
																				this)
																				.text(); //获得当前动态类文本的值存入数组
																		//	alert(abcd[p]);  //测试
																		$(this)
																				.html(
																						"<input type='text' class='"+p+"' value='"+abcd[p]+"'  size ='12'>"); // 动态生成 class 将表格转换为文本框 使变得可编辑 
																		p++;
																	}

																});

												p = 0; //将数组置零

											});

						});

		function del(id) {
			//通过异步请求，AJAX删除当前的操作
			//利用对话框返回的值 （true 或者 false）  
			if (confirm("你确定删除吗？")) {
				$.post("/School/DelStudentServlet", {
					"id" : id
				}, function(data) {
					alert(data);
					//重新刷新一下界面
					window.location.reload();
				});
			} else {
			}
		}

		//通过ajax去请求服务器，获取对应的学生数据

		$.post("/School/Applicationservlet", function(data) {
			//第一步：将字符串封装成集合对象
			var datap = eval("(" + data + ")");
			//循环遍历的里面
			for (var i = 0; i < datap.length; i++) {
				//第二步：将一个个的集合对象内容，封装到表格当中
				$("#t2").append(
						"<tr><td>" + datap[i].p_name
								+ "</td><td class='dongtai'>"
								+ datap[i].fraction
								+ "</td><td class='dongtai'>" + datap[i].major
								+ "</td><td>" + datap[i].identity + "</td><td>"
								+ datap[i].hobby + "</td><td>"
								+ datap[i].ability + "</td><td>" + datap[i].sex
								+ "</td><td>" + datap[i].date1 + "</td><td>"
								+ datap[i].phone + "</td><td>" + datap[i].mail
								+ "</td><td>" + datap[i].other + "</td></tr>");
			}
		});
		
		
		//通过ajax去请求服务器，获取对应的学生数据

		$.post("/School/SelectCourseServlet", function(data) {
			//第一步：将字符串封装成集合对象
			var datap = eval("(" + data + ")");
			//循环遍历的里面
			for (var i = 0; i < datap.length; i++) {
		
				//第二步：将一个个的集合对象内容，封装到表格当中
				$("#kecheng").append(
						"<tr><td>" + datap[i].course_name+"</td><td>"
							       + datap[i].teacher+ "</td><td>" 
							       + datap[i].classroom +"</td><td>"
							       + datap[i].time + "</td><td>"
							       + datap[i].credit + "</td><td>"
								+ "<button type='button' onclick='delcourse(&quot"+ datap[i].course_name+ "&quot)' class='btn btn-danger'>删除</button> </td></tr>");
				
			}
		});
		
		function delcourse(course_name) {
			//通过异步请求，AJAX删除当前的操作
			//利用对话框返回的值 （true 或者 false）  
			if (confirm("你确定删除吗？")) {
				$.post("/School/DelCourseServlet", {"course_name" : course_name}, function(data) {
					alert(data);
					//重新刷新一下界面
					window.location.reload();
				});
			} else {
				
			}
		}
		
	
		
		
		
		
		
		
	
	</script>

	<!-- 选项卡触发事件-->
	<script>
		layui.use('element', function() {
			var $ = layui.jquery, element = layui.element; //Tab的切换功能，切换事件监听等，需要依赖element模块

			//触发事件
			var active = {
				tabAdd : function() {
					//新增一个Tab项
					element.tabAdd('demo', {
						title : '新选项' + (Math.random() * 1000 | 0) //用于演示
						,
						content : '内容' + (Math.random() * 1000 | 0),
						id : new Date().getTime()
					//实际使用一般是规定好的id，这里以时间戳模拟下
					})
				},
				tabDelete : function(othis) {
					//删除指定Tab项
					element.tabDelete('demo', '44'); //

					othis.addClass('layui-btn-disabled');
				},
				tabChange : function() {
					//切换到指定Tab项
					element.tabChange('demo', '22'); //切换到：用户管理
				}
			};

			$('.site-demo-active').on('click', function() {
				var othis = $(this), type = othis.data('type');
				active[type] ? active[type].call(this, othis) : '';
			});

			//Hash地址的定位
			var layid = location.hash.replace(/^#test=/, '');
			element.tabChange('test', layid);

			element.on('tab(test)', function(elem) {
				location.hash = 'test=' + $(this).attr('lay-id');
			});

		});
	</script>

	


	

</body>




</html>