<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
	String id = (String) session.getAttribute("id"); //判断用户是否已登陆
	if (id == null) { //用户未登陆
		response.sendRedirect("LOGIN.html"); // 跳转到登录界面
	}
%>
<!DOCTYPE html>
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
<link rel="stylesheet" href="css/style.css">
<link rel="stylesheet" href="css/fz-video.css">
<link rel="stylesheet" href="font/iconfont.css">
<style type="text/css">

body {
	font-family: "微软雅黑";
	background-color: #292929;
}

#testBox {
	width: 500px;
	height: 339px;
	margin: 0 auto;
}

* {
	padding: 0;
	margin: 0
}

body {
	background-color: #eee;
}

.test {
	width: 540px;
	margin: 40px auto 0
}

lq {
	width: 180px;
	height: 180px;
	float: left;
	list-style: none
}

lx {
	float: left;
	list-style: none
}

lq img {
	width: 140px;
	height: 140px;
	box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
	-webkit-transition: all ease .3s;
	transition: all ease .5s;
}

lq img:hover {
	-webkit-transform: scale(1.05);
	transform: scale(3.05);
	box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
	border-radius: 50%
}

#tp {
	overflow-x: auto;
	overflow-y: auto;
}

* {
	padding: 0px
}


</style>

<script language="javascript">
	$(document).ready(function() {
		$("#gallery_output img").not(":first").hide();
		$("#gallery_content p").not(":first").hide();
		$("#gallery a").click(function() {
			$("#gallery a").removeClass('zz');
			$(this).addClass("zz");
			if ($("#" + this.rel).is(":hidden")) {
				$("#gallery_output img").slideUp();
				$("#gallery_content p").slideUp();
				$("#" + this.rel).slideDown();
				$("#p" + this.rel).slideDown();
			}
		});
	});
</script>


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
					<li class="layui-nav-item"><a href="javascript:;">教务系统</a>
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
					<li class="layui-nav-item"><a href="exit.jsp">安全退出</a></li>
				</ul>

			</div>
		</div>

		<div class="layui-col-xs6 layui-col-md12" text align="center" id="tp">
			<div class="grid-demo grid-demo-bg2">

				<div class="layui-carousel" id="test1">
					<div carousel-item>
						<div>
							<img src="img/b.jpg">
						</div>
						<div>
							<img src="img/c.jpg">
						</div>
						<div>
							<img src="img/a.jpg">
						</div>

					</div>
				</div>

				<script src="layui.js"></script>
				<script>
					layui.use('carousel', function() {
						var carousel = layui.carousel;
						//建造实例
						carousel.render({
							elem : '#test1',
							width : '100%' //设置容器宽度
							,
						//	arrow : 'always' //始终显示箭头
						//,anim: 'updown' //切换动画方式
						});
					});
				</script>

				<!--	移动：6/12、桌面：12/12-->

			</div>
		</div>

	</div>

	<div class="layui-container">
		<!--	中框架12/12-->

		<div class="layui-row">
			<div class="layui-col-md8">
				<div class="layui-tab">
					<div class="layui-tab layui-tab-brief" lay-filter="docDemoTabBrief">
						<ul class="layui-tab-title">
							<li class="layui-this">个人信息</li>
                            <li >教师留言</li>
                            <li >其他设置</li>
                            
						</ul>
						<div class="layui-tab-content" style="height: 100px;">
							<div class="layui-tab-item layui-show">
                            <hr class="layui-bg-green">
                            
  

 
