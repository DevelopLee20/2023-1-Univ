class Fraction{
    public int numberator;
    public int denominator;
    public int temp; // 기약분수

    // (1) 한 개의 정수를 받아 초기화 하는 생성자를 작성하시오.
    public Fraction(int a){
        this.numberator = a;
        this.denominator = 1;
    }

    // (2) 두 개의 정수를 받아 초기화 하는 생성자를 작성하시오.
    public Fraction(int a, int b){
        this.numberator = a;
        this.denominator = b;
    }

    // (3) 하나의 분수를 분자/분모 형태로 반환하는 ToString() 메소드를 작성하시오.
    public override string ToString(){
        return  "(" + this.numberator + " / " + this.denominator + ")";
    }

    // (4-1) 최대 공약수를 구하는 메소드를 작성하시오.
    public int GratestCommonDivisor(int numberator, int denominator){
        int min;

        if(numberator > denominator){
            min = denominator;
        }
        else{
            min = numberator;
        }

        for(int i=1; i<=min; i++){
            if(numberator % i == 0 && denominator % i == 0){
                this.temp = i;
            }
        }

        return this.temp;
    }

    // (4-2) 기약 분수로 만드는 메소드를 작성하시오.
    public void irreducibleFraction(Fraction a){
        Console.WriteLine("기약분수로 표현한 분수식: " + a.numberator / a.temp + " / " + a.denominator / a.temp);
    }

    // (5-1) [더하기] 분수에 대한 4칙 연산을 수행하는 메소드
    public void addFraction(Fraction a, Fraction b){
        int g = a.denominator * b.denominator / this.temp;
        int a_upper = (g / a.denominator) * a.numberator;
        int b_upper = (g / b.denominator) * b.numberator;

        Console.WriteLine("f1 + f2 = (" + (a_upper + b_upper) + " / " + g + ")");
    }

    // (5-2) [빼기] 분수에 대한 4칙 연산을 수행하는 메소드
    public void subFraction(Fraction a, Fraction b){
        int g = a.denominator * b.denominator / this.temp;
        int a_upper = (g / a.denominator) * a.numberator;
        int b_upper = (g / b.denominator) * b.numberator;

        Console.WriteLine("f1 - f2 = (" + (a_upper - b_upper) + " / " + g + ")");
    }

    // (5-3) [곱하기] 분수에 대한 4칙 연산을 수행하는 메소드
    public void mulFraction(Fraction a, Fraction b){
        Console.WriteLine("f1 * f2 = (" + (a.numberator * b.numberator) + " / " + (a.denominator * b.denominator) + ")");
    }

    // (5-4) [나누기] 분수에 대한 4칙 연산을 수행하는 메소드
    public void divFraction(Fraction a, Fraction b){
        Console.WriteLine("f1 / f2 = (" + (a.numberator * b.denominator) + " / " + (a.denominator * b.numberator) + ")");
    }
}

// (6) 테스트 클래스를 만들어 테스트 하시오.
class Program{
    static void Main(String[] args){
        Fraction f1, f2;

        // case 1
        // f1 = new Fraction(5, 6);
        // f2 = new Fraction(2, 4);

        // case 2
        f1 = new Fraction(5);
        f2 = new Fraction(2, 4);

        Console.WriteLine("분수식 f1: " + f1.ToString());
        Console.WriteLine("분수식 f2: " + f2.ToString());

        Console.WriteLine("분수식 f1의 최대공약수: " + f1.GratestCommonDivisor(f1.numberator, f1.denominator));
        Console.WriteLine("분수식 f1의 최대공약수: " + f2.GratestCommonDivisor(f2.numberator, f2.denominator));

        f1.irreducibleFraction(f1);
        f2.irreducibleFraction(f2);

        f1.addFraction(f1, f2);
        f1.subFraction(f1, f2);
        f1.mulFraction(f1, f2);
        f1.divFraction(f1, f2);
    }
}
