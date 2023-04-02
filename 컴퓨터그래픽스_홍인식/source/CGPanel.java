import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;

// 좌표 저장하는 클래스
class xypos{
    int x, y;

    public xypos(int x, int y){
        this.x = x;
        this.y = y;
    }
}

// 레이아웃 클래스
public class CGPanel extends JPanel{
    final int pix = 10;
    final int numX = 30;
    final int numY = 30;
    final int sizeX = numX * pix;
    final int sizeY = numY * pix;

    CGPad cgpad;

    MidPointEllipse MEA_Algorithm;
    DDA DDA_Algorithm;
    Bresenham BSH_Algorithm;

    CGPanel(){
        cgpad = new CGPad();
        
        setLayout(new FlowLayout());
        add(cgpad);
        add(new CGButton()); // control이 들어가야 함
    }

    // 모눈 종이 클래스
    class CGPad extends JPanel{
        CGPad(){
            setPreferredSize(new Dimension((sizeX + 1) * 2, (sizeY + 1) * 2));
        }

        public void paintComponent(Graphics g){
            super.paintComponent(g);

            Graphics2D g2 = (Graphics2D)g;
            g2.translate(sizeX,sizeY);
            g2.setColor(Color.gray);
            g2.setStroke(new BasicStroke(1));

            for(int i=-sizeY; i<=sizeY; i+=pix){
                g2.drawLine(-sizeX, i, sizeX, i);
            }
            for(int i=-sizeX; i<=sizeX; i+=pix){
                g2.drawLine(i, -sizeY, i, sizeY);
            }

            g2.setColor(Color.BLACK);
            g2.setStroke(new BasicStroke(2));
            g2.drawLine(-sizeX, 0, sizeX, 0);
            g2.drawLine(0, -sizeY, 0, sizeY);

            g.setColor(Color.black);
            if(MEA_Algorithm != null){

                for(xypos point : MEA_Algorithm.array){
                    boolean inpad = (point.x <= numX && point.x >= -numX && point.y <= numY && point.y >= -numY);

                    if(inpad){
                        g.fillRect(point.x * pix, -(point.y + 1) * pix, pix, pix);
                    }
                }
            }

            if(DDA_Algorithm != null){
                for(xypos point : DDA_Algorithm.array){
                    boolean inpad = (point.x <= numX && point.x >= -numX && point.y <= numY && point.y >= -numY);

                    if(inpad){
                        g.fillRect(point.x * pix, -(point.y + 1) * pix, pix, pix);
                    }
                }
            }

            if(BSH_Algorithm != null){
                for(xypos point : BSH_Algorithm.array){
                    boolean inpad = (point.x <= numX && point.x >= -numX && point.y <= numY && point.y >= -numY);

                    if(inpad){
                        g.fillRect(point.x * pix, -(point.y + 1) * pix, pix, pix);
                    }
                }
            }
        }
    }

    class CGButton extends JPanel{
        CGButton(){
            setPreferredSize(new Dimension(800, 400));
            // row, cols, gaps -> 칸이 적을경우 rows를 우선적으로 지킴
            setLayout(new GridLayout(5, 8, 2, 2));
            
            System.out.println("CGButton() 체크");

            MEA_Buttons();
            DDA_Buttons();
            BSH_Buttons();
            MOVE_Buttons();
            ZIZO_Buttons();
        }

        public void ZIZO_Buttons(){
            JLabel sizes = new JLabel("Size");
            JTextField size = new JTextField();
            JButton algButton = new JButton("Z In/Out");

            add(sizes);
            add(size);
            add(new JLabel());
            add(new JLabel());
            add(new JLabel());
            add(new JLabel());
            add(algButton);
            add(new JLabel());

            algButton.addActionListener(e ->{
                int Dradian = Integer.parseInt(size.getText());

                if(MEA_Algorithm != null){
                    MEA_Algorithm = new MidPointEllipse(MEA_Algorithm.GetPoint_x(), MEA_Algorithm.GetPoint_y(), MEA_Algorithm.GetRadian() + Dradian);
                }

                cgpad.repaint();
            });
        }