<form class="layui-form"   lay-filter="example">
  <div class="layui-form-item">
    <label class="layui-form-label">学号</label>
    <div class="layui-input-block">
      <input type="text" name="id" lay-verify="title" autocomplete="off" readonly="readonly" class="layui-input">
    </div>
  </div>
  
  <div class="layui-form-item">
    <label class="layui-form-label">个人姓名</label>
    <div class="layui-input-block">
      <input type="text" name="sname" id ="sname" lay-verify="required" lay-reqtext="个人姓名，岂能为空？"placeholder="你的姓名" autocomplete="off" class="layui-input">
    </div>
  </div>
  

  <div class="layui-form-item">
    <label class="layui-form-label">所属班级</label>
    <div class="layui-input-block">
      <select name="banji" id="banji" lay-filter="aihao">
       
      </select>
    </div>
  </div>
  

 
  <div class="layui-form-item">
    <label class="layui-form-label">性别</label>
    <div class="layui-input-block">
      <input type="radio" id="sex" name="sex" value="男" title="男" checked="">
      <input type="radio" id="sex" name="sex" value="女" title="女" checked="" >
    </div>
  </div>
  
  
  
   <div class="layui-form-item">
    <div class="layui-inline">
      <label class="layui-form-label">联系方式</label>
      <div class="layui-input-inline">
        <input type="tel" name="phone" id="phone"  placeholder="手机号码" lay-verify="required|phone" autocomplete="off" class="layui-input">
      </div>
    </div>
  </div>
  
  
 
    <div class="layui-form-item">
    <label class="layui-form-label">所选课程</label>
    <div class="layui-input-block">
      <select name="course" id="course" lay-filter="aihao">
       
      </select>
    </div>
  </div>
  
 
  
  
    <div class="layui-form-item">
    <div class="layui-input-block">
      <button class="layui-btn"   lay-submit=""  onclick="complete()" >变更</button>
    </div>
  </div>
  
</form>

							</div>

							<div class="layui-tab-item ">
					
							
<form class="layui-form" method="post" action="/School/AddmessageServlet" lay-filter="example">

  <div class="layui-form-item">
    <label class="layui-form-label">你的学号</label>
    <div class="layui-input-block">
      <input type="text" name="id" lay-verify="title" autocomplete="off" readonly="readonly" class="layui-input">
    </div>
  </div>
  
      <div class="layui-form-item">
    <label class="layui-form-label">选择留言老师</label>
    <div class="layui-input-block">
      <select name="teacher" id="teacher" lay-filter="aihao">
       
       <option value="杨铭熙 副教授-硕士生导师">杨明熙 副教授-硕士生导师 -网络安全-计算机网络方向</option>
		<option value="张韧 博士 -高等数学-概率论-数基理学方向">张韧 博士 -高等数学-概率论-数基理学方向</option>
		<option value="Meihua 首席架构师">Meihua 首席架构师AI-大数据-人工智能方向</option>
		<option value="刘琳琳 高级实验师">刘琳琳 高级实验师STM32机器人-实验室科研方向</option>
		<option value="向胜涛 团总支书记">向胜涛 团总支书记 大学生心理-职业规划方向</option>
		<option value="邱珊 教授">邱珊 教授 java高级 C# 面向对象方向</option>
		<option value="司晓梅 教授">司晓梅 教授 C语言-数据结构-算法研究方向</option>
		<option value="张亮 教授">张亮 教授 -马克思主义方向</option>
		<option value="周涛 科学家">周涛 科学家 -701研究所方向</option>
		<option value="李校长 党委书记">李校长 党委书记 -典礼 发表讲话</option>
       
      </select>
    </div>
  </div>
  
  
  		
  
  
  <div class="layui-form-item layui-form-text">
  
    <label class="layui-form-label">留言内容</label>
    
    <div class="layui-input-block">
    
      <textarea placeholder="想法/思路/谈心/最近遇到了那些问题"  lay-reqtext="高考分数是必填项，岂能为空？" autocomplete="off" lay-verify="required" class="layui-textarea" name="message"></textarea>
      
    </div>
    
  </div>
  
 
  <div class="layui-form-item">
    <div class="layui-input-block">
      <button class="layui-btn" lay-submit=""   >提交</button>
    </div>
  </div>
</form>
							
	</div>
  
  						
		
							
                         
							<div class="layui-tab-item">
							
							<hr class="layui-bg-green">
							
							
							
							<fieldset class="layui-elem-field">
  <legend>修改密码</legend>
  <div class="layui-field-box">
  
 
							
