import java.util.ArrayList;
import java.awt.event.*;
import javax.swing.*;

import CGPanel.panel_control;
import CGPanel.panel_graph;

import java.awt.*;

/*
 추가 해야할 것
 1. 그림그리기
 2. 비율지정
 3. 잘라내기
 4. 쓸데 없는 부분 확대
 */

public class CGPanel extends JPanel{
    private final int pix = 10;         // 픽셀 1개 가로세로 크기
    private final int numX = 30;        // 제1사분면 x 좌표 범위
    private final int numY = 30;        // 제1사분면 y 좌표 범위
    private final int sizeX = numX*pix; // 모눈종이 x축 크기
    private final int sizeY = numY*pix; // 모눈종이 y축 크기

    private panel_graph gpanel = new panel_graph();
    private panel_control gcontrol = new panel_control();

    CGPanel(){
        setLayout(new FlowLayout());
        add(gpanel);
        add(gcontrol);
    }

    class xypos{
        int x, y;

        public xypos(int x, int y){
            this.x = x;
            this.y = y;
        }
    }

    class xypos_list{
        ArrayList<xypos> array;
        int point_x, point_y;

        public xypos_list(ArrayList<xypos> array, int point_x, int point_y){
            this.array = array;
            this.point_x = point_x;
            this.point_y = point_y;
        }
    }
}