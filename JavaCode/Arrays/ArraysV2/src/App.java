public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Arrays 2D and Jagged Demo");

        // int[][] a= new int[2][3];
        // a[0][0]=1;
        // a[0][1]=5;
        // a[0][2]=7;
        // a[1][0]=9;
        // a[1][1]=10;
        // a[1][2]=15;

        // System.out.println(a[0][1]);
        // System.out.println(a[1][1]);
        // System.out.println(a[1][2]);

        // int[][] a= new int[][]{{1,2,3},{4,5,6},{7,8,9}};

        // for(int i=0; i< a.length; i++ )
        // {
        //     for(int j=0; j<a[i].length;j++ )
        //     {
        //         System.out.print(a[i][j]+"\t");
        //     }
        //     System.out.println();
        // }

        //jagged array - ragged array
       // int[][] a= new int[][]{{1,2},{4,5,6,7},{7,8}};

       int[][] a= new int[3][];
       a[0]= new int[]{1,2,3};
       a[1]= new int[]{4,5};
       a[2]= new int[]{1,2,3,4};

        for(int i=0; i< a.length; i++ )
        {
            for(int j=0; j<a[i].length;j++ )
            {
                System.out.print(a[i][j]+"\t");
            }
            System.out.println();
        }

    }

}
