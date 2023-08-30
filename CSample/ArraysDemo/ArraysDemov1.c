#include<stdio.h>
#include<stdlib.h>
#include<time.h>

void PrintArray(int a[], int size)
{
    printf("Printing Elements: \n");
      for(int i=0; i<size; i++)
      {
        printf("%d\t", a[i]);
      }
      printf("\n");
}

void InitArrayUser(int a[], int size)
{
    printf("Getting Elements: \n");
      for(int i=0; i<size; i++)
      {
        printf("Enter the value at position %d\n", i);
        scanf("%d", &a[i]);
      }
     
}


void InitArrayRandom(int a[], int size, int max)
{
    printf("Initializing Random Elements: \n");
    srand(time(0));
      for(int i=0; i<size; i++)
      {
       a[i]= rand()%max;
      }
     
}

int GetArraySum(int a[], int size)
{
    int sum= 0;
    for(int i=0; i<size; i++)
   {
    sum+=a[i];
   }
   return sum;
}

void main()
{

    int a[5]={11,12,13,14,15};
    //int a[5];
    //InitArrayUser(a, 5);
    //InitArrayRandom(a, 5, 100);
    PrintArray(a, 5);
    int result= GetArraySum(a, 5);
    printf("%d\n", result);
   // int a[5]; //garbage values

    //int a[5]={1,2,3,4,5};
//    int a[5];

//    a[0]=3;
//    a[1]=5;
//    a[2]=7; 
//    a[3]= 9;
//    a[4]=11;

    //int a[5]= {1, 2};
    //int a[5]= {0};
    // printf("%d\n", a[0]);
    // printf("%d\n", a[1]);
    // printf("%d\n", a[2]);
    // printf("%d\n", a[3]);
    // printf("%d\n", a[4]);
   // printf("%d\n", a[5]); //Bounds Check garbage  - Index out of bounds


//    int sum=0;

//    for(int i=0; i<5; i++)
//    {
//     printf("%d\t", a[i]);
//     //sum= sum+a[i];
//     sum+=a[i];
//    }

//    printf("\nThe sum is %d\n", sum);
}