class monitorTest1{
    public static void main(String[] args) throws InterruptedException{
            BankAccount b = new BankAccount();
            BankDeposit d = new BankDeposit(b);
            BankWithdraw w = new BankWithdraw(b);

            d.start(); w.start();
            d.join(); w.join();
            System.out.println("\nbalance = " + b.getBalanace());
    }
}

class BankAccount{
    int balance;

    synchronized void deposit(int amt){
        int temp = balance + amt;

        System.out.print("+");
        balance = temp;
    }

    synchronized void withdraw(int amt){
        int temp = balance - amt;

        System.out.print("-");
        balance = temp;
    }

    int getBalanace(){
        return balance;
    }
}

class BankDeposit extends Thread{
    BankAccount b;

    BankDeposit(BankAccount b){
        this.b = b;
    }

    public void run(){
        for(int i=0; i<100; i++){
            b.deposit(1000);
        }
    }
}

class BankWithdraw extends Thread{
    BankAccount b;

    BankWithdraw(BankAccount b){
        this.b = b;
    }

    public void run(){
        for(int i=0; i<100; i++){
            b.withdraw(1000);
        }
    }
}