// BTreeMain.c
/* ��� ����
i : (Ű,��)�� ������ ���ڵ� ����
d : Ű�� ������ ���ڵ� ����
r : Ű�� ������ ���ڵ� �˻�
s : ����Ž��
? : �����������
a : ��� ������ ����(1����������)
*/
#include "BTree.h"
#define PAGE_SIZE 64

int main() {
	FILE *fp, *fp_backup;
	BTreeRecord record;
	char command;
	BOOL file_not_Exist;
	fp = fopen("data.txt", "r");   //Ʈ������ ȭ�� �����ϴ��� üũ
	if (fp == NULL) {
		file_not_Exist = TRUE;     //������ ��
		fp = fopen("data.txt", "w"); //ȭ�� ���� ����
	}
	else
		file_not_Exist =FALSE;
	fclose(fp);
	 	initBTree("data.txt", PAGE_SIZE, file_not_Exist); //���� ��������� �ʱ�ȭ. ����������� ��Ʈ������ ����

	while (1) {
		fscanf(stdin, "%c", &command);
		if (command == 'x' || command == 'X') break;
		switch (command) {
		case 'i':    //(Ű,��)�� ������ ���ڵ� ����
			system("cls");
			printf("(Ű,��)�� ������ ���ڵ� ����\n");
			fscanf(stdin, "%i %s", &record.key, &record.value);
			if (insertRecord(&record)) {
				printf("insert (%d, %s) : success\n", record.key, record.value);
			}
			else {
				printf("Insert (%d, %s) : fail\n", record.key, record.value);
			}
			break;
		case 'd' :     //Ű�� ������ ���ڵ� ����
			system("cls");
			printf("Ű�� ������ ���ڵ� ����\n");
			fscanf(stdin, "%i", &record.key);
			if (deleteRecord(record.key)) {
				printf("Delete (%d) : success\n", record.key, record.value);
			} else {
				printf("Delete (%d) : fail\n", record.key);
			}
			break;
		case 'r':    //Ű�� ������ ���ڵ� �˻�
			system("cls");
			printf("���� ����\n");
			fscanf(stdin, "%i", &record.key);
			if (retrieveRecord(record.key, & record)) {
				printf(
					"Retrive (%d, %s) : success\n",
					record.key,
					record.value);
			} else {
				printf("Retrive (%d) : fail\n", record.key);
			}
			break;
		case 'a':    //��������� �˻� a
			system("cls");
			printf("��������� �˻�\n");
			retrieveAllPages();
			break;
		case 'h':    //������� ����
			system("cls");
			printf("������� ����\n");
			Get_Header();
			break;
		case 's':    //�����˻� s
			system("cls");
			printf("��������\n");
			Sequential_Search();
			break;

		case 'o':    //���ȭ�� �������� o
			system("cls");
			printf("���ȭ�� ��������\n");
			retrieveAllPages();
			break;
		case 'b':    //�����ý�Ʈȭ��(backup.txt)�� ����ϱ� b
			system("cls");
			printf("�����ý�Ʈȭ�Ϸ� ����ϱ�\n");
			Sequential_Backup();
			break;
		case 'n':    //������ȭ�� �ʱ�ȭ n
			system("cls");
			printf("������ȭ�� �ʱ�ȭ\n");
			BOOL file_not_Exist = TRUE;
			FILE* fp, * fp_backup;

			fp = fopen("data.txt", "w");
			fclose(fp);
			initBTree("data.txt", PAGE_SIZE, file_not_Exist);
			printf("success\n");
			break;
		}
	}
	closeBTree();
	return 0;
}