#include<stdio.h>
void main()
{
    // int a[5]= {1,2,3,4,5};

    // int x=6;
    // int y[x] //C99 - variable length array - heap - no init allowed

    // int a[2][3];
    // a[0][0]=1;
    // a[0][1]=2;
    // a[0][2]=3;
    // a[1][0]=4;
    // a[1][1]=5;
    // a[1][2]=6;

    // printf("%d\n", a[1][1]);
    // printf("%d\n", a[0][2]);

    // int a[2][3]={1,2,3,4,5,6};
    // printf("%d\n", a[1][1]);
    // printf("%d\n", a[0][2]);


int a[2][3] = {{1,2,3}, {4,5,6}};

for(int i=0; i<2; i++)
{
    for(int j=0; j< 3; j++)
    {
        printf("%d\t", a[i][j]);
    }
    printf("\n");
}

}