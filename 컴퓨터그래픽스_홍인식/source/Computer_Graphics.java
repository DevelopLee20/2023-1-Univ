import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;

public class Computer_Graphics extends JFrame{

    public Computer_Graphics() {
        add(new CGPanel());
        pack();
        setTitle("CGBoard");
        //setLayout(new FlowLayout());    //배치관리자 설정
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
    }

    public static void main(String[] args) {
        new Computer_Graphics();
    }
}

class CGPanel extends JPanel {

    private final int pix = 10;      // 픽셀 1개 가로세로 크기
    private final int numX = 30;   // 제1사분면 x 좌표 범위
    private final int numY = 30;   // 제1사분면 y 좌표 범위
    private final int sizeX = numX*pix; // 모눈종이 x축 크기
    private final int sizeY = numY*pix; // 모눈종이 y축 크기
    private ArrayList<xypos> arr;
    private panel_graph gpanel;

    CGPanel() {
        setLayout(new FlowLayout());
        gpanel = new panel_graph();
        add(gpanel);
        add(new panel_control());
        arr = new ArrayList<>();
    }

    //(x,y)좌표 점 클래스
    class xypos{
        int x, y;
        public xypos(int x, int y){
            this.x = x;
            this.y = y;
        }
    }

    class panel_graph extends JPanel{
        panel_graph(){
            //모눈종이 끝 선 안잘리게 패널 크기를 모눈종이보다 조금 더 크게 한다.
            setPreferredSize(new Dimension((sizeX+1)*2, (sizeY+1)*2));
        }

        public void paintComponent(Graphics g){     // g는 GraphicsContext 객체
            super.paintComponent(g);
            Graphics2D g2 = (Graphics2D)g;
            g2.translate(sizeX,sizeY);      // 원점을 (sizeX,sizeY)로 이동.
            g2.setColor(Color.BLACK);
            //모눈종이 가로세로줄 그리기
            //좌표평면 그리기
            g2.setStroke(new BasicStroke(1));  //stroke : 도형 테두리 설정. 내부채우기설정은 setFill.
            for(int i=-sizeY; i<=sizeY; i+=pix){
                g2.drawLine(-sizeX, i, sizeX, i);
            }
            for(int i=-sizeX; i<=sizeX; i+=pix){
                g2.drawLine(i, -sizeY, i, sizeY);
            }
            // x,y축 그리기(굵은 선)
            g2.setStroke(new BasicStroke(2));
            g2.drawLine(-sizeX, 0, sizeX, 0);
            g2.drawLine(0, -sizeY, 0, sizeY);
            //그림 그리기
            for(xypos p : arr){
                g2.fillRect(p.x*pix, -(p.y+1)*pix, pix, pix);   // 네모는 왼쪽위에서 아래로 그림
            }
        }
    }
    class panel_control extends JPanel{
        JTextField x1, y1, x2, y2;
        JButton btn1, btnClear;

        panel_control(){
            setPreferredSize(new Dimension(300, 100));
            x1 = new JTextField();  //좌표값 입력 텍스트필드
            y1 = new JTextField();
            x2 = new JTextField();
            y2 = new JTextField();
            btn1 = new JButton("DDA");
            btnClear = new JButton("Clear");

            setLayout(new GridLayout(0, 4, 2, 2));    // 격자 형태 레이아웃
            add(new JLabel("    X1   Y1"));
            add(x1);
            add(y1);
            add(btn1);
            add(new JLabel("    X2   Y2"));
            add(x2);
            add(y2);
            add(btnClear);

            btn1.addActionListener(e -> {
	// 여기에다 DDA 알고리즘 호출
                gpanel.repaint();
                //arr.clear();    //좌표리스트 초기화
            });
            btnClear.addActionListener(e -> {
                arr.clear();    //좌표리스트 초기화
                gpanel.repaint();
            });
        }
    }
}
