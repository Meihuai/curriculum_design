/*
 Navicat Premium Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 50561
 Source Host           : localhost:3306
 Source Schema         : system

 Target Server Type    : MySQL
 Target Server Version : 50561
 File Encoding         : 65001

 Date: 09/12/2021 22:03:57
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for admin
-- ----------------------------
DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin`  (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `username` varchar(25) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `password` varchar(25) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of admin
-- ----------------------------
INSERT INTO `admin` VALUES (1, 'meihua', '123456');
INSERT INTO `admin` VALUES (2, '123', '123');
INSERT INTO `admin` VALUES (3, 'huazai', '123');
INSERT INTO `admin` VALUES (4, '1234', '1234');

-- ----------------------------
-- Table structure for application
-- ----------------------------
DROP TABLE IF EXISTS `application`;
CREATE TABLE `application`  (
  `fraction` int(4) NOT NULL,
  `p_name` varchar(5) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `phone` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `mail` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `date1` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `identity` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `major` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `hobby` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `ability` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `sex` varchar(5) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `other` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`identity`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of application
-- ----------------------------
INSERT INTO `application` VALUES (123123, '马飞', '15623257761', '1614086761@qq.com', '2019-05-29', '123123123123123', '暂不明确', '阅读', '写作', '男', '');
INSERT INTO `application` VALUES (605, '胡美华', '15623257761', '1614086761@qq.com', '2019-05-27', '421128199808237351', '商学院', '阅读', '写作', '男', '优录生');
INSERT INTO `application` VALUES (605, '美华', '15623257761', '1614086761@qq.com', '1998/10/12', '421189499808235156', '软件工程', '运动', '计算机', '男', '瓦罗兰大学');
INSERT INTO `application` VALUES (609, '黄超', '15623257789', '16161@qq.com', '2013-06-04', '421198199864291256', '机电学院', '写作', '写作', '女', '武汉理工大学');
INSERT INTO `application` VALUES (123, '王铮伟', '15623257761', '1614086761@qq.com', '2019-06-10', '421841199808237414', '机电学院', '阅读', '写作', '男', '');
INSERT INTO `application` VALUES (123, '文波', '15623257761', '161@qq.com', '2019-05-27', '425841199808237425', '暂不明确', '吃饭', '跑步', '男', '华中科技大学');

-- ----------------------------
-- Table structure for banji
-- ----------------------------
DROP TABLE IF EXISTS `banji`;
CREATE TABLE `banji`  (
  `banji_name` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `xueyuan` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`banji_name`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of banji
-- ----------------------------
INSERT INTO `banji` VALUES ('工商管理1161', '商学院');
INSERT INTO `banji` VALUES ('机械自动化1161', '机电工程学院');
INSERT INTO `banji` VALUES ('软件工程1161', '信息工程学院');
INSERT INTO `banji` VALUES ('软件工程1162', '信息工程学院');
INSERT INTO `banji` VALUES ('软件工程1163', '信息工程学院');
INSERT INTO `banji` VALUES ('软件工程1164', '信息工程学院');
INSERT INTO `banji` VALUES ('软件工程1191', '信息工程学院');

-- ----------------------------
-- Table structure for course
-- ----------------------------
DROP TABLE IF EXISTS `course`;
CREATE TABLE `course`  (
  `course_name` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `teacher` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `classroom` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `time` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `credit` varchar(5) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`course_name`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of course
-- ----------------------------
INSERT INTO `course` VALUES ('java', 'Meihua', '3-301', '下午七八节', '5.0');
INSERT INTO `course` VALUES ('人工智能', 'Meihua', '701实验室', '周一上午三四节', '4.5');
INSERT INTO `course` VALUES ('人性的弱点', 'Meihua', '学术报告厅', '周一晚自习', '2.5');
INSERT INTO `course` VALUES ('你还没有选择课程-请尽快选课！', '暂无', '暂无', '暂无', '暂无');
INSERT INTO `course` VALUES ('大数据与数据可视化', 'Meihua', '701实验室', '周二晚自习', '4.5');
INSERT INTO `course` VALUES ('网络安全', '杨铭熙 副教授-硕士生导师', '教学楼3-301', '下午七八节', '5.0');
INSERT INTO `course` VALUES ('计算机操作系统', '杨铭熙 副教授-硕士生导师', '232机房', '上午一二节', '5.0');
INSERT INTO `course` VALUES ('高等数学', '张韧', '2-101', '下午三四节', '5.0');

-- ----------------------------
-- Table structure for message
-- ----------------------------
DROP TABLE IF EXISTS `message`;
CREATE TABLE `message`  (
  `id` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `teacher` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `message` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of message
-- ----------------------------
INSERT INTO `message` VALUES ('161001', '杨铭熙 副教授-硕士生导师', '杨老师虽然比较严厉，但是心地也是非常好的，为了让我认真听课，才露出一副凶狠的样子，但当你如果能够完美的将她布置的任务完美完成的时候，你就会看到她那慈祥且温柔的笑容。');
INSERT INTO `message` VALUES ('161012', '张亮 教授', '张老师讲课讲的真好~');
INSERT INTO `message` VALUES ('161009', '刘琳琳 高级实验师', '琳琳老师，您正好，遇见你，三生有幸！');
INSERT INTO `message` VALUES ('161009', '向胜涛 团总支书记', '辅导员你最棒');

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student`  (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `sname` varchar(15) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `banji` varchar(15) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `sex` varchar(5) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `phone` varchar(11) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL DEFAULT '12345678',
  `password` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL DEFAULT '12345678',
  `course` varchar(25) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL DEFAULT '你还没有选择课程-请尽快选课！',
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `banji`(`banji`) USING BTREE,
  INDEX `kecheng`(`course`) USING BTREE,
  INDEX `sex`(`sex`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 162019 CHARACTER SET = utf8 COLLATE = utf8_bin ROW_FORMAT = Compact;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES (161001, '王拯为', '工商管理1161', '男', '15623289999', '123456789', 'java');
INSERT INTO `student` VALUES (161003, '文波', '软件工程1161', '男', '12345678', '12345678', '你还没有选择课程-请尽快选课！');
INSERT INTO `student` VALUES (161004, '黄超', '工商管理1161', '男', '15623259845', '12345678', 'java');
INSERT INTO `student` VALUES (161005, '风华', '软件工程1161', '男', '156232', '12345678', '你还没有选择课程-请尽快选课！');
INSERT INTO `student` VALUES (161012, '马宇翔', '软件工程1161', '男', '15623258085', '123456789', 'java');
INSERT INTO `student` VALUES (161023, 'meihua', '工商管理1161', '男', '15623257798', '12345678', 'java');
INSERT INTO `student` VALUES (161089, '黄超', '工商管理1161', '女', '243234', '12345678', '你还没有选择课程-请尽快选课！');
INSERT INTO `student` VALUES (162011, '张灯艳', '软件工程1162', '女', '15623257787', '12345678', 'java');
INSERT INTO `student` VALUES (162012, '史蒂夫', '软件工程1168', '男', '123123', '12345678', '你还没有选择课程-请尽快选课！');
INSERT INTO `student` VALUES (162017, '胡时润1', '工商管理1161', '男', '15623257761', '12345678', '你还没有选择课程-请尽快选课！');
INSERT INTO `student` VALUES (162018, '张三丰', '工商管理1161', '男', '15689745641', '12345678', '你还没有选择课程-请尽快选课！');

SET FOREIGN_KEY_CHECKS = 1;
