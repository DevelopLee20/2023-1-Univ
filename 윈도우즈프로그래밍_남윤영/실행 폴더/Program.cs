// 문제 1번

int[,] transpose(int[,] array){
    int[,] temp = new int[array.GetLength(1), array.GetLength(0)];
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            temp[j,i] = array[i,j];
        }
    }
    return temp;
}

int[,] array_1 = {{1,2,3},{4,5,6}};
int[,] array_2 = transpose(array_1);

for(int i=0; i<array_2.GetLength(0); i++){
    for(int j=0; j<array_2.GetLength(1); j++){
        Console.Write(array_2[i,j] + " ");
    }
    Console.WriteLine();
}

// // 문제 2번

// char[] com = {'C','o','m','p','u','t','e','r'};

// foreach(char i in com){
//     Console.Write(i);
// }
// Console.WriteLine();

// // 문제 3번

// int[][] array = new int[3][]{
//     new int[] {0,1,2},
//     new int[] {4,5,6,7},
//     new int[] {10,11,12,13,14}
// };

// for(int i=0; i<array.GetLength(0); i++){
//     for(int j=0; j<array[i].Length; j++){
//         Console.Write(array[i][j] + " ");
//     }
//     Console.WriteLine();
// }

// // 문제 4번

// Random r = new Random();
// int[] random = new int[5];

// for(int i=0; i<5; i++){
//     random[i] = r.Next(100) + 1;
//     Console.Write(random[i] + " ");
// }
// Console.WriteLine();

// for(int i=0; i<5; i++){
//     for(int j=1; j<5; j++)
//         if(random[j-1] < random[j]){
//             int temp = random[j-1];
//             random[j-1] = random[j];
//             random[j] = temp;
//         }
// }

// for(int i=0; i<5; i++){
//     Console.WriteLine(random[i]);
// }

// // 문제 5번

// Random r = new Random();
// double[] random = new double[5];

// for(int i=0; i<5; i++){
//     random[i] = r.Next(100) + r.NextDouble();
//     Console.Write(random[i] + " ");
// }
// Console.WriteLine();

// for(int i=0; i<5; i++){
//     for(int j=1; j<5; j++)
//         if(random[j-1] < random[j]){
//             double temp = random[j-1];
//             random[j-1] = random[j];
//             random[j] = temp;
//         }
// }

// for(int i=0; i<5; i++){
//     Console.WriteLine(random[i]);
// }

// // 문제 6번

// int[,] hang1 = {{1,2},{3,4}};
// int[,] hang2 = {{5,6},{7,8}};

// for(int i=0; i<hang1.GetLength(0); i++){
//     for(int j=0; j<hang2.GetLength(1); j++){
//         int sum = 0;
//         for(int k=0; k<hang1.GetLength(1); k++){
//             sum += hang1[i,k] * hang2[k,j];
//         }
//         Console.Write(sum + " ");
//     }
//     Console.WriteLine();
// }

// // 문제 7번

// int[,] score = new int[3,5];

// for(int j=0; j<5; j++){
//     Console.Write("국어: ");
//     score[0,j] = Int32.Parse(Console.ReadLine());
// }
// for(int j=0; j<5; j++){
//     Console.Write("영어: ");
//     score[1,j] = Int32.Parse(Console.ReadLine());
// }
// for(int j=0; j<5; j++){
//     Console.Write("수학: ");
//     score[2,j] = Int32.Parse(Console.ReadLine());
// }

// int sum;

// for(int i=0; i<5; i++){
//     sum = score[0,i] + score[1,i] + score[2,i];

//     Console.WriteLine();
//     Console.WriteLine("학생" + i);
//     Console.WriteLine("총점: " + sum);
//     Console.WriteLine("평균: " + sum/3);
// }

// Console.WriteLine();

// sum = 0;
// for(int j=0; j<5; j++){
//     sum += score[0,j];
// }
// Console.WriteLine("국어 과목 평균: " + sum/5);

// sum = 0;
// for(int j=0; j<5; j++){
//     sum += score[1,j];
// }
// Console.WriteLine("영어 과목 평균: " + sum/5);

// sum = 0;
// for(int j=0; j<5; j++){
//     sum += score[2,j];
// }
// Console.WriteLine("수학 과목 평균: " + sum/5);

// // 문제 8번

// int num = Int32.Parse(Console.ReadLine());
// int x = 0;
// int y = num / 2;
// int[,] array = new int[num,num];

// for(int i=1; i<=num*num; i++){
//     array[x,y] = i;

//     if(i % num == 0){
//         x += 1;
//         if(x == 3){
//             x = 0;
//         }
//     }
//     else{
//         x -= 1;
//         y -= 1;
//         if(x == -1){
//             x = num - 1;
//         }
//         if(y == -1){
//             y = num - 1;
//         }
//     }
// }

// for(int i=0; i<num; i++){
//     for(int j=0; j<num; j++){
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
// }