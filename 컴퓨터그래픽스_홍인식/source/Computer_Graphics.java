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
    int global_size = count*gap;

    public DotFrame(){
        this.setTitle("drawing");
        this.setDefaultCloseOperation((JFrame.EXIT_ON_CLOSE));
        this.setSize(1000,600);
        this.setVisible(true);
        // this.add(new Khan()); 씹힘
        this.add(new DDA_Alg(0,0,8,10));
    }

    // 기본창 생성
    class Khan extends JPanel{
        public void paintComponent(Graphics g){
            super.paintComponent(g);
            g.setColor(Color.gray);
            
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
            float m = (float)dy/(float)dx;

            // case2: 1 > m
            if( 1 > m ){
                float y = 0;
                for(int x=x1; x<x2; x++){
                    y = y + m;
                    if(y%1 > 0.5){
                        g.fillRect(gap*x, global_size - ((int)y+1)*gap, gap, gap);
                    }
                    else{
                        g.fillRect(gap*x, global_size - (int)y*gap, gap, gap);
                    }
                }
            }

            // case1: 1 < m
            if( 1 < m ){
                float x = 0;
                for(int y=y1; y<y2; y++){
                    x = x + m;
                    if(x%1 > 0.5){
                        g.fillRect(((int)x+1)*gap, global_size - y*gap, gap, gap);
                    }
                    else{
                        g.fillRect((int)x*gap, global_size - y*gap, gap, gap);
                    }
                }
            }
        }
    }
}