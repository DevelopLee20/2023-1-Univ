// class ProtossUnit{
//     public int strength = 40;
//     public String skill = "클로킹";
//     public int damage = 45;
//     public int shield = 80;
//     public String clan;
//     public String name;

//     public ProtossUnit(String clan, String name){
//         this.clan = clan;
//         this.name = name;
//     }

//     public int getDamage(){
//         return damage;
//     }

//     public int getStrength(){
//         return strength;
//     }

//     public int getShield(){
//         return shield;
//     }

//     public String getClan(){
//         return clan;
//     }

//     public String getName(){
//         return name;
//     }

//     public String getSkill(){
//         return skill;
//     }
// }

// class DarkTemplar : ProtossUnit{
//     public DarkTemplar(String clan, String name) : base(clan, name){
//     }
// }

// class Nexus{
//     int mineral;
//     int gas;
//     public Nexus(int mineral){
//         this.mineral = mineral;

//         if(this.mineral >= 50){
//             Console.WriteLine("프로브 생산");
//         }
//         else{
//             Console.WriteLine("광물이 부족합니다.");
//         }
//     }

//     public Nexus(int mineral, int gas){
//         this.mineral = mineral;
//         this.gas = gas;

//         if(this.mineral >= 300 && this.gas >= 300){
//             Console.WriteLine("모선 생산");
//         }
//         else{
//             Console.WriteLine("광물 혹은 가스가 부족합니다.");
//         }
//     }
// }

// class program{
//     static void Main(String[] args){
//         ProtossUnit DT = new DarkTemplar("프로토스", "다크템플러");

//         int Damage = DT.getDamage();
//         int Strength = DT.getStrength();
//         int Shield = DT.getShield();

//         Console.WriteLine("종족: " + DT.getClan());
//         Console.WriteLine("이름: " + DT.getName());
//         Console.WriteLine("쉴드: " + Shield);
//         Console.WriteLine("체력: " + Strength);
//         Console.WriteLine("데미지: " + Damage.ToString());
//         Console.WriteLine("스킬: " + DT.getSkill());
//         Console.WriteLine();

//         Nexus N1 = new Nexus(40);
//         Nexus M1 = new Nexus(30, 30);

//         Console.WriteLine();

//         Nexus N2 = new Nexus(50);
//         Nexus M2 = new Nexus(300, 300);

//         Console.WriteLine();
//     }
// }

// 2번

abstract class Game{
    public static int userWin=0, computerWin=0, drawMatch=0;

    public Game(){
    }

    ~Game(){
        recordPrint();
    }

    public abstract void result();

    public void recordPrint(){
        Console.WriteLine(userWin + "승 " + computerWin + "패 " + drawMatch + "무승부입니다.");
    }
}

class Srp : Game{
    public int shot;
    public int user;

    public Srp(){
        Random rand = new Random();
        this.shot = rand.Next(1,4);
    }

    public void play(){
        Console.Write("입력하세요 [가위(1), 바위(2), 보(3), 종료(0)] : ");
        int i = Convert.ToInt32(Console.ReadLine());

        if(i == 0){
            return;
        }

        this.user = i;

        result();
    }

    public int check(){
        if(user != 1 && shot > user){
            return -1;  // 졌음
        }
        else if(shot == user){
            return 0;   // 비겼음
        }
        else if(user == 1 && shot == 3){
            return 1;   // 이겼음
        }
        else{
            return 1;   // 이겼음
        }
    }

    public override void result(){
        int chk = check();
        String print;

        if(shot == 1){
            print = "컴퓨터는 가위를 냈습니다.";
        }
        else if(shot == 2){
            print = "컴퓨터는 바위를 냈습니다.";
        }
        else{
            print = "컴퓨터는 보를 냈습니다.";
        }

        Console.WriteLine(print);

        if(chk == 0){
            print = "비겼습니다.";
            drawMatch += 1;
        }
        else if(chk == -1){
            print = "졌습니다.";
            computerWin += 1;
        }
        else{
            print = "이겼습니다.";
            userWin += 1;
        }
        Console.WriteLine(print);
        Console.WriteLine();
    }
}

class Mjb : Srp{
    int attacter = -1;
    Random rand = new Random();

    public Mjb(){
        shot = rand.Next(1,4);
    }

    public void play(){
        Console.Write("입력하세요 [가위(1), 바위(2), 보(3), 종료(0)] : ");
        int i = Convert.ToInt32(Console.ReadLine());
        shot = rand.Next(1,4);

        if(i == 0){
            return;
        }
        user = i;

        result();
    }

    public override void result(){
        int chk = check();
        String print;

        if(shot == 1){
            print = "컴퓨터는 가위를 냈습니다.";
        }
        else if(shot == 2){
            print = "컴퓨터는 바위를 냈습니다.";
        }
        else{
            print = "컴퓨터는 보를 냈습니다.";
        }

        Console.WriteLine("check: " + chk);
        Console.WriteLine(print);

        if(attacter == -1){
            if(chk == 0){
                Console.WriteLine("비겼습니다.");
                Console.WriteLine();
                play();
            }
            else if(chk == -1){
                Console.WriteLine("공격자는 컴퓨터입니다.");
                Console.WriteLine();
                attacter = 0;
                play();
            }
            else{
                Console.WriteLine("공격자는 유저입니다.");
                Console.WriteLine();
                attacter = 1;
                play();
            }            
        }

        else if(attacter == 1){
            if(chk == 0){
                Console.WriteLine("이겼습니다.");
                Console.WriteLine();
                userWin += 1;
            }
            else if(chk == -1){
                Console.WriteLine("공격자는 컴퓨터입니다.");
                Console.WriteLine();
                attacter = 0;
                play();
            }
            else{
                Console.WriteLine("공격자는 유저입니다.");
                Console.WriteLine();
                play();
            }
        }

        else{
            if(chk == 0){
                Console.WriteLine("졌습니다.");
                Console.WriteLine();
                computerWin += 1;
            }
            else if(chk == -1){
                Console.WriteLine("공격자는 유저입니다.");
                Console.WriteLine();
                attacter = 1;
                play();
            }
            else{
                Console.WriteLine("공격자는 컴퓨터입니다.");
                Console.WriteLine();
                play();
            }
        }
    }
}

class Program{
    static void Main(String[] args){
        while(true){
            Console.Write("선택하세요 [가위바위보 게임(1), 묵찌빠 게임(2), 종료(0)] : ");
            int i = Convert.ToInt32(Console.ReadLine());

            if(i == 1){
                new Srp().play();
            }
            else if(i == 2){
                new Mjb().play();
            }
            else if(i == 0){
                Console.WriteLine(1 + "승 " + 1 + "패 " + 0 + "무승부입니다.");
                break;
            }
            else{
                Console.WriteLine("잘못 입력하셨습니다.");
            }
        }
    }
}