        public void MOVE_Buttons(){
            // 확대, 축소, 이동 중 일단 이동 작성
            JLabel point1 = new JLabel("Move Point");
            JTextField x1 = new JTextField();
            JTextField y1 = new JTextField();
            JButton algButton = new JButton("Move");

            add(point1);
            add(x1);
            add(y1);
            add(new JLabel());
            add(new JLabel());
            add(new JLabel());
            add(algButton);
            add(new JLabel());

            algButton.addActionListener(e ->{
                int int_x1 = Integer.parseInt(x1.getText());
                int int_y1 = Integer.parseInt(y1.getText());

                if(MEA_Algorithm != null && MEA_Algorithm.array.size() != 0){
                    MEA_Algorithm.SetPoint_x(int_x1);
                    MEA_Algorithm.SetPoint_y(int_y1);
                    MEA_Algorithm.move(int_x1, int_y1);
                }

                // if(DDA_Algorithm != null && DDA_Algorithm.array.size() != 0){
                //     DDA_Algorithm.move(int_x1, int_y1);
                //     DDA_Algorithm.SetPoint_x(int_x1);
                //     DDA_Algorithm.SetPoint_y(int_y1);
                // }
                // if(BSH_Algorithm != null && BSH_Algorithm.array.size() != 0){
                //     BSH_Algorithm.move(int_x1, int_y1);
                //     BSH_Algorithm.SetPoint_x(int_x1);
                //     BSH_Algorithm.SetPoint_y(int_y1);
                // }
                cgpad.repaint();
            });
        }

        public void BSH_Buttons(){
            JTextField x1 = new JTextField();
            JTextField y1 = new JTextField();
            JTextField x2 = new JTextField();
            JTextField y2 = new JTextField();
            JLabel point1 = new JLabel("Point1");
            JLabel point2 = new JLabel("Point2");
            JButton algButton = new JButton("Breseham");
            JButton clearButton = new JButton("Clear");

            add(point1);
            add(x1);
            add(y1);
            add(point2);
            add(x2);
            add(y2);
            add(algButton);
            add(clearButton);

            algButton.addActionListener(e ->{
                int int_x1 = Integer.parseInt(x1.getText());
                int int_y1 = Integer.parseInt(y1.getText());
                int int_x2 = Integer.parseInt(x2.getText());
                int int_y2 = Integer.parseInt(y2.getText());

                BSH_Algorithm = new Bresenham(int_x1, int_y1, int_x2, int_y2);
                cgpad.repaint();
            });

            clearButton.addActionListener(e ->{
                x1.setText("");
                y1.setText("");
                x2.setText("");
                y2.setText("");

                BSH_Algorithm.array.clear();
                cgpad.repaint();
            });
        }

        public void DDA_Buttons(){
            JTextField x1 = new JTextField();
            JTextField y1 = new JTextField();
            JTextField x2 = new JTextField();
            JTextField y2 = new JTextField();
            JLabel point1 = new JLabel("Point1");
            JLabel point2 = new JLabel("Point2");
            JButton algButton = new JButton("DDA");
            JButton clearButton = new JButton("Clear");

            add(point1);
            add(x1);
            add(y1);
            add(point2);
            add(x2);
            add(y2);
            add(algButton);
            add(clearButton);

            algButton.addActionListener(e ->{
                int int_x1 = Integer.parseInt(x1.getText());
                int int_y1 = Integer.parseInt(y1.getText());
                int int_x2 = Integer.parseInt(x2.getText());
                int int_y2 = Integer.parseInt(y2.getText());

                DDA_Algorithm = new DDA(int_x1, int_y1, int_x2, int_y2);
                cgpad.repaint();
            });

            clearButton.addActionListener(e ->{
                x1.setText("");
                y1.setText("");
                x2.setText("");
                y2.setText("");

                DDA_Algorithm.array.clear();
                cgpad.repaint();
            });
        }

        public void MEA_Buttons(){
            JTextField x1 = new JTextField();
            JTextField y1 = new JTextField();
            JTextField radian = new JTextField();
            JButton algButton = new JButton("MEA");
            JButton clearButton = new JButton("Clear");
            JLabel point1 = new JLabel("Point1");
            JLabel radian1 = new JLabel("radian");

            add(point1);
            add(x1);
            add(y1);
            add(radian1);
            add(radian);
            add(new JLabel());
            add(algButton);
            add(clearButton);

            algButton.addActionListener(e ->{
                int int_x1 = Integer.parseInt(x1.getText());
                int int_y1 = Integer.parseInt(y1.getText());
                int int_radian = Integer.parseInt(radian.getText());

                System.out.println("버튼 로그 - int 파싱 여부 확인");
                System.out.println(int_x1);
                System.out.println(int_y1);
                System.out.println(int_radian);
                System.out.println("버튼 로고 끝");

                MEA_Algorithm = new MidPointEllipse(int_x1, int_y1, int_radian);
                cgpad.repaint();
            });

            clearButton.addActionListener(e ->{
                x1.setText("");
                y1.setText("");
                radian.setText("");

                MEA_Algorithm.array.clear();
                cgpad.repaint();
            });
        }
    }
}

// 모든 알고리즘이 출력하는 부분
class Algorithm extends CGPanel{
    public ArrayList<xypos> array = new ArrayList<>();

    public Algorithm(){
    }

    public void move(int dx, int dy){
        ArrayList<xypos> move_array = new ArrayList<>();
        for(xypos p : this.array){
            move_array.add(0, new xypos(p.x + dx, p.y + dy));
        }
        array = move_array;
    }
    
    public void print_array(Graphics g){
        g.setColor(Color.black);

        for(xypos point : this.array){
            boolean inpad = (point.x <= super.numX && point.x >= -super.numX && point.y <= super.numY && point.y >= -super.numY);

            if(inpad){
                System.out.print("그려짐");
                g.fillRect(point.x * super.pix, -(point.y + 1) * super.pix, super.pix, super.pix);
            }
        }
    }
}

class SamGak extends Algorithm{
}

class DDA extends Algorithm{
    public DDA(int xa, int ya, int xb, int yb) {
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

        super.array.add(0, new xypos(round(x), round(y)));

        System.out.print("steps value: ");
        System.out.println(steps);

        for(int k=0; k<steps; k++){
            x += xIncrement;
            y += yIncrement;
            super.array.add(0, new xypos(round(x), round(y)));
        }
    }

    public int round(float a){
        return (int)(a + 0.5);
    }
}

class Bresenham extends Algorithm{
    // 브레센헴은 애초에 기울기가 1보다 작아야한다.
    public Bresenham(int xa, int ya, int xb, int yb){
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
            super.array.add(0, new xypos(y, x));
        }
        else{
            super.array.add(0, new xypos(x, y));
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
                super.array.add(0, new xypos(y, x));
            }
            else{
                super.array.add(0, new xypos(x, y));
            }
        }
    }
}

class MidPointEllipse extends Algorithm{
    int x, y, p;
    int point_x, point_y, radian;
    
    public MidPointEllipse(int x1, int y1, int radian) {
        this.point_x = x1;
        this.point_y = y1;
        this.radian = radian;

        this.x = 0;
        this.y = radian;
        this.p = 1 - radian;
        
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

    public int GetPoint_x(){
        return this.point_x;
    }

    public int GetPoint_y(){
        return this.point_y;
    }

    public int GetRadian(){
        return this.radian;
    }

    public void SetPoint_x(int x){
        this.point_x = x;
    }

    public void SetPoint_y(int y){
        this.point_y = y;
    }

    void CirclePlotPoints(int xCenter, int yCenter, int x, int y){
        super.array.add(0, new xypos(xCenter + x, yCenter + y));
        super.array.add(0, new xypos(xCenter - x, yCenter + y));
        super.array.add(0, new xypos(xCenter + x, yCenter - y));
        super.array.add(0, new xypos(xCenter - x, yCenter - y));
        super.array.add(0, new xypos(xCenter + y, yCenter + x));
        super.array.add(0, new xypos(xCenter - y, yCenter + x));
        super.array.add(0, new xypos(xCenter + y, yCenter - x));
        super.array.add(0, new xypos(xCenter - y, yCenter - x));
    }
}