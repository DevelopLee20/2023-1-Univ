#include "BTree.h"
extern BufferManager *bufferManager;
extern BTreeHeader *bTreeHeader;
BOOL retrieveRecord(Key key, BTreeRecord *record) {
	/*인덱스 셋으로 부터 레코드 검색*/
	BTreePagePtr page=(BTreePagePtr)malloc(bufferManager->pageSize);
	int i=0;
	BOOL found=FALSE;
	if(findRecord(key, page)) {
		i=peek()->index;
		copyRecord(RECORDPTR(page)+i, record);
		found=TRUE;
	}
	free(page);
	return found;
}
BOOL findRecord(Key key, BTreePagePtr page) {
	/*Key를 가진 Record를 찾아가는 경로를 스택에 push하고
			도달한 Leaf를 page에 저장한다*/
	int i=0, targetPage=bTreeHeader->rootPage;
	bTreeHeader->stackPtr=0;
	readBTreePage(targetPage, page);
	while(ISLEAF(page) == FALSE) {
		for (i = 0; (i < KEYCNT(page)) && (KEY(page, i) < key); i++) {
			;
		}
		push(PAGENO(page), i);
		targetPage=CHILD(page, i);
		readBTreePage(targetPage, page);
	}
	for (i = 0; (i < KEYCNT(page)) && (RECORD(page, i).key < key); i++) {
		;
		}
	

	push(PAGENO(page), i);

	if((i < KEYCNT(page)) && (key == RECORD(page, i).key)) {
		return TRUE;
	}
	else {
		return FALSE;
	}
}

void Sequential_Backup(void) { // 순차택스트화일로백업하기 b
	FILE* fp = NULL;
	FILE* fp1 = NULL;
	int buffer[100];
	int i;
	int count;

	fp = fopen("data.txt", "rb");

	if (fp == NULL) {
		fprintf(stderr, "data.txt not exist\n");
	}

	fp1 = fopen("backup.txt", "wb");

	if (fp1 == NULL) {
		fprintf(stderr, "backup.txt not exist\n");
	}

	while ((count = fread(buffer, sizeof(char), 100, fp)) != 0) {
		fwrite(buffer, sizeof(char), count, fp1);
	}
	fclose(fp);
	fclose(fp1);
	printf("backup success\n");
}
void Sequential_Search(void) { // 순차탐색 s
	int choice;
	int page_search;
	int key_search;
	int i = 1;
	BTreePagePtr page = (BTreePagePtr)malloc(bufferManager->pageSize);

	while (readBTreePage(i, page)) {
		if (ISLEAF(page) == FALSE) {
			for (int j = 0; (j < KEYCNT(page)); j++) {
			}
		}
		else {
			printf("페이지번호 : %d \n", PAGENO(page));
			printf("레코드개수 : %d\n", KEYCNT(page));
			for (int j = 0; (j < KEYCNT(page)); j++) {
				printf("%d %s\n", RECORD(page, j).key, RECORD(page, j).value);
			}
			printf("다음페이지 : %d\n\n", NEXT(page));
		}
		i++;
	}
}

void Get_Header(void) {
	/*헤더정보 가져오기*/
	printf("루트노드 페이지번호   : %d\n", bTreeHeader->rootPage);
	printf("리프노드 첫페이지번호 : %d\n", bTreeHeader->firstSequencePage);
	printf("B+ 트리의 차수        : %d\n", bTreeHeader->order); //(int)((pageSize - (정수4바이트) * 4) / (정수4바이트) * 2)) + 1;
	printf("내부노드 최소키 개수  : %d\n", bTreeHeader->minKey); //order / 2 - 1 + order % 2;
	printf("리프의 레코드 최대수  : %d\n", bTreeHeader->maxRecord); //pageSize - (정수4바이트) * 3) / (정수4바이트);
	printf("리프노드 최소키 개수  : %d\n", bTreeHeader->minRecord); // bTreeHeader->maxRecord / 2
}

void retrieveAllPages() { // 백업파일 가져오기 o
	BTreePagePtr page = (BTreePagePtr)malloc(bufferManager->pageSize);
	int i = 1;

	while (readBTreePage(i, page)) {
		if (ISLEAF(page) == FALSE) {
			printf("페이지번호   : %d (내부노드)\n", PAGENO(page));
			printf("다음페이지   : %d\n", NEXT(page));
			printf("키의개수     : %d\n", KEYCNT(page));
			printf("키리스트     : ");
			for (int j = 0; (j < KEYCNT(page)); j++) {
				printf("%d, (%d), ", CHILD(page, j), KEY(page, j));
			}
			printf("%d\n\n", CHILD(page, KEYCNT(page)));

		}
		else {
			printf("페이지번호 : %d (리프노드)\n", PAGENO(page));
			printf("레코드개수 : %d\n", KEYCNT(page));
			for (int j = 0; (j < KEYCNT(page)); j++) {
				printf("%d %s\n", RECORD(page, j).key, RECORD(page, j).value);
			}
			printf("다음페이지 : %d\n", NEXT(page));
			printf("--------------------------------------\n");
		}
		i++;
	}
}

