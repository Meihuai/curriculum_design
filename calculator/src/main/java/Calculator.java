package main.java;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;


public class Calculator extends JFrame implements ActionListener {
    JMenuBar panel5;
    JComboBox cbxSex;
    String s;
    private boolean firstDigit = true;//第一个数字
    private double temp;//存储中间结果
    private String operator = "=";//当前操作符
    private boolean validOperateFlag = false;//是否为有效操作
    private int more, jj = 0;
    public String zhong = "";
    public String lishi = "";
    public String jilu = "";
    private String clipBoard = null;
    String[] lishijilu = {"历史记录为空", " 历史记录为空", " 历史记录为空", " 历史记录为空", " 历史记录为空"};

    JButton btnComputeTotal;
    JLabel lbID, lbName, lbSex, lbAge, lbComputer_Score, lbMath_Score, lbEnglish_Score, lbTotalScore, lbAveScore;
    JTextField tfID, tfName, tfGender, tfAge, tfComputer_Score, tfMath_Score, tfEnglish_Score, tfTotalScore, tfAveScore;
    JMenu editMenu = new JMenu("功能(F)");
    JMenu edit = new JMenu("一键换肤");
    JMenu ppp = new JMenu("帮助");
    //editMenu.setAccelerator(KeyStroke.getKeyStroke("F"));
    //   edit.setAccelerator(KeyStroke.getKeyStroke("O"));
    //   ppp.setAccelerator(KeyStroke.getKeyStroke("E"));


    JMenuItem pase = new JMenuItem("经典黑红");
    JMenuItem paste = new JMenuItem("粉色少女");
    JMenuItem fuzhi = new JMenuItem("复制");
    JMenuItem zhantie = new JMenuItem("粘贴");
    JMenuItem pastes = new JMenuItem("经典白黑");
    JMenuItem pasteItem = new JMenuItem("关于");
    JMenuItem yuyan = new JMenuItem("语言");
    JMenuItem  record = new JMenuItem("历史记录");
    JTextField tfResult, tfo;
    final String[] KEYS = {"7", "8", "9", "/", "%", "4", "5", "6", "*", "1/x", "1", "2", "3", "-", "=", "0", ".", "π", "+", "x²"};
    JButton[] buttons = new JButton[KEYS.length];


    JPanel panel1, panel2, panel0;
    final String[] COMMANDS = {"←", "CE", "C", "±", "√"};
    JButton[] buttonss = new JButton[COMMANDS.length];