<form class="layui-form"   lay-filter="example">
  <div class="layui-form-item">
    <label class="layui-form-label">你的学号</label>
    <div class="layui-input-block">
      <input type="text" name="id" lay-verify="title" autocomplete="off"  readonly="readonly"  class="layui-input">
    </div>
  </div>
  
  
    <div class="layui-form-item">
    <label class="layui-form-label">原密码</label>
    <div class="layui-input-block">
      <input type="text" name="password" id="password" lay-verify="title" readonly="readonly"   autocomplete="off" class="layui-input">
    </div>
  </div>
  
  <div class="layui-form-item">
    <label class="layui-form-label">新密码</label>
    <div class="layui-input-block">
      <input type="password" name="password1" id="password1" placeholder="新的密码 建议采取数字+字符不可包括中文 6~12位" lay-verify="pass" autocomplete="off" class="layui-input">
    </div>
   
  </div>


 <div class="layui-form-item">
    <label class="layui-form-label">重复密码</label>
    <div class="layui-input-block">
      <input type="password" name="password2"  id="password2" placeholder="重复输入的密码  请与刚刚输入保持一致" lay-verify="pass" autocomplete="off" class="layui-input">
    </div>
 
  </div>
  
  
 
  
  
  
  
  <div class="layui-form-item">
    <div class="layui-input-block">
      <button class="layui-btn" lay-submit=""  onclick="updapassword()">变更</button>
    </div>
  </div>
  
	</form>
    
  </div>
</fieldset>
							
							
							
	
							</div>        
						</div>
					</div>

				</div>
			</div>

			<div class="layui-col-md4">

				<fieldset class="layui-elem-field layui-field-title"
					style="margin-top: 50px;">
					<legend>校园十五周年宣传片 </legend>

					<ul id="testBox">

						<script src="js/fz-video.js"></script>
						<script>
							var FZ_VIDEO = new createVideo(
									"testBox", //容器的id
									{
										url : 'http://www.hxut.edu.cn/uploadfile/hxut/hxutenglish.mp4', //视频地址
										autoplay : false
									//是否自动播放
									});
						</script>
						<lx> </lx>
					</ul>

				</fieldset>

			</div>

		</div>

		<script src="//res.layui.com/layui/dist/layui.js" charset="utf-8"></script>

<script type="text/javascript">
	
	
	

	
	
	
function updapassword(){
	
	if($("#password1").val()!=$("#password2").val()||$("#password1").val().length<8)
		{
		
		alert("请检查你的两次密码是否一致，或密码长度未达到要求");
		
		}
	else{
	$.post("/School/SelectStudentServlet",{"select" : <%=id%>},function(data) {
		//第一步：将字符串封装成集合对象
		var datap = eval("(" + data + ")");

	$.post("/School/UpdateStudentServlet",
				{"id" : <%=id%>,"sname" : 	datap[0].sname,"banji" : datap[0].banji,"sex" : datap[0].sex,"phone" : datap[0].phone,"password" : $("#password1").val(), "course" : datap[0].course},function(data) {
							alert(data); //接收页面发过来的成功信息
							//重新刷新一下界面
							window.location.reload();//刷新页面
				});
		
		
	});
	
	
	}
	
}
	
	
		$.post("/School/BanjiselectServlet",function(data) {
							//第一步：将字符串封装成集合对象
							var datap = eval("(" + data + ")");
							//循环遍历的里面
							for (var i = 0; i < datap.length; i++) {
								//将一个个的集合对象内容，封装到下拉列表当中
								$("#banji").append(
										"<option value="+datap[i].banji_name+">"
												+ datap[i].banji_name
												+ "</option>"); //动态添加到下拉列表
							}
						});
		
		$.post("/School/SelectCourseServlet",function(data) {
			//第一步：将字符串封装成集合对象
			var datap = eval("(" + data + ")");
			//循环遍历的里面
			for (var i = 0; i < datap.length; i++) {
				//将一个个的集合对象内容，封装到下拉列表当中
				$("#course").append(
						"<option value="+datap[i].course_name+">"
								+ datap[i].course_name
								+ "</option>"); //动态添加到下拉列表
			}
		});

				
		$.post("/School/SelectStudentServlet",{"select" : <%=id%>},function(data) {
			//第一步：将字符串封装成集合对象
			var datap = eval("(" + data + ")");
			//循环遍历的里面

			
				//将一个个的集合对象内容，封装到下拉列表当中
				$("#sname").val(datap[0].sname);	
				$("#banji").val(datap[0].banji);
				if(datap[0].sex=="男")
					{	 
					$("#sex").prop("checked",1);

					}
				else
					{
					$("#sex").prop("checked",0);
					
					}
				$("#course").val(datap[0].course);
				$("#phone").val(datap[0].phone);
				$("#password").val(datap[0].password);
			
		});
		
		
		

		
	</script>




