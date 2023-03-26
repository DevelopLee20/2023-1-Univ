#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#define NAME_LENGTH 25

int main(void){
    char in_file[NAME_LENGTH], out_file[NAME_LENGTH];
    int in, out;
    char c;

    printf("Enter source file name: ");
    scanf("%s", in_file);
    printf("Enter destination file name: ");
    scanf("%s", out_file);

    if((in=open(in_file, O_RDONLY)) == -1){
        fprintf(stderr, "Cannot open %s for reading\n", in_file);
        return -1;
    }

    if((out=open(out_file, O_CREAT | O_WRONLY | S_IRWXU)) == -1){
        fprintf(stderr, "Cannnot open %s for writting\n", out_file);
        return -1;
    }

    while(read(in, &c, 1) != 0){
        write(out, &c, 1);
    }

    close(in);
    close(out);

    return 0;
}