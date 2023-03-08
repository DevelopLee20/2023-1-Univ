import java.awt.*;
import javax.swing.*;
JFrame 클래스
JFrame.setTitle("drawing");
JFrame.setDefaultCloseOperation((JFrame.EXIT_ON_CLOSE));
JFrame.setSize(1000,600);
JFrame.setVisible(true);
JFrame.add(객체);


JPanel 클래스
paintComponent(Graphics g) - 오버라이딩
g.setColor(색상);
g.fillRect(x좌표, y좌표, 넓이, 높이)
g.drawRect(x좌표, y좌표, 넓이, 높이)
repaint();