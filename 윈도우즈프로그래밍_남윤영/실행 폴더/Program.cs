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

cal_1();