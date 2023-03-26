#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#define NAME_LENGTH 25

int main(int argc, char* argv[]){
    int in, out;
    char c;

    if((in=open(argv[1], O_RDONLY)) == -1){
        fprintf(stderr, "Cannot open %s for reading\n", argv[1]);
        return -1;
    }

    if((out=open(argv[2], O_CREAT | O_WRONLY | S_IRWXU)) == -1){
        fprintf(stderr, "Cannnot open %s for writting\n", argv[2]);
        return -1;
    }

    while(read(in, &c, 1) != 0){
        write(out, &c, 1);
    }

    close(in);
    close(out);

    return 0;
}