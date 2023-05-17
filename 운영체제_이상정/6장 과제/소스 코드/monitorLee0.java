public class monitorLee0 {
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

    public Calculator(){
        this.value = 0;
    }

    public void add(double a){
        double temp = value + a;

        System.out.print("+");
        this.value = temp;
    }

    public void sub(double a){
        double temp = value - a;

        System.out.print("-");
        this.value = temp;
    }

    public void mul(double a){
        double temp = value * a;

        System.out.print("*");
        this.value = temp;
    }

    public void div(double a){
        double temp = value / a;

        System.out.print("/");
        this.value = temp;
    }

    public void print(){
        System.out.println("\nvalue: " + this.value);
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
