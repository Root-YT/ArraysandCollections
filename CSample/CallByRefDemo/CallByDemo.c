#include<stdio.h>

void Increment(int x)
{
    printf("The value of x inside Increment is %d\n", x);
    x=x+10;
    printf("The value of x inside Increment after is %d\n", x);
}

void IncrementRef(int *x)
{
    printf("The value of x inside Increment is %d\n", *x);
    *x=*x+10;
    printf("The value of x inside Increment after is %d\n", *x);
}


void main()
{
     int sample= 5;
     printf("The value of sample inside main is %d\n", sample);
     //Increment(sample);
     IncrementRef(&sample);
     printf("The value of sample inside main after is %d\n", sample);
}