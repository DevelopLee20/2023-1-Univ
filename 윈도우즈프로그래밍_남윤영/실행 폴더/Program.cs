﻿// // 문제 1
// int a, b, c;

// Console.Write("a를 입력하세요 : ");
// a = Int32.Parse(Console.ReadLine());
// Console.Write("b를 입력하세요 : ");
// b = Int32.Parse(Console.ReadLine());
// Console.Write("c를 입력하세요 : ");
// c = Int32.Parse(Console.ReadLine());

// double answer1 = (-b + Math.Sqrt(b*b - 4*a*c)) / 2*a;
// double answer2 = (-b - Math.Sqrt(b*b - 4*a*c)) / 2*a;

// if ((Math.Sqrt(b*b - 4*a*c)) > 0){
//     Console.WriteLine("첫 번째 근은 " + answer1 + "이고, 두 번째 근은" + answer2 + "입니다.");
// }
// else if((Math.Sqrt(b*b - 4*a*c)) < 0){
//     Console.WriteLine("허근입니다.");
// }
// else{
//     Console.WriteLine("첫 번째 근은 " + answer1);
// }

// // 문제 2
// for(int i=9; i>=1; i--){
//     int num1 = 0;
//     int temp = 1;

//     for(int j=1; j<=i; j++){
//         temp *= j;

//         Console.Write(j);
        
//         if(j != i){
//             Console.Write("*");
//         }
//         j = j + 1;
//     }
//     num1 += temp;
//     Console.WriteLine(" " + num1);

//     i = i - 1;
// }
// Console.WriteLine();

// double num2 = 0;
// for(int i=1; i<=5; i++){
//     double output = 1.0 / (double)(i*2);
//     Console.WriteLine("1 / " + i*2 + " = " + output);
//     if(i % 2 == 1){
//         num2 = num2 + output;
//     }
//     else{
//         num2 = num2 - output;
//     }
// }
// Console.WriteLine("최종값: " + num2);

// // 문제 3
// for(int num=9; num>=1; num--){
//     if(num != 9){
//         for(int i=0; i<9-num; i++){
//             Console.Write(" ");
//         }
//     }

//     for(int i=num; i>=1; i--){
//         Console.Write(i);
//     }
//     for(int i=2; i<=num; i++){
//         Console.Write(i);
//     }
//     Console.WriteLine();
// }

// // 문제 4
// int outcount = 4;
// int delta = -1;
// for(int i=0; i<7; i++){
//     for(int j=0; j<outcount; j++){
//         Console.Write("*");
//     }
//     for(int j=0; j<9-2*outcount; j++){
//         Console.Write(" ");
//     }
//     for(int j=0; j<outcount; j++){
//         Console.Write("*");
//     }
//     if(outcount == 1){
//         delta = 1;
//     }
//     outcount += delta;
//     Console.WriteLine();
// }

// // 문제 5
// int num = 1;

// for(int i=0; i<=3; i++){
//     for(int q=1; q<=9; q++){
//         for(int p=num; p<=num+i; p++){
//             Console.Write(p + " * " + q + " = " + (p * q).ToString().PadRight(6, ' '));
//         }
//     Console.WriteLine();
//     }
//     num = num + i + 1;
// }
