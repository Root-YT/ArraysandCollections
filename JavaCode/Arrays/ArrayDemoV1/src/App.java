import java.util.Random;
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Arrays Demo");

        // int[] a= new int[5];
        // System.out.println(a[0]);
        // System.out.println(a[1]);
        // System.out.println(a[2]);
        // System.out.println(a[3]);
        // System.out.println(a[4]);


        //int[] ma= new int[] {1,2,3,4};
        // for(int i=0; i< ma.length; i++)
        // {
        //     System.out.print(ma[i]+"\t");
        // }
        // System.out.println();

            //PrintArray(ma);


        // int sum=0;
        // for(int i=0; i< ma.length; i++)
        // {
        //     //sum= sum+ma[i];
        //     sum+=ma[i];
        // }   

        // System.out.println(sum);



       // int[] ma1= GetRandomArray(10, 50);
      // int[] ma2= GetUserArray(5);
      float[] ma3= new float[]{1.1f, 1.2f};
        PrintArray(ma3);
    }

    public static int[] GetRandomArray(int Size, int Max)
    {
        int[] a= new int[Size];
        Random r= new Random();
        for(int i=0; i<a.length; i++)
        {
            a[i]= r.nextInt(Max);
        }
        return a;
    }


    public static int[] GetUserArray(int Size)
    {
        int[] a= new int[Size];
        Scanner sc= new Scanner(System.in);
        for(int i=0; i<a.length; i++)
        {
            System.out.println("Enter the value at position : "+ i);
            a[i]=Integer.parseInt((sc.nextLine()));
        }
        return a;
    }

    public static void PrintArray(int[] a)
    {
        System.out.println("Printing Array Elements: ");

        for(int i=0; i<a.length; i++)
        {
            System.out.print(a[i]+"\t");
        }
        System.out.println();
    }


     public static void PrintArray(float[] a)
    {
        System.out.println("Printing Array Elements: ");

        for(int i=0; i<a.length; i++)
        {
            System.out.print(a[i]+"\t");
        }
        System.out.println();
    }
}
