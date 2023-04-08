// // 1번 문제

// Console.Write("단을 입력하세요 : ");
// int num = Convert.ToInt32(Console.ReadLine());
// String [] array = new String[9];

// for(int i=1; i<=9; i++){
//     String temp = num + " * " + i + " = " + num * i;
//     array[i-1] = temp;
// }

// foreach (String item in array){
//     Console.WriteLine(item);
// }

// // 2번 문제
// String[] str = {"computer","science","ENGINEERING","android","VISUALSTUDIO"};

// Console.Write("검색할 단어를 입력하세요 : ");
// String word = Console.ReadLine();
// Boolean NoneOut = true;

// foreach(String item in str){
//     if(item.ToUpper() == word.ToUpper()){
//         Console.WriteLine("검색한 단어 " + word + "(이)가 배열에 있습니다.");
//         NoneOut = false;
//     }
// }

// if(NoneOut){
//     Console.WriteLine("검색한 단어 " + word + "(이)가 배열에 없습니다.");
// }

// 3번 문제
String[,] library = new String[10,2];
Boolean NoExits = true;
int count = 0;

do
{
    Console.WriteLine("************************************************************");
    Console.WriteLine("1 : 도서 추가, 2 : 도서 검색, 3 : 도서 리스트 출력, 0 : 종료");
    Console.WriteLine("************************************************************");
    int switch_on = Convert.ToInt32(Console.ReadLine());

    switch (switch_on){
        case 1:
            Console.WriteLine();
            if(count != 10){
                Console.WriteLine("입력할 도서(책이름, 저자)를 입력하세오. 최대 10개 입력 가능 : ex) 저자명,도서명");
                String[] input = Console.ReadLine().Split(",");
                library[count,0] = input[0];
                library[count,1] = input[1];
                count += 1;
            }
            else{
                Console.WriteLine("수용가능한 도서(10개)를 초과했습니다!");
            }
            Console.WriteLine();
            break;

        case 2:
            Console.WriteLine();
            Console.WriteLine("찾고자 하는 도서의 이름이나 저자의 이름을 입력하시오");
            String input2 = Console.ReadLine();
            Boolean NoBook = true;

            for(int i=0; i<count; i++){
                for(int j=0; j<2; j++){
                    if(library[i,j] == input2){
                        Console.WriteLine("찾고자 하는 도서가 존재함");
                        Console.Write(library[i,0] + " ");
                        Console.WriteLine(library[i,1]);
                        NoBook = false;
                    }
                }
            }

            if(NoBook){
                Console.WriteLine("찾고자 하는 도서가 존재하지 않음");
            }
            Console.WriteLine();
            break;

        case 3:
            Console.WriteLine();
            Console.WriteLine("전체 도서 목록");
            Console.WriteLine(count);
            for(int i=0; i<count; i++){
                Console.Write(i+1 + " : ");
                Console.Write(library[i,0] + " ");
                Console.WriteLine(library[i,1]);
            }
            Console.WriteLine();
            break;

        case 0:
            NoExits = false;
            break;
    }

} while (NoExits);

Console.WriteLine("종료");