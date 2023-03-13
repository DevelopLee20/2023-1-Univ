// C#으로 프로그래밍 하시오.

// 1. 다음을 계산하여 출력하시오.

// a. |b^2 - 4ac|       // ^는 제곱

// b. log10(x+y)^3   // 밑지수 10, ^3은 세제곱

// c. root((x1-x2)^2+(y1-y2)^2) //root 는 루트

 

// 2. 원금과 이율, 기간을 입력받아 복리법으로 원리합계를 구하는 프로그램

// S=원금*(1+이율)^기간

 

// 3. 반지름 (r)을 읽어 원의 면적을 구하시오

// S = 4*파이*r^2

// 4. 연도를 읽어 윤년인지 판별하는 프로그램

// 5. 10개의 정수를 읽어서 제일 큰 수를 출력하는 프로그램을
Console.WriteLine("Hello, World!");

double cal_a(double a, double b, double c){
    double dump1 = Math.Pow(b,2);
    double dump2 = 4 * a * c;
    double sum = dump1 - dump2;

    return Math.Abs(sum);
}

double cal_b(double x, double y){
    double dump1 = Math.Log10(x+y);
    double dump2 = Math.Pow(dump1,3);

    return dump2;
}

double cal_c(double x1, double x2, double y1, double y2){
    double dump1 = (x1-x2) * (x1-x2);
    double dump2 = (y1-y2) * (y1-y2);
    double sum = Math.Sqrt(dump1 + dump2);

    return sum;
}

double cal_2(double principal, double inrate, double period){
    double dump1 = principal;
    double dump2 = (1+inrate);

    dump2 = Math.Pow(dump2, period);

    double sum = dump1 * dump2;

    return sum;
}

double cal_3(double r){
    double dump1 = 4.0 * 3.141592;
    double dump2 = r * r;
    double sum = dump1 * dump2;

    return sum;
}

void cal_4(int year){
    Console.Write(year);

    if (year % 400 == 0){
        Console.WriteLine("는 윤년입니다.");
    }
    else if(year % 100 == 0){
        Console.WriteLine("는 윤년이 아닙니다.");
    }
    else if(year % 4 == 0){
        Console.WriteLine("는 윤년입니다.");
    }
    else{
        Console.WriteLine("는 윤년이 아닙니다.");
    }
}

int cal_5(int[] array){
    int maximum = array[0];

    for(int i=1; i<10; i++){
        if(maximum < array[i]){
            maximum = array[i];
        }
    }
    return maximum;
}

int[] array = new int[10];
double a, b, c, d;

Console.Write("1번의 a문제 입력: ");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
Console.WriteLine(cal_a(a, b, c));

Console.Write("1번의 b문제 입력: ");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
Console.WriteLine(cal_b(a, b));

Console.Write("1번의 c문제 입력: ");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
d = double.Parse(Console.ReadLine());
Console.WriteLine(cal_c(a, b, c, d));

Console.Write("2번 문제 입력: ");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
Console.WriteLine(cal_2(a, b, c));

Console.Write("3번 문제 입력: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine(cal_3(a));

Console.Write("4번 문제 입력: ");
a = double.Parse(Console.ReadLine());
cal_4((int)a);

Console.Write("5번 문제 입력: ");
for(int i=0; i<10; i++){
    array[i] = int.Parse(Console.ReadLine());
}
Console.Write("제일 큰 수는: ");
Console.WriteLine(cal_5(array));