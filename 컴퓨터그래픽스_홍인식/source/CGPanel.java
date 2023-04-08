import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;
import java.awt.event.*;

public class CGPanel extends JPanel{

    private final int pix = 10;      // 픽셀 1개 가로세로 크기
    private final int numX = 30;   // 제1사분면 x 좌표 범위
    private final int numY = 30;   // 제1사분면 y 좌표 범위
    private final int sizeX = numX*pix; // 모눈종이 x축 크기
    private final int sizeY = numY*pix; // 모눈종이 y축 크기
    public ArrayList<xypos> arr;
    public ArrayList<xypos> click_arr;
    private panel_graph gpanel;
    private panel_control gcontrol;
    public xypos mid_point;

    CGPanel() {
        click_arr = new ArrayList<>();
        arr = new ArrayList<>();

        setLayout(new FlowLayout());
        gpanel = new panel_graph();
        add(gpanel);
        gcontrol = new panel_control();
        add(gcontrol);


        gcontrol.BSH_Button.setEnabled(false);

        // 좌표 클릭시 인식
        addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e){
                int x = (e.getX() - 300) / pix;
                int y = (300 - e.getY()) / pix;
                click_arr.add(0, new xypos(x, y));

                System.out.println("addMouseListener 실행");
                System.out.println(click_arr.size());
                System.out.println(x);
                System.out.println(y);
                System.out.println("addMouseListener 실행 완료");

                gpanel.repaint();
            }
        });
    }

    class DDA{
        public DDA(int xa, int ya, int xb, int yb){
            int dx = xb - xa;
            int dy = yb - ya;
            int steps;
            float x = xa;
            float y = ya;
            float xIncrement, yIncrement;

            System.out.println("DDA 실행");

            if(Math.abs(dx) > Math.abs(dy)){
                steps = Math.abs(dx);
            }
            else{
                steps = Math.abs(dy);
            }

            xIncrement = dx / (float)steps;
            yIncrement = dy / (float)steps;

            arr.add(0, new xypos(round(x), round(y)));

            for(int k=0; k<steps; k++){
                x += xIncrement;
                y += yIncrement;
                arr.add(0, new xypos(round(x), round(y)));
                System.out.println("좌표가 저장됨");
            }
            System.out.println("DDA 종료됨");
        }

        public int round(float a){
            return (int)(a + 0.5);
        }
    }

    class BSH{
// 브레센헴은 애초에 기울기가 1보다 작아야한다.
        public BSH(int xa, int ya, int xb, int yb){
            boolean change;

            if(Math.abs(xb - xa) < Math.abs(yb - ya)){
                change = true;
                int temp = xa;
                xa = ya;
                ya = temp;

                temp = xb;
                xb = yb;
                yb = temp;
            }
            else{
                change = false;
            }

            int dx = Math.abs(xa - xb);
            int dy = Math.abs(ya - yb);
            int p = 2 * dy - dx;
            int twoDy = 2 * dy;
            int twoDyDx = 2 * (dy - dx);
            int x, y, xEnd, Dy;

            System.out.println("twoDy, twoDyDx values");
            System.out.println(twoDy);
            System.out.println(twoDyDx);
            System.out.println("twoDy, twoDyDx values end");

            if(xa > xb){
                x = xb;
                y = yb;
                xEnd = xa;
            }
            else{
                x = xa;
                y = ya;
                xEnd = xb;
            }

            if(change){
                arr.add(0, new xypos(y, x));
            }
            else{
                arr.add(0, new xypos(x, y));
            }

            if(ya <= yb){
                Dy = 1;
            }
            else{
                Dy = -1;
            }

            while(x < xEnd){
                x += 1;

                // 증가 그래프, 감소 그래프에 대한 판단이 없어 추가함
                if(p < 0){
                    p += twoDy;
                }
                else{
                    y += Dy;
                    p += twoDyDx;
                }
                System.out.println("Breseham cal values");
                System.out.println(x);
                System.out.println(y);
                System.out.println(p);
                System.out.println("Breseham cal values end");

                if(change){
                    arr.add(0, new xypos(y, x));
                }
                else{
                    arr.add(0, new xypos(x, y));
                }
            }
        }
    }

    class MEA{
        public MEA(int x1, int y1, int radian) {
            int x = 0;
            int y = radian;
            int p = 1 - radian;
            
            // 좌표 세이브
            CirclePlotPoints(x1, y1, x, y);
    
            while(x < y){
                x++;
    
                if(p < 0){
                    p += 2 * x + 1;
                }
                else{
                    y--;
                    p += 2 * (x - y) + 1;
                }
                // 좌표 세이브
                CirclePlotPoints(x1, y1, x, y);
            }
        }
        void CirclePlotPoints(int xCenter, int yCenter, int x, int y){
            arr.add(0, new xypos(xCenter + x, yCenter + y));
            arr.add(0, new xypos(xCenter - x, yCenter + y));
            arr.add(0, new xypos(xCenter + x, yCenter - y));
            arr.add(0, new xypos(xCenter - x, yCenter - y));
            arr.add(0, new xypos(xCenter + y, yCenter + x));
            arr.add(0, new xypos(xCenter - y, yCenter + x));
            arr.add(0, new xypos(xCenter + y, yCenter - x));
            arr.add(0, new xypos(xCenter - y, yCenter - x));
        }
    }

    class MATRIX{
        public int[] Mat_cal(int[] mat1, int[][] mat2){
            int[] result = new int[3];

            for(int j=0; j<3; j++){
                for(int k=0; k<3; k++){
                    result[j] += mat1[k] * mat2[k][j];
                }
            }
            return result;
        }

        public int[] Mat_cal(int[] mat1, double[][] mat2){
            int[] result = new int[3];

            for(int j=0; j<3; j++){
                for(int k=0; k<3; k++){
                    result[j] += mat1[k] * mat2[k][j];
                }
            }
            return result;
        }

        public void Mat_print(int[] mat1){
            for(int j=0; j<3; j++){
                System.out.print("[" + mat1[j] + "] ");
            }
            System.out.println();
        }

        public void Mat_move(int dx, int dy){
            int[][] move = {
                {1,0,0},
                {0,1,0},
                {dx,dy,1}
            };

            ArrayList<xypos> temp = new ArrayList<>();

            for(xypos p : arr){
                int[] mat = {p.x, p.y, 1};
                int[] result = Mat_cal(mat, move);

                temp.add(0, new xypos(result[0], result[1]));
                System.out.println("Mat_cal(mat, move)");
                Mat_print(result);
            }
            arr = temp;
        }

        public void Mat_rotation(double seta){
            int x = mid_point.x;
            int y = mid_point.y;

            int[][] move1 = {
                {1, 0, 0},
                {0, 1, 0},
                {-x, -y, 1}
            };
            int[][] rotation = {
                {round(Math.cos(seta)), round(Math.sin(seta)), 0},
                {-round(Math.sin(seta)), round(Math.cos(seta)), 0},
                {0, 0, 1}
            };
            int[][] move2 = {
                {1, 0, 0},
                {0, 1, 0},
                {x, y, 1}
            };

            ArrayList<xypos> temp = new ArrayList<>();

            for(xypos p : arr){
                int[] mat = {p.x, p.y, 1};
                int[] result = Mat_cal(mat, move1);
                result = Mat_cal(result, rotation);
                result = Mat_cal(result, move2);

                temp.add(0, new xypos(result[0], result[1]));
                System.out.println("Mat_cal(mat, move)");
                Mat_print(result);
            }
            arr = temp;
        }

        public void Mat_arbitray_scale(int a){

        }

        public int round(double a){
            return (int)(a + 0.5);
        }
    }

    class SAM{
        SAM(int xa, int ya, int xb, int yb, int xc, int yc){
            DDA(xa, ya, xb, yb);
            DDA(xb, yb, xc, yc);
            DDA(xc, yc, xa, ya);
        }

        public void DDA(int xa, int ya, int xb, int yb) {
            int dx = xb - xa;
            int dy = yb - ya;
            int steps;
            float x = xa;
            float y = ya;
            float xIncrement, yIncrement;
    
            System.out.println("dx, dy value: ");
            System.out.println(dx);
            System.out.println(dy);
            System.out.println("dx, dy value end");
    
            if(Math.abs(dx) > Math.abs(dy)){
                steps = Math.abs(dx);
            }
            else{
                steps = Math.abs(dy);
            }
    
            xIncrement = dx / (float)steps;
            yIncrement = dy / (float)steps;
    
            arr.add(0, new xypos(round(x), round(y)));
    
            System.out.print("steps value: ");
            System.out.println(steps);
    
            for(int k=0; k<steps; k++){
                x += xIncrement;
                y += yIncrement;
                arr.add(0, new xypos(round(x), round(y)));
            }
        }
    
        public int round(float a){
            return (int)(a + 0.5);
        }
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

        @Override
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

            // 그림 그리기
            for(xypos p : arr){
                System.out.println("그림그리기");
                g2.fillRect(p.x*pix, -(p.y+1)*pix, pix, pix);   // 네모는 왼쪽위에서 아래로 그림
            }

            for(xypos p : click_arr){
                System.out.println("그림그리기");
                g2.fillRect(p.x*pix, -(p.y+1)*pix, pix, pix);
            }

            gcontrol.DDA_Button.setEnabled(click_arr.size() == 2);
            gcontrol.BSH_Button.setEnabled(click_arr.size() == 2);
            gcontrol.MEA_Button.setEnabled(click_arr.size() == 1 && !gcontrol.MEA_radian.getText().isEmpty());
            gcontrol.SAM_Button.setEnabled(click_arr.size() == 3);
            gcontrol.MOVE_Button.setEnabled(arr.size() != 0 && !gcontrol.MOVE_pointx.getText().isEmpty() && !gcontrol.MOVE_pointy.getText().isEmpty());
            gcontrol.ROTATO_Button.setEnabled(arr.size() != 0 && !gcontrol.Rotate_seta.getText().isEmpty());
        }
    }

    class panel_control extends JPanel{
        JButton DDA_Button = new JButton("DDA");
        JButton BSH_Button = new JButton("BSH");
        JButton MEA_Button = new JButton("MEA");
        JButton SAM_Button = new JButton("삼각형");
        JButton clear_Button = new JButton("Clear");
        JButton MOVE_Button = new JButton("MOVE");
        JButton ROTATO_Button = new JButton("ROTATO");

        JLabel Label_radian = new JLabel("Radian");
        JTextField MEA_radian = new JTextField();

        JTextField MOVE_pointx = new JTextField();
        JTextField MOVE_pointy = new JTextField();

        JLabel Label_seta = new JLabel("Seta");
        JTextField Rotate_seta = new JTextField();

        panel_control(){
            setPreferredSize(new Dimension(300, 300));
            setLayout(new GridLayout(0, 3, 2, 2));    // 격자 형태 레이아웃
            
            add(DDA_Button);
            add(BSH_Button);
            add(SAM_Button);
            add(MEA_Button);
            add(Label_radian);
            add(MEA_radian);
            add(MOVE_Button);
            add(MOVE_pointx);
            add(MOVE_pointy);
            add(ROTATO_Button);
            add(Label_seta);
            add(Rotate_seta);
            add(clear_Button);

            ROTATO_Button.addActionListener(e->{
                new MATRIX().Mat_rotation(Integer.parseInt(Rotate_seta.getText()));
                gpanel.repaint();
            });

            MOVE_Button.addActionListener(e->{
                new MATRIX().Mat_move(Integer.parseInt(MOVE_pointx.getText()), Integer.parseInt(MOVE_pointy.getText()));
                mid_point.x = Integer.parseInt(MOVE_pointx.getText());
                mid_point.y = Integer.parseInt(MOVE_pointy.getText());

                click_arr.clear();
                gpanel.repaint();
            });

            DDA_Button.addActionListener(e ->{
                System.out.println("DDA Button 실행");

                new DDA(click_arr.get(1).x, click_arr.get(1).y, click_arr.get(0).x, click_arr.get(0).y);
                mid_point = new xypos(click_arr.get(1).x, click_arr.get(1).y);

                gpanel.repaint();
            });

            BSH_Button.addActionListener(e->{
                System.out.println("BSH Button 실행");

                new BSH(click_arr.get(1).x, click_arr.get(1).y, click_arr.get(0).x, click_arr.get(0).y);
                mid_point = new xypos(click_arr.get(1).x, click_arr.get(1).y);

                gpanel.repaint();
            });

            MEA_Button.addActionListener(e->{
                System.out.println("MEA Button 실행");

                System.out.println("미드 포인트 설정");
                mid_point = new xypos(click_arr.get(0).x, click_arr.get(0).y);
                System.out.println("미드 포인트 설정 끝");

                new MEA(click_arr.get(0).x, click_arr.get(0).y, Integer.parseInt(MEA_radian.getText()));


                click_arr.clear();
                gpanel.repaint();
            });

            SAM_Button.addActionListener(e->{
                System.out.println("SAM Button 실행");

                new SAM(click_arr.get(2).x, click_arr.get(2).y, click_arr.get(1).x, click_arr.get(1).y, click_arr.get(0).x, click_arr.get(0).y);
                mid_point = new xypos(click_arr.get(0).x, click_arr.get(0).y);

                click_arr.clear();
                gpanel.repaint();
            });

            clear_Button.addActionListener(e->{
                System.out.println("clear Button 실행");

                click_arr.clear();
                arr.clear();
                gpanel.repaint();
            });
        }
    }
}