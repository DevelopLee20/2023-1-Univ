package source;
import java.awt.*;
import javax.swing.*;

public class Computer_Graphics {
    public static void main(String args[]){
        DotFrame test = new DotFrame();
    }
}

// 창 생성
class DotFrame extends JFrame{
    int gap = 10;
    int count = 40;
    int Khan_start_y = 20;
    int Khan_width = 10;
    int Khan_height = 10;

    public DotFrame(){
        System.out.println("Debug Test in DotFrame");
        this.setTitle("drawing");
        this.setDefaultCloseOperation((JFrame.EXIT_ON_CLOSE));
        this.setSize(1000,600);
        this.add(new Khan());
        // this.add(new DDA_Alg(0, 0, 8, 10));
        this.setVisible(true);
    }

    // 기본 도트창 생성
    class Khan extends JPanel{
        public void paintComponent(Graphics g){
            super.paintComponent(g);
            g.setColor(Color.gray);
            System.out.println("Debug Test in Khan");
            for(int i=0; i<count; i++){
                int Khan_start_x = 20;
                
                for(int j=0; j<count; j++){
                    g.drawRect(Khan_start_x, Khan_start_y, Khan_width, Khan_height);
                    Khan_start_x += gap;
                }
                Khan_start_y += gap;
            }
        }
    }

    // DDA 알고리즘
    class DDA_Alg extends JPanel{
        int x1, x2, y1, y2;
        public DDA_Alg(int x1, int y1, int x2, int y2){
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public void paintComponent(Graphics g){
            super.paintComponent(g);
            g.setColor(Color.black);
            int dx = x2-x1;
            int dy = y2-y1;
            float m = dy/dx;
            System.out.println("Debug Test in DDA");

            // case2: 1 > m
            if(dx > dy){
                for(int i=x1; i<x2; i++){
                    System.out.println("Debug Test in case2");
                    if((m%1 - m) > 0.5){
                        g.fillRect(i, (int)(gap*count - m)+1, gap, gap);
                    }
                    else{
                        g.fillRect(i, (int)(gap*count - m), gap, gap);
                    }
                }
            }
            // case1: 1 < m
            else if(dx < dy){
                for(int i=y1; i<y2; i++){
                    System.out.println("Debug Test in case1");
                    if((m%1 - m) > 0.5){
                        g.fillRect((int)m+1, gap*count-i, gap, gap);
                    }
                    else{
                        g.fillRect((int)m, gap*count-i, gap, gap);
                    }
                }
            }
        }
    }
}