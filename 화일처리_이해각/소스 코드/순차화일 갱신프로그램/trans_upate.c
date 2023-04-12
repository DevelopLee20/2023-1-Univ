#include <stdio.h>
#include <string.h>
#define SENTINEL 100 // 파일의 끝을 알리는 키값

struct product_rec{
    int id;
    char name[20];
    int inventory;
};

struct update_rec{
    char update_code;
    int id;
    char name[20];
    int inventory;
};

FILE *old_master, *transaction, *new_master, *report;
struct product_rec old_rec, buffer_rec;
struct update_rec trans_rec;
int add_cnt = 0, change_cnt = 0, delete_cnt = 0, error_cnt = 0;
int delete_record;
char contents[100];

void Get_Old(){
    fscanf(old_master, "\n%d %s %d", &old_rec.id, old_rec.name, &old_rec.inventory);
}

void Get_Transaction(){
    fscanf(transaction, "\n%c %d %s %d", &trans_rec.update_code, &trans_rec.id, trans_rec.name, &trans_rec.inventory);
}

void Put_Old_To_New(){
    fprintf(new_master, "%d %s %d\n", old_rec.id, old_rec.name, old_rec.inventory);
}

void Put_Transaction_To_New(){
    fprintf(new_master, "%d %s %d\n", trans_rec.id, trans_rec.name, trans_rec.inventory);
}

void Error_Print(char err_code){
    switch (err_code)
    {
    case 'A':
        fprintf(report, "%c %d %s %d : 추가오류\n", trans_rec.update_code, trans_rec.id, trans_rec.name, trans_rec.inventory);
        break;

    case 'C':
        fprintf(report, "%c %d %s %d : 해당 레코드 없음\n", trans_rec.update_code, trans_rec.id, trans_rec.name, trans_rec.inventory);
        break;
    
    case 'E':
        fprintf(report, "%c %d %s %d : 갱신코드오류\n", trans_rec.update_code, trans_rec.id, trans_rec.name, trans_rec.inventory);
        break;
    }
}

int main(void){
    old_master = fopen("oldmaster.txt", "r");
    transaction = fopen("transaction.txt", "r");
    new_master = fopen("newmaster.txt", "w");
    report = fopen("report.txt", "w");

    Get_Old();
    Get_Transaction();

    while(!(old_rec.id==SENTINEL || trans_rec.id==SENTINEL)){
        if(old_rec.id < trans_rec.id){
            Put_Old_To_New();
            Get_Old();
        }

        else if(old_rec.id == trans_rec.id){
            switch (trans_rec.update_code)
            {
            case 'A':
                Error_Print('A');
                Get_Transaction();
                break;
            
            case 'C':
                old_rec.inventory += trans_rec.inventory;
                change_cnt++;
                Get_Transaction();
                break;
            
            case 'D':
                Get_Old();
                delete_cnt++;
                Get_Transaction();
                break;

            default:
                Error_Print('E');
                error_cnt++;
                break;
            }
        }
        else{
            switch (trans_rec.update_code){
            case 'A':
                Put_Transaction_To_New();
                add_cnt++;
                Get_Transaction();
                break;

            case 'C':
            case 'D':
                Error_Print('C');
                error_cnt++;
                Get_Transaction();
                break;

            default:
                Error_Print('E');
                error_cnt++;
                Get_Transaction();
                break;
            }
        }
    }

    // 센티널을 만났을 때
    
    if(trans_rec.id == SENTINEL){
        while (old_rec.id != SENTINEL)
        {
            Put_Old_To_New();
            Get_Old();
        }
        fprintf(new_master, "%d %s %d\n", SENTINEL, "*", 0);
    }
    else{
        while(trans_rec.id != SENTINEL){
            switch (trans_rec.update_code)
            {
            case 'A':
                Put_Transaction_To_New();
                add_cnt++;
                Get_Transaction();
                break;

            case 'C':
            case 'D':
                Error_Print('C');
                error_cnt++;
                Get_Transaction();
                break;

            default:
                Error_Print('E');
                error_cnt++;
                Get_Transaction();
                break;
            }
        }
    }

    fprintf(new_master, "%d %s %d\n", SENTINEL, "*", 0);

    // 마무리
    printf("추가 횟수 : %d\n", add_cnt);
    printf("수정 횟수 : %d\n", change_cnt);
    printf("삭제 횟수 : %d\n", delete_cnt);
    printf("오류 횟수 : %d\n", error_cnt);
    fprintf(report, "==========\n");
    fprintf(report, "갱 신 요 약\n");
    fprintf(report, "==========\n");
    fprintf(report, "추가 횟수 : %d\n", add_cnt);
    fprintf(report, "수정 횟수 : %d\n", change_cnt);
    fprintf(report, "삭제 횟수 : %d\n", delete_cnt);
    fprintf(report, "오류 횟수 : %d\n", error_cnt);

    fclose(old_master);
    fclose(transaction);
    fclose(new_master);
    fclose(report);
}