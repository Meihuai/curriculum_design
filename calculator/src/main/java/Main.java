/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package main.java;

import javax.swing.*;

/**
 * @author meihua
 */
public class Main {

    public static void main(String[] args) {
        Calculator win = new Calculator();
        win.setTitle("计算器");
        win.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        win.pack();
        win.setLocation(500, 300);
        win.setVisible(true);
    }

}
