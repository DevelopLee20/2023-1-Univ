import javax.swing.*;

public class CGMain extends JFrame{

    public CGMain() {
        add(new CGPanel());
        pack();
        setTitle("CGBoard");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);

    }

    public static void main(String[] args) {
        CGMain cgMain = new CGMain();
    }
}