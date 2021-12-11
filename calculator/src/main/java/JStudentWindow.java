/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package main.java;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class JStudentWindow extends JFrame {


    String[] i = new String[5];
    JLabel lbID, lbName, lbSex, lbAge, lbComputer_Score, lbMath_Score, lbEnglish_Score, lbTotalScore, lbAveScore;

    public JStudentWindow(String[] lishijilu) {
//构造函数
        //加入你的代码: 定义各种组件并将它们加入容器中。
        lbID = new JLabel("JAVA 简易计算器V1.0    ");
        add(lbID);
        lbName = new JLabel("meihua  ");
        add(lbName);
        lbSex = new JLabel("历史记录：" + lishijilu[1]);
        add(lbSex);
        lbAge = new JLabel("历史记录：" + lishijilu[2]);
        add(lbAge);
        lbComputer_Score = new JLabel("历史记录：" + lishijilu[3]);
        add(lbComputer_Score);

        lbAveScore = new JLabel("                           注意： ");
        add(lbAveScore);

        lbMath_Score = new JLabel("       退出时历史记录会置零 版权所有@风华无双            ");
        add(lbMath_Score);
        lbEnglish_Score = new JLabel("        历史记录最多只能保存三条哦   ");
        add(lbEnglish_Score);

        lbTotalScore = new JLabel("    多余三条时会替换最先保存的历史记录哦！ ");
        add(lbTotalScore);

    }

}