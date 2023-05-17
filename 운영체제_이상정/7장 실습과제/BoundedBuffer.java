public class BoundedBuffer{
    // 메인 함수 실행 중 Interrupt 발생시 종료
    public static void main(String[] args) throws InterruptedException{
        Buffer b = new Buffer();    // 버퍼 생성 size = 8
        Waiting w = new Waiting(b); // 기다리는 손님 대기줄(생산자)
        Go g = new Go(b);           // 기다리던 손님 태우는 것(소비자)

        w.start(); g.start();
        w.join(); g.join();

        System.out.println("운영종료! 대기중인 손님: " + b.getCount());
    }
}

class Buffer{
    private static final int BUFFER_SIZE = 8;               // 버퍼 size = 8
    private int count, in, out;
    private guest[] buffer;                                 // 손님 클래스를 가진 버퍼 변수
    private String[] name_list = {"A","B","C","D","E","F"}; // 손님 이름을 가진 문자열 배열
    
    // Buffer 클래스 생성자
    public Buffer(){
        count = 0;
        in = 0;
        out = 0;
        buffer = new guest[BUFFER_SIZE];
    }

    public int getCount(){
        return count;
    }
    
    // 생상자 메소드, 버퍼에 손님을 채운다.
    public synchronized void insert(int item){
        while(count == BUFFER_SIZE){    // 버퍼가 찰때까지 반복
            try{
                wait();
            }
            catch(InterruptedException ie) {}
            System.out.println("아마존 익스프레스 출발~!");
        }
    
        // 손님이 대기하면 배열에 손님 추가
        buffer[in] = new guest(item, name_list[in % 6]);
        guest inserts = buffer[in];
        
        // 대기중인 손님이 몇 번째이며 이름이 무엇인지 출력
        System.out.println("손님 대기 | 번호: " + inserts.num + " 이름: " + inserts.name);
        in = (in + 1) % BUFFER_SIZE;    // 버퍼 인덱스 조정
        count++;                        // 대기중인 사람을 표시
        
        notify();
    }
    
    public synchronized void remove(){
        while (count == 0) {    // 버퍼가 빌때까지 반복
            try {
                wait();
            } catch (InterruptedException ie) {}
        }
        
        guest removes = buffer[out];
        out = (out + 1) % BUFFER_SIZE;  // 버퍼 인덱스 조정
        count--;                        // 사람을 태웠음
        
        notify();
        
        // 어떤 손님이 탔는지 정보 출력
        System.out.println("손님 입장 | 번호: " + removes.num + " 이름: " + removes.name);
    }

    // 손님 클래스
    class guest{
        private int num;     // 몇 번째 손님인지 저장
        private String name; // 손님 이름이 무엇인지 저장
    
        // 손님 클래스 생성자
        public guest(int num, String name){
            this.num = num;
            this.name = name;
        }
    
        // 자바 빈즈 규약
        int getNum(){
            return this.num;
        }
    
        // 자바 빈즈 규약
        String getNmae(){
            return this.name;
        }
    }
}

// 생산자 클래스
class Waiting extends Thread{
    Buffer b;

    public Waiting(Buffer b){
        this.b = b;
    }

    // 총 48번 생성한다.
    public void run(){
        for(int i=0; i<48; i++){
            b.insert(i);
        }
    }
}

// 소비자 클래스
class Go extends Thread{
    Buffer b;

    public Go(Buffer b){
        this.b = b;
    }

    // 총 48번 소비한다.
    public void run(){
        for(int i=0; i<48; i++){
            b.remove();
        }
    }
}