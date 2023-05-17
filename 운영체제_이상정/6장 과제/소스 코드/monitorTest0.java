class monitorTest0{
    public static void main(String[] args) throws InterruptedException{
            BankAccount b = new BankAccount();
            BankDeposit d = new BankDeposit(b);
            BankWithdraw w = new BankWithdraw(b);

            // Thread 실행
            d.start(); w.start();

            // Thread 연결
            d.join(); w.join();

            // 결과값 출력
            System.out.println("\nbalance = " + b.getBalance());
    }
}

class BankAccount{
    int balance = 0; // 0으로 초기화 하는 코드 추가

    // balance 값에서 amt 값을 더하고 temp에 저장
    void deposit(int amt){
        int temp = balance + amt;

        System.out.print("+");
        balance = temp;
    }

    // balance 값에서 amt값을 뺴고 temp에 저장
    void withdraw(int amt){
        int temp = balance - amt;

        System.out.print("-");
        balance = temp;
    }

    // balance 값을 반환한다.
    int getBalance(){
        return balance;
    }
}

// 쓰레드 방식으로 deposit 함수를 실행시킨다.
// 이때 amt 값은 1000으로 지정한다.
class BankDeposit extends Thread{
    BankAccount b;

    BankDeposit(BankAccount b){
        this.b = b;
    }

    // 스레드 실행
    public void run(){
        for(int i=0; i<100; i++){
            b.deposit(1000);
        }
    }
}

// 쓰레드 방식으로 withdraw 함수를 실행시킨다.
// 이때 amt 값은 1000으로 지정한다.
class BankWithdraw extends Thread{
    BankAccount b;

    BankWithdraw(BankAccount b){
        this.b = b;
    }

    // 스레드 실행
    public void run(){
        for(int i=0; i<100; i++){
            b.withdraw(1000);
        }
    }
}