// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void cal_1(){
    int temp1 = 0;
    int temp2 = 1;

    for(int i=1; i<=100; i++){
        temp1 += 2 * i;
    }

    for(int i=1; i<=10; i++){
        temp2 *= i;
    }

    Console.WriteLine(temp1 + temp2);
}

void cal_2_a(){
    int temp1 = 1;
    int temp2 = 1;

    for(int i=2; i<=10; i++){
        temp2 *= i;
        temp1 += temp2;
    }

    Console.WriteLine(temp1);
}

void cal_2_b(){
    double temp = 1;

    for(double i=2; i<=10; i++){
        if(i % 2 == 0){
            temp -= 1.0 / i;
        }
        else{
            temp += 1.0 / i;
        }
    }

    Console.WriteLine(temp);
}

void cal_3(){
    for(int i=1; i<=9; i++){
        for(int j=2; j<=5; j++){
            Console.Write(j + " * " + i + " = " + j*i + ", ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    for(int i=1; i<=9; i++){
        for(int j=6; j<=9; j++){
            Console.Write(j + " * " + i + " = " + j*i + ", ");
        }
        Console.WriteLine();
    }
}

void cal_4(){
    bool check = true;

    for(int i=2; i<=100; i++){
        for(int j=2; j<=(int)Math.Sqrt(i); j++){
            if(i % j == 0){
                check = false;
                break;
            }
        }

        if(check){
            Console.Write(i + ", ");
        }

        check = true;
    }
    Console.WriteLine();
}

void cal_5(){
    for(int i=2; i<=500; i++){
        int temp = 1;

        for(int j=2; j<i; j++){
            if(i % j == 0){
                temp += j;
            }
        }

        if(i == temp){
            Console.Write(i + ", ");
        }
    }
}

void cal_6(int number1){
    int number2 = number1;
    int temp = 1;

    Console.Write(number2 + "는 ");

    while(number1 > temp*10){
        temp *= 10;
    }

    while(temp >= 1){
        if(number1 / temp != number2 % 10){
            Console.WriteLine("회문수가 아닙니다!");
            return;
        }
        number1 %= temp;
        temp /= 10;
        number2 /= 10;
    }

    Console.WriteLine("회문수 입니다!");
}

void cal_7(){
    for(int i=100; i<=500; i++){
        int x = i / 100;
        int y = i / 10 % 10;
        int z = i % 10;

        if(i == Math.Pow(x, 3)+Math.Pow(y, 3)+Math.Pow(z, 3)){
            Console.Write(i + " ");
        }
    }
}

void cal_8(int a, int b){
    int i = 0;
    int g = 0;

    Console.WriteLine("수1: " + a);
    Console.WriteLine("수2: " + b);

    while((i != a) && (i != b)){
        i += 1;

        if(a % i == 0 && b % i == 0){
            g = i;
        }
    }
    Console.WriteLine("최대 공약수: " + g);
    Console.WriteLine("최소 공배수: " + a * b / g);
}

void cal_9(){
    for(int i=1; i<=9; i+=2){
        int blank = (9-i)/2;
        for(int j=0; j<blank; j++){
            Console.Write(" ");
        }
        for(int j=0; j<i; j++){
            Console.Write("*");
        }
        for(int j=0; j<blank; j++){
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    for(int i=7; i>=0; i-=2){
        int blank = (9-i)/2;
        for(int j=0; j<blank; j++){
            Console.Write(" ");
        }
        for(int j=0; j<i; j++){
            Console.Write("*");
        }
        for(int j=0; j<blank; j++){
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void cal_10(int value){
    int back5 = 0;
    int back1 = 0;
    int sip5 = 0;
    int sip1 = 0;
    int one5 = 0;
    int one1 = 0;

    while(value != 0){
        if(value >= 500){
            value -= 500;
            back5 += 1;
            continue;
        }
        if(value >= 100){
            value -= 100;
            back1 += 1;
            continue;
        }
        if(value >= 50){
            value -= 50;
            sip5 += 1;
            continue;
        }
        if(value >= 10){
            value -= 10;
            sip1 += 1;
            continue;
        }
        if(value >= 5){
            value -= 5;
            one5 += 1;
            continue;
        }
        if(value >= 1){
            value -= 1;
            one1 += 1;
            continue;
        }
    }

    Console.WriteLine("500원 " + back5 + "개");
    Console.WriteLine("100원 " + back1 + "개");
    Console.WriteLine("50원 " + sip5 + "개");
    Console.WriteLine("10원 " + sip1 + "개");
    Console.WriteLine("5원 " + one5 + "개");
    Console.WriteLine("1원 " + one1 + "개");
}

Console.WriteLine("상품가격을 입력하시오 (1000원 미만)");
int value = Console.Read();
cal_10(value);