import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;
import java.awt.event.*;

public class CGPanel extends JPanel{
    private final int pix = 10;
    private final int numX = 30;
    private final int numY = 30;
    private final int sizeX = numX*pix;
    private final int sizeY = numY*pix;
    private panel_graph gpanel;
    private panel_control gcontrol;
    public ArrayList<xypos> point_arr;
    public ArrayList<xypos> show_arr;
    public ArrayList<xypos> window_arr;
    public xypos winMin;
    public xypos winMax;
    public boolean point_show = true;

    CGPanel() {
        point_arr = new ArrayList<>();
        show_arr = new ArrayList<>();
        window_arr = new ArrayList<>();

        setLayout(new FlowLayout());
        gpanel = new panel_graph();
        gcontrol = new panel_control();
        add(gpanel);
        add(gcontrol);

        // 좌표 클릭시 인식
        addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e){
                int x = (e.getX() - 300) / pix;
                int y = (300 - e.getY()) / pix;
                point_arr.add(point_arr.size(), new xypos(x, y));
                gpanel.repaint();
            }
        });
    }

    class Win{
        public Win(){
            winMin = point_arr.get(point_arr.size()-2);
            winMax = point_arr.get(point_arr.size()-1);

            DDA(winMin.x, winMin.y, winMax.x, winMin.y);
            DDA(winMin.x, winMin.y, winMin.x, winMax.y);
            DDA(winMin.x, winMax.y, winMax.x, winMax.y);
            DDA(winMax.x, winMax.y, winMax.x, winMin.y);
        }

        public void DDA(int xa, int ya, int xb, int yb) {
            int dx = xb - xa;
            int dy = yb - ya;
            int steps;
            float x = xa;
            float y = ya;
            float xIncrement, yIncrement;
    
            if(Math.abs(dx) > Math.abs(dy)){
                steps = Math.abs(dx);
            }
            else{
                steps = Math.abs(dy);
            }
    
            xIncrement = dx / (float)steps;
            yIncrement = dy / (float)steps;
    
            window_arr.add(0, new xypos(round(x), round(y)));
    
            for(int k=0; k<steps; k++){
                x += xIncrement;
                y += yIncrement;
                window_arr.add(0, new xypos(round(x), round(y)));
            }
        }
    
        public int round(float a){
            return (int)(a + 0.5);
        }
    }

    class POLY{
        public POLY(){
            for(int i=0; i<point_arr.size(); i++){
                int xa = point_arr.get(i).x;
                int ya = point_arr.get(i).y;
                int xb = point_arr.get((i+1) % point_arr.size()).x;
                int yb = point_arr.get((i+1) % point_arr.size()).y;
                DDA(xa, ya, xb, yb);
            }
        }

        public void DDA(int xa, int ya, int xb, int yb) {
            int dx = xb - xa;
            int dy = yb - ya;
            int steps;
            float x = xa;
            float y = ya;
            float xIncrement, yIncrement;
    
            if(Math.abs(dx) > Math.abs(dy)){
                steps = Math.abs(dx);
            }
            else{
                steps = Math.abs(dy);
            }
    
            xIncrement = dx / (float)steps;
            yIncrement = dy / (float)steps;
    
            show_arr.add(0, new xypos(round(x), round(y)));
    
            for(int k=0; k<steps; k++){
                x += xIncrement;
                y += yIncrement;
                show_arr.add(0, new xypos(round(x), round(y)));
            }
        }
    
        public int round(float a){
            return (int)(a + 0.5);
        }
    }

    class xypos{
        int x, y;

        public xypos(int x, int y){
            this.x = x;
            this.y = y;
        }
    }

    class panel_graph extends JPanel{
        panel_graph(){
            setPreferredSize(new Dimension((sizeX+1)*2, (sizeY+1)*2));
        }

        @Override
        public void paintComponent(Graphics g){
            super.paintComponent(g);
            Graphics2D g2 = (Graphics2D)g;
            g2.translate(sizeX,sizeY);
            g2.setColor(Color.BLACK);
            g2.setStroke(new BasicStroke(1));
            for(int i=-sizeY; i<=sizeY; i+=pix){
                g2.drawLine(-sizeX, i, sizeX, i);
            }
            for(int i=-sizeX; i<=sizeX; i+=pix){
                g2.drawLine(i, -sizeY, i, sizeY);
            }
            g2.setStroke(new BasicStroke(2));
            g2.drawLine(-sizeX, 0, sizeX, 0);
            g2.drawLine(0, -sizeY, 0, sizeY);

            for(xypos p : show_arr){
                g2.fillRect(p.x*pix, -(p.y+1)*pix, pix, pix);
            }
            
            if (point_show) {
                for(xypos p : point_arr){
                    g2.fillRect(p.x*pix, -(p.y+1)*pix, pix, pix);
                }
            }

            g2.setColor(Color.BLUE);
            for(xypos p : window_arr){
                g2.fillRect(p.x*pix, -(p.y+1)*pix, pix, pix);
            }
        }
    }

    class panel_control extends JPanel{
        JButton windowButton = new JButton("Window");
        JButton polyButton = new JButton("POLY");
        JButton clippiButton = new JButton("CLIP");
        JButton clearButton = new JButton("Clear");

        panel_control(){
            setPreferredSize(new Dimension(300, 300));
            setLayout(new GridLayout(0, 2, 2, 2));    // 격자 형태 레이아웃
            
            add(windowButton);
            add(polyButton);
            add(clippiButton);
            add(clearButton);

            clippiButton.addActionListener(e->{
                int Xrate = (60 / ((30+winMax.x)-(30+winMin.x)));
                int Yrate = (60 / ((30+winMax.y)-(30+winMin.y)));

                System.out.println(Xrate + " " + Yrate);
            });

            windowButton.addActionListener(e->{
                new Win();
                point_show = false;
                gpanel.repaint();
            });

            polyButton.addActionListener(e->{
                new POLY();
                gpanel.repaint();
            });

            clippiButton.addActionListener(e->{
                ArrayList<xypos> temp_arr = new ArrayList<>();

                for(xypos p : show_arr){
                    boolean xCheck = (p.x < winMax.x && p.x > winMin.x);
                    boolean yCheck = (p.y < winMax.y && p.y > winMin.y);
                    boolean check = xCheck && yCheck;

                    if (check) {
                        temp_arr.add(0, new xypos(p.x, p.y));
                    }
                }
                show_arr = temp_arr;
                gpanel.repaint();
            });

            clearButton.addActionListener(e->{
                point_arr.clear();
                show_arr.clear();
                window_arr.clear();
                gpanel.repaint();
            });
        }
    }
}