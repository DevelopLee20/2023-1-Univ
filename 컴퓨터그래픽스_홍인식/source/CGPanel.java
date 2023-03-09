import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;

public class CGPanel extends JPanel {

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

    // (x,y)좌표 점 클래스
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
            g2.setColor(Color.gray);
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
            g2.setColor(Color.BLACK);
            g2.setStroke(new BasicStroke(2));
            g2.drawLine(-sizeX, 0, sizeX, 0);
            g2.drawLine(0, -sizeY, 0, sizeY);
            //그림 그리기
            for(xypos p : arr){
                g2.fillRect(p.x*pix, -(p.y+1)*pix, pix, pix);
            }
        }
    }
    class panel_control extends JPanel{
        JTextField x1, y1, x2, y2;
        JButton btn1, btnClear;
        int int_x1, int_y1, int_x2, int_y2;

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
                int_x1 = Integer.parseInt(x1.getText());
                int_y1 = Integer.parseInt(y1.getText());
                int_x2 = Integer.parseInt(x2.getText());
                int_y2 = Integer.parseInt(y2.getText());
                new DDA_Alg(int_x1, int_y1, int_x2, int_y2);

                gpanel.repaint();
            });
            btnClear.addActionListener(e -> {
                arr.clear();
                gpanel.repaint();
            });
        }

        class DDA_Alg{
            private int x1, y1, x2, y2;
            private float m;
            private boolean m_bool;

            DDA_Alg(int x1, int y1, int x2, int y2){
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;
                m = (float)(y2-y1) / (float)(x2-x1);
                m_bool = (1 > m);
                xyget();
            }

            public int return_int(float value){
                if(value % 1 > 0.5){
                    return (int)value + 1;
                }
                else{
                    return (int)value;
                }
            }

            public void xyget(){
                if(m_bool){
                    float y = y1;
                    for(int x=x1; x<=x2; x++){
                        arr.add(0, new xypos(x, return_int(y)));
                        y += m;
                    }
                }
            }
        }
    }
}
