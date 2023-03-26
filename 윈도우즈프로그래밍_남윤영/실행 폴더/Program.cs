int num = 1;

for(int i=0; i<=3; i++){
    for(int q=1; q<=9; q++){
        for(int p=num; p<=num+i; p++){
            Console.Write(p + " * " + q + " = " + p * q + "    ");
        }
    Console.WriteLine();
    }
    num = num + i + 1;
}