    public Calculator() {
        panel5 = new JMenuBar();
        editMenu.add( record);
         record.addActionListener(this);
         record.setAccelerator(KeyStroke.getKeyStroke("F"));
        editMenu.add(fuzhi);
        fuzhi.addActionListener(this);
        fuzhi.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_C, InputEvent.CTRL_MASK));
        editMenu.add(zhantie);
        zhantie.addActionListener(this);
        zhantie.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_V, InputEvent.CTRL_MASK));

        ppp.add(pasteItem);
        pasteItem.addActionListener(this);
        pasteItem.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_O, InputEvent.CTRL_MASK));

        ppp.add(yuyan);
        yuyan.addActionListener(this);
        yuyan.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_P, InputEvent.CTRL_MASK));

        edit.add(paste);
        paste.addActionListener(this);
        paste.setAccelerator(KeyStroke.getKeyStroke("F1"));
        edit.add(pase);
        pase.addActionListener(this);
        pase.setAccelerator(KeyStroke.getKeyStroke("F2"));

        edit.add(pastes);
        pastes.addActionListener(this);
        pastes.setAccelerator(KeyStroke.getKeyStroke("F3"));


        lbID = new JLabel(" JAVA 简易计算器V1.0 ");

        ;
        tfo = new JTextField("0", 1);
        tfo.setHorizontalAlignment(JTextField.RIGHT);
        tfo.setEditable(false);
        tfo.setBackground(Color.WHITE);

        tfResult = new JTextField("0", 24);
        tfResult.setHorizontalAlignment(JTextField.RIGHT);
        tfResult.setEditable(false);
        tfResult.setBackground(Color.WHITE);
        panel1 = new JPanel();

        panel5.add(editMenu);
        panel5.add(edit);
        panel5.add(ppp);


        panel1.add(tfResult);
        panel1.add(lbID);

        panel1.setLayout(new GridLayout(0, 1));
        lbID.setForeground(Color.RED);
        panel5.add(tfo);
        panel2 = new JPanel();
        panel2.setLayout(new GridLayout(0, 5));
        panel1.setBackground(Color.black);
        panel2.setForeground(Color.black);

        for (int i = 0; i < COMMANDS.length; i++) {
            buttonss[i] = new JButton(COMMANDS[i]);
            panel2.add(buttonss[i]);

            buttonss[i].setForeground(Color.red);
            buttonss[i].setBackground(Color.black);
            buttonss[i].addActionListener(this);
        }

        for (int i = 0; i < KEYS.length; i++) {
            buttons[i] = new JButton(KEYS[i]);
            panel2.add(buttons[i]);

            buttons[i].setForeground(Color.red);
            buttons[i].setBackground(Color.black);

            buttons[i].addActionListener(this);
        }


        add(panel5, BorderLayout.NORTH);
        add(panel1, BorderLayout.CENTER);
        add(panel2, BorderLayout.SOUTH);

    }


    @Override
    public void actionPerformed(ActionEvent ae) {
        if (jj == 4)
            jj = 1;
        else ;
        this.lishijilu[jj] = jilu + lishi;

        if (ae.getSource() == paste) {
            panel1.setBackground(Color.PINK);
            panel2.setForeground(Color.green);
            lbID.setForeground(Color.RED);
            for (int i = 0; i < COMMANDS.length; i++) {
                buttonss[i].setForeground(Color.RED);
                buttonss[i].setBackground(Color.PINK);
            }

            for (int i = 0; i < KEYS.length; i++) {
                buttons[i].setForeground(Color.RED);//字体
                buttons[i].setBackground(Color.PINK);//按钮背景
            }
        } else if (ae.getSource() == pase) {//一键换肤 经典黑红
            panel1.setBackground(Color.BLACK);
            panel2.setForeground(Color.black);
            lbID.setForeground(Color.RED);
            for (int i = 0; i < COMMANDS.length; i++) {
                buttonss[i].setForeground(Color.red);
                buttonss[i].setBackground(Color.black);
            }
            for (int i = 0; i < KEYS.length; i++) {
                buttons[i].setForeground(Color.red);
                buttons[i].setBackground(Color.black);
            }

        } else if (ae.getSource() == yuyan) {//设置语言

            Object[] obj2 = {"C语言", "Java", "phytion", "中文"};
            String s = (String) JOptionPane.showInputDialog(null, "请选择你的语言:\n", "语言设置", JOptionPane.PLAIN_MESSAGE, new ImageIcon("icon.png"), obj2, "中文");


        } else if (ae.getSource() == pasteItem) //关于计算器
        {
            int n = JOptionPane.showConfirmDialog(null, "            欢迎使用华仔计算器！\n        \n\n功能：\n 历史记录功能 \n 支持一键换肤\n 开源可修改\n 作者：meihua \n 更新地址：www.mmh9.com\n\n@月醉风华  作者QQ1614086761", "关于计算器", JOptionPane.YES_NO_OPTION);

        } else if (ae.getSource() ==  record) {            //打开 record窗口
            JStudentWindow win = new JStudentWindow(lishijilu);
            win.setLayout(new GridLayout(0, 1));
            win.setLocation(700, 300);//新窗口在屏幕中出现的位置
            win.getContentPane().setBackground(Color.cyan);
            win.setTitle("历史记录");//新窗口标题
            win.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE); //新窗口关闭操作
            win.pack();
            win.setVisible(true);
        } else if (ae.getSource() == pastes) //经典黑白换肤
        {
            panel1.setBackground(Color.white);
            panel2.setForeground(Color.white);
            lbID.setForeground(Color.black);
            for (int i = 0; i < COMMANDS.length; i++) {
                buttonss[i].setForeground(Color.white);
                buttonss[i].setBackground(Color.black);
            }
            for (int i = 0; i < KEYS.length; i++) {
                buttons[i].setForeground(Color.white);
                buttons[i].setBackground(Color.black);
            }
        } else if (ae.getSource() == fuzhi) {
            clipBoard = tfo.getText();
        } else if (ae.getSource() == zhantie) {
            if (clipBoard != null)
                tfo.setText(clipBoard);
        }
        String key = ae.getActionCommand();
        if (key.equals(COMMANDS[0]))
            handleBackSpace0();
        else if (key.equals(COMMANDS[1])) {
            handleBackSpaceC();
        } else if (key.equals(COMMANDS[2])) {
            handleBackSpace();
        } else if (key.equals(COMMANDS[3])) {
            handleBackSpace3(ae);
        } else if (key.equals(COMMANDS[4])) {
            handleBackSpace4(ae);
        } else if ("0123456789.".indexOf(key) > -1) {
            handleNumber(ae);
        } else if ("+-=*/%1/xπx²".indexOf(key) > -1)
            handleOperator(ae);


    }

    private void handleBackSpace0() {
        String pt = "";
        pt = tfo.getText();
        String text = tfo.getText();
        int i = text.length();
        if (zhong.length() > 0 && more == 1) {
            zhong = zhong.substring(0, zhong.length() - 1);
            tfResult.setText(zhong);
        } else tfResult.setText(zhong);
        ;
        if (i > 1 || pt.length() > 1) {

            pt = pt.substring(0, pt.length() - 1);
            tfo.setText(pt);
            temp = Double.parseDouble(tfo.getText());

        } else {
            tfo.setText("0");
            temp = Double.parseDouble(tfo.getText());
        }
    }

    private void handleBackSpaceC() {
        tfo.setText("0");
        this.s = "";
        //  zhong="";
        //   tfResult.setText(zhong);
        firstDigit = true;//第一个数字
//   temp=0;//存储中间结果
        //  operator = "=";//当前操作符
        validOperateFlag = false;//是否为有效操作


    }


    private void handleBackSpace() {
        tfo.setText("0");
        this.s = " ";
        zhong = "欢迎使用华仔计算器";

        tfResult.setText(zhong);
        zhong = "";
        firstDigit = true;//第一个数字
        temp = 0;//存储中间结果
        operator = "=";//当前操作符
        validOperateFlag = false;//是否为有效操作


    }

    private void handleBackSpace3(ActionEvent ae) {
        String key = ae.getActionCommand();
        temp = Double.parseDouble(tfo.getText()) * -1;
        tfo.setText(Double.toString(temp));
        operator = key;
        firstDigit = true;
        validOperateFlag = true;
    }


    private void handleBackSpace4(ActionEvent ae) {
        String key = ae.getActionCommand();
        temp = Math.sqrt(Double.parseDouble(tfo.getText()));
        tfo.setText(Double.toString(temp));
        operator = key;
        firstDigit = true;
        validOperateFlag = true;
    }


    private void handleNumber(ActionEvent ae) {
        String key = ae.getActionCommand();
        more = 1;
        if (firstDigit == true) {
            tfo.setText(key);
            zhong += ae.getActionCommand();
        } else if (key.equals(".") && tfo.getText().indexOf(".") < 0) {
            tfo.setText(tfo.getText() + ".");
            zhong += ae.getActionCommand();
        } else if (!key.equals(".")) {
            tfo.setText(tfo.getText() + key);
            zhong += ae.getActionCommand();
        }
        firstDigit = false;

        tfResult.setText(zhong);
    }

    private void handleOperator(ActionEvent ae) {
        String key = ae.getActionCommand();
        if (more == 1) {
            more = 0;
            switch (operator) {
                case "+":
                    temp += Double.parseDouble(tfo.getText());
                    zhong += ae.getActionCommand();
                    break;
                case "-":
                    temp -= Double.parseDouble(tfo.getText());
                    zhong += ae.getActionCommand();
                    break;
                case "/":
                    temp /= Double.parseDouble(tfo.getText());
                    zhong += ae.getActionCommand();
                    break;
                case "=":
                    temp = Double.parseDouble(tfo.getText());
                    zhong += ae.getActionCommand();
                    jj++;
                    break;
                case "*":
                    temp *= Double.parseDouble(tfo.getText());
                    zhong += ae.getActionCommand();
                    break;
                case "%":
                    temp = temp % Double.parseDouble(tfo.getText());
                    zhong += ae.getActionCommand();
                    break;

            }
        } else ;
        if (ae.getActionCommand() == "1/x") {

            temp = 1 / Double.parseDouble(tfo.getText());
        } else if (ae.getActionCommand() == "π") {
            zhong = "3.1415926535";
            tfo.setText(zhong);
        } else if (ae.getActionCommand() == "x²")
            temp = Double.parseDouble(tfo.getText()) * Double.parseDouble(tfo.getText());
        else ;
        long t1;
        double t2;
        t1 = (long) temp;
        t2 = temp - t1;

        if (t2 == 0) {
            tfo.setText(String.valueOf(t1));


        } else tfo.setText(Double.toString(temp));
        tfResult.setText(zhong);
        lishi = tfo.getText();
        jilu = tfResult.getText();
        operator = key;
        firstDigit = true;
        validOperateFlag = true;


    }

    public String a() {
        return lishi;
    }


}
