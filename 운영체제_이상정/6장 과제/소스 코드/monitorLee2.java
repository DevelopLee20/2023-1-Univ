public class monitorLee2 {
    public static void main(String[] args) throws InterruptedException{
        Calculator c = new Calculator();
        CalAdd a = new CalAdd(c);
        CalSub s = new CalSub(c);
        CalMul m = new CalMul(c);
        CalDiv d = new CalDiv(c);

        a.start(); s.start(); m.start(); d.start();
        a.join(); s.join(); m.join(); d.join();
        c.print();
    }
}

class Calculator{
    double value;
    boolean d_turn = true;

    public Calculator(){
        this.value = 0;
    }

    synchronized public void add(double a){
        while (!d_turn) {
            try {
                wait();
            } catch (InterruptedException e) {}
        }
        double temp = value + a;

        System.out.print("+");
        this.value = temp;

        d_turn = false;
        notify();
    }

    synchronized public void sub(double a){
        while (!d_turn) {
            try {
                wait();
            } catch (InterruptedException e) {}
        }
        double temp = value - a;

        System.out.print("-");
        this.value = temp;

        d_turn = true;
        notify();
    }

    synchronized public void mul(double a){
        while (!d_turn) {
            try {
                wait();
            } catch (InterruptedException e) {}
        }
        double temp = value * a;

        System.out.print("*");
        this.value = temp;

        d_turn = true;
        notify();
    }

    synchronized public void div(double a){
        while (d_turn) {
            try {
                wait();
            } catch (InterruptedException e) {}
        }
        double temp = value / a;

        System.out.print("/");
        this.value = temp;

        d_turn = true;
        notify();
    }

    synchronized public void test(){
        
    }

    public void print(){
        System.out.println("\nvalue: " + value);
    }
}

class CalAdd extends Thread{
    Calculator c;

    CalAdd(Calculator c){
        this.c = c;
    }

    public void run(){
        for(int i=0; i<10; i++){
            c.add(3);
        }
    }
}

class CalSub extends Thread{
    Calculator c;

    CalSub(Calculator c){
        this.c = c;
    }

    public void run(){
        for(int i=0; i<10; i++){
            c.sub(2);
        }
    }
}

class CalMul extends Thread{
    Calculator c;

    CalMul(Calculator c){
        this.c = c;
    }

    public void run(){
        for(int i=0; i<10; i++){
            c.mul(2);
        }
    }
}

class CalDiv extends Thread{
    Calculator c;

    CalDiv(Calculator c){
        this.c = c;
    }

    public void run(){
        for(int i=0; i<10; i++){
            c.div(4);
        }
    }
}