<!-- 注意：如果你直接复制所有代码到本地，上述js路径需要改成你本地的 -->
<script>

var yanzheng=0;

layui.use(['form', 'layedit', 'laydate'], function(){
  var form = layui.form
  ,layer = layui.layer
  ,layedit = layui.layedit
  ,laydate = layui.laydate;
  
  //日期
  laydate.render({
    elem: '#date'
  });
  laydate.render({
    elem: '#date1'
  });
  
  //创建一个编辑器
  var editIndex = layedit.build('LAY_demo_editor');
 
  //自定义验证规则
  form.verify({
    title: function(value){
      if(value.length <=5){
    	  yanzheng=-1;
        return '密码至少得6个字符啊';
      }
    }
    ,pass: [
      /^[\S]{6,12}$/ 
      ,'密码必须6到12位，且不能出现空格'
    ]
    ,content: function(value){
      layedit.sync(editIndex);
      yanzheng=-1;
    }
  });
  
  //监听指定开关
  form.on('switch(switchTest)', function(data){
    layer.msg('开关checked：'+ (this.checked ? 'true' : 'false'), {
      offset: '6px'
    });
    layer.tips('温馨提示：请注意开关状态的文字可以随意定义，而不仅仅是ON|OFF', data.othis)
  });
  
  //监听提交
  form.on('submit(demo1)', function(data){
    layer.alert(JSON.stringify(data.field), {
      title: '最终的提交信息'
    })
    return false;
  });
 
  //表单初始赋值
  form.val('example', {
    "id": "<%=id%>" // "sname": "value"
    ,"interest": 1
    ,"like[write]": true //复选框选中状态
    ,"close": true //开关状态
    
    ,"desc": ""
  })
  
  
});



function complete(){
	
	 if(yanzheng!=-1)
	$.post("/School/UpdateStudentServlet",
			{"id" : <%=id%>,"sname" : 	$("#sname").val(),"banji" : $("#banji").val(),"sex" : $("input[type='radio']:checked").val(),"phone" : $("#phone").val(),"password" : $("#password").val(), "course" : $("#course").val()},function(data) {
						alert(data); //接收页面发过来的成功信息
						//重新刷新一下界面
					//	window.location.reload();//刷新页面
			});
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

	</div>






	<div style="margin-top: 50px"></div>
	<!-- footer -->
	<div class="wave-box">
		<div class="marquee-box marquee-up" id="marquee-box">
			<div class="marquee">
				<div class="wave-list-box" id="wave-list-box1">
					<ul>
						<li><img height="60" alt="波浪" src="images/wave_02.png">
						</li>
					</ul>
				</div>
				<div class="wave-list-box" id="wave-list-box2">
					<ul>
						<li><img height="60" alt="波浪" src="images/wave_02.png">
						</li>
					</ul>
				</div>
			</div>
		</div>
		<div class="marquee-box" id="marquee-box3">
			<div class="marquee">
				<div class="wave-list-box" id="wave-list-box4">
					<ul>
						<li><img height="60" alt="波浪" src="images/wave_01.png">
						</li>
					</ul>
				</div>
				<div class="wave-list-box" id="wave-list-box5">
					<ul>
						<li><img height="60" alt="波浪" src="images/wave_01.png">
						</li>
					</ul>
				</div>
			</div>
		</div>
	</div>
	<div class="footer">

		<div class="footer-floor2">

			<p>
				武汉华夏理工学院学生信息管理系统 &nbsp;&nbsp;&nbsp;来自于一位热爱生活的美华同学
				&nbsp;&nbsp;&nbsp;很高兴认识你~ </br> Copyright © 2019 Meihua <a
					href="http://www.hxsail.com/jl"  target="_blank">风华文化传媒</a>
			</p>
		</div>
	</div>
	<!-- footer end -->

	


</body>

</html>