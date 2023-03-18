import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;

public class CGPanel extends JPanel {

    private final int pix = 10;         // 종이 가로세로 크기
    private final int numX = 30;        // 종이 X 개수
    private final int numY = 30;        // 종이 Y 개수
    private final int sizeX = numX*pix; // 종이 전체 X 사이즈
    private final int sizeY = numY*pix; // 종이 전체 Y 개수
    private panel_graph gpanel;         // 판넬 객체 저장

    private ArrayList<xypos> DDA_arr = new ArrayList<>();       // DDA 좌표
    private ArrayList<xypos> BSH_arr = new ArrayList<>();       // BSH 좌표

    CGPanel() {
        setLayout(new FlowLayout());
        gpanel = new panel_graph();
        add(gpanel);
        add(new panel_control());
    }

    // (x,y)좌표 점 클래스
    class xypos{
        int x, y;
        int change;

        public xypos(int x, int y, int change){
            this.x = x;
            this.y = y;
            this.change = change;
        }
    }

    class panel_graph extends JPanel{
        panel_graph(){
            //모눈종이 끝 선 안잘리게 패널 크기를 모눈종이보다 조금 더 크게 한다.
            setPreferredSize(new Dimension((sizeX+1)*2, (sizeY+1)*2));
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

            draw_line(g2);
        }

        public void draw_line(Graphics g2){
            g2.setColor(Color.black);
            for(xypos p : DDA_arr){
                g2.fillRect(p.x * pix, -(p.y + 1) * pix, pix, pix);
            }

            for(xypos p : BSH_arr){
                g2.fillRect(p.x * pix, -(p.y + 1) * pix, pix, pix);
            }
            
            g2.setColor(Color.red);
            if(DDA_arr.size() == BSH_arr.size()){
                for(int i=0; i<DDA_arr.size(); i++){
                    xypos dda = DDA_arr.get(i);
                    xypos bsh = BSH_arr.get(i);
    
                    if(dda.change != bsh.change){
                        g2.fillRect(dda.x * pix, -(dda.y + 1) * pix, pix, pix);
                        g2.fillRect(bsh.x * pix, -(bsh.y + 1) * pix, pix, pix);
                    }
                }
            }
        }
    }
    class panel_control extends JPanel{
        JTextField x1, y1, x2, y2;
        JTextField b_x1, b_y1, b_x2, b_y2;
        JButton btn1, btnClear;
        JButton b_btn1, b_btnClear;
        int int_x1, int_y1, int_x2, int_y2;

        panel_control(){
            setPreferredSize(new Dimension(300, 100));
            setLayout(new GridLayout(4, 4, 2, 2));

            Button_Maker DDA_Buttons = new Button_Maker("DDA");
            Button_Maker BSH_Buttons = new Button_Maker("BSH");
        }

        class Button_Maker{
            JTextField x1 = new JTextField();
            JTextField y1 = new JTextField();
            JTextField x2 = new JTextField();
            JTextField y2 = new JTextField();
            JButton btn;
            JButton btnClear = new JButton("Clear");
            JLabel xy1 = new JLabel("    X1   Y1");
            JLabel xy2 = new JLabel("    X2   Y2");

            Button_Maker(String name){
                this.btn = new JButton(name);

                add(this.xy1);
                add(this.x1);
                add(this.y1);
                add(this.btn);

                add(this.xy2);
                add(this.x2);
                add(this.y2);
                add(this.btnClear);
            
                this.btn.addActionListener(e -> {
                    int x1, x2, y1, y2;

                    x1 = Integer.parseInt(this.x1.getText());
                    x2 = Integer.parseInt(this.x2.getText());
                    y1 = Integer.parseInt(this.y1.getText());
                    y2 = Integer.parseInt(this.y2.getText());
                    Choice_Alg(name, x1, x2, y1, y2);

                    gpanel.repaint();
                });

                this.btnClear.addActionListener(e -> {
                    this.x1.setText("");
                    this.x2.setText("");
                    this.y1.setText("");
                    this.y2.setText("");

                    Choice_Arr(name);
                    gpanel.repaint();

                    System.out.println("내용 삭제 완료!");
                });
            }

            public void Choice_Arr(String name){
                if(name == "DDA"){
                    DDA_arr.clear();
                }
                if(name == "BSH"){
                    BSH_arr.clear();
                }
            }

            public void Choice_Alg(String name, int x1, int x2, int y1, int y2){
                if(name == "DDA"){
                    System.out.println("DDA 알고리즘 호출!");
                    new Graphics_Alg(x1, y1, x2, y2).DDA_Alg();
                }
                if(name == "BSH"){
                    System.out.println("BSH 알고리즘 호출!");
                    new Graphics_Alg(x1, y1, x2, y2).BSH_Alg();
                }
            }
        }

        class Graphics_Alg{
            int x1, x2, y1, y2;
            float m;
            boolean bigger_one = false;

            Graphics_Alg(int x1, int y1, int x2, int y2){
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;

                reverse();
                this.m = (float)(this.y2 - this.y1) / (float)(this.x2 - this.x1);
                System.out.println("m: " + this.m);
                check_m();
            }

            // DDA 알고리즘
            public void DDA_Alg(){
                System.out.println("DDA 알고리즘 연산 실행!");
                check_before_Alg();
                float y = this.y1;
                int delta = -100;

                for(int x=this.x1; x<=this.x2; x++){
                    if(delta != -100 && delta == return_int(y)){
                        check_after_Alg(x, return_int(y), 0, DDA_arr);
                    }
                    else{
                        check_after_Alg(x, return_int(y), 1, DDA_arr);
                    }
                    delta = return_int(y);
                    y += this.m;
                }
            }

            // Bresenham's 알고리즘
            public void BSH_Alg(){
                System.out.println("BSH 알고리즘 연산 실행!");
                int delta;

                check_before_Alg();

                if(this.m >= 0){
                    delta = 1;
                }
                else{
                    delta = -1;
                }

                // 이해가 안되네
                int dx = Math.abs(this.x2 - this.x1);
                int dy = Math.abs(this.y2 - this.y1);
                //

                int y = this.y1;
                int p = 2 * dy - dx;
                int before = -100;

                for(int x=this.x1; x<=this.x2; x++){
                    System.out.println("p: " + p);

                    if(before != -100 && before == y){
                        check_after_Alg(x, y, 0 ,BSH_arr);
                    }
                    else{
                        check_after_Alg(x, y, 1 ,BSH_arr);
                    }

                    before = y;

                    if(p >= 0){
                        p = p + 2 * (dy - dx);
                        y += delta;
                    }
                    else{
                        p = p + 2 * dy;
                    }

                }
            }

            // 시작 전 좌표 수정
            public void check_before_Alg(){
                if(this.bigger_one){
                    int temp;
                    temp = this.x1;
                    this.x1 = this.y1;
                    this.y1 = temp;
                    
                    temp = this.x2;
                    this.x2 = this.y2;
                    this.y2 = temp;
                    System.out.println("좌표 재설정!");
                    System.out.println("x1 : " + x1 + " y1 : " + y1 + " x2 : " + x2 + " y2 : " + y2);
                    
                    System.out.println("기울기 재설정!");
                    this.m = (float)(this.y2 - this.y1) / (float)(this.x2 - this.x1);
                    System.out.println("재설정된 기울기 m: " + this.m);
                }
            }

            // 시작 후 최종 좌표 수정
            public void check_after_Alg(int x, int y, int change, ArrayList<xypos> array){
                if(this.bigger_one){
                    System.out.println("x: " + y + " | " + "y: " + x);
                    array.add(0, new xypos(y, x, change));
                }
                else{
                    System.out.println("x: " + x + " | " + "y: " + y);
                    array.add(0, new xypos(x, y, change));
                }
            }

            // 기울기에 따른 부호와 1보다 큰지 정해준다.
            public void check_m(){
                if(Math.abs(this.m) > 1){
                    this.bigger_one = true;
                }
            }

            // 두 점이 반대로 찍혔을때 수정하기 위한 메소드
            public void reverse(){
                if(this.x1 > this.x2){
                    int temp = this.x1;
                    this.x1 = this.x2;
                    this.x2 = temp;
                    
                    temp = this.y1;
                    this.y1 = this.y2;
                    this.y2 = temp;
                }
                this.m = (float)(this.y2 - this.y1) / (float)(this.x2 - this.x1);
            }

            public int return_int(float value){
                // 양수일 때와 음수일 때 다르게 처리
                if(value >= 0){
                    if(value % 1 > 0.5){
                        return (int)value + 1;
                    }
                    else{
                        return (int)value;
                    }
                }
                else{
                    if(value % 1 > 0.5){
                        return (int)value - 1;
                    }
                    else{
                        return (int)value;
                    }
                }
            }
        }
    }
}