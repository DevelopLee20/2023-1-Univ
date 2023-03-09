import java.awt.*;
import javax.swing.*;

public class Computer_Graphics{
    public static void main(String args[]){
        new MyFrame();
    }
}

// 화면 출력기
class MyFrame extends JFrame{
    int rect_size = 10;
    int rect_count = 40;
    int start_x = 20;
    int start_y = 20;
    int global_size = rect_size * rect_count + start_y;
    Graphics g;

    public MyFrame(){
        // this : JFrame : 출력된 화면
        this.setTitle("Drawing");
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setSize(1000,600);
        this.setVisible(true);
    }

    @Override
    public void paint(Graphics g){
        this.g = g;
        paint_dot(this.g);
        paint_Alg(this.g);
    }

    public int reverse_y(int y){
        return global_size - y;
    }

    // 모눈 종이 생성
    public void paint_dot(Graphics g){
        int paint_x = this.start_x;
        int paint_y = this.start_y;

        g.setColor(Color.gray);
        for(int i=0; i<this.rect_count; i++){
            for(int j=0; j<this.rect_count; j++){
                g.drawRect(paint_x, reverse_y(paint_y), this.rect_size, this.rect_size);
                paint_x += this.rect_size;
            }
            paint_x = this.start_x;
            paint_y += this.rect_size;
        }
    }

    // 테스트 버전
    public void paint_Alg(Graphics g){
        g.clearRect(0, 0, 1000, 600);
        paint_dot(g);

        g.setColor(Color.black);
        for(int i=0; i<3; i++){
            g.fillRect(30, reverse_y(30), this.rect_size, this.rect_size);
        }
    }

    // DDA 알고리즘
    public void DDA_Alg(Graphics g){

    }
}