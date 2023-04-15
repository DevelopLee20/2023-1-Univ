// // 다음 지시사항을 준수하여 프로그램을 작성하시오.
// // (1) 오늘을 기준으로 근무시간을 출력하는 클래스 생성
// // (2) 키보드로 입사일자 입력 (년-월-일 시:분)
// // (3) DateTime 구조체와 TimeSpan 구조체 선언
// // (4) 기타 사항은 실행 결과 참조

// class Company{
//     String InCompany;

//     public Company(String InCompany){
//         this.InCompany = InCompany;
//     }

//     public void howLong(){
//         DateTime NowTime = DateTime.Now;
//         DateTime InTime = DateTime.Parse(InCompany);

//         TimeSpan GapTime = NowTime.Subtract(InTime);

//         Console.WriteLine("> 입사일자 : " + InTime.ToString());
//         Console.WriteLine("> 현재시간 : " + NowTime.ToString());

//         Console.Write("> 지금까지 " + GapTime.Days + "일 ");
//         Console.Write(GapTime.Hours + "시간 ");
//         Console.Write(GapTime.Minutes + "분 ");
//         Console.WriteLine(GapTime.Seconds + "초를 근무하였습니다.");
//     }
// }

// class Program{
//     public static void Main(String[] args){
//         Console.Write("> 입사일자 입력(년-월-일 시:분) : ");
//         String InCompany = Console.ReadLine();

//         Company com = new Company(InCompany);
//         com.howLong();
//     }
// }

// 02 다음 지시사항을 준수하여 프로그램을 작성하시오.
// (1) 현재 날짜와 시간 기준 : 포맷 형식으로 출력하는 클래스 생성
// (2) CultureInfo 클래스를 사용
// (3) namespace 선언
// (4) 기타 사항은 실행 결과 참조

using System.Globalization;

class Program{
    public static void Main(String[] args){
        DateTime Today = DateTime.Now;
        CultureInfo Culture = CultureInfo.CreateSpecificCulture("ko-KR");
        Console.WriteLine("오늘 : " + Today.ToString("yyyy년 MM월 dd일", Culture));
        Console.WriteLine("F : " + Today.ToString("F"));
        Console.WriteLine("s : " + Today.ToString("s"));
    }
}