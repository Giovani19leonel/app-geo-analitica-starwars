using System;


namespace GeoAnalitica_starwars
{
    class Program
    {
        static void Main(string[] args)
        {

            // int T = int.Parse(Console.ReadLine());
            //int total = T*8;
            /* for(int i=0; i<total; i++ ){
             string[] line = Console.ReadLine().Split(" ");
               double X = double.Parse(line[0]) +X;
               double Y = double.Parse(line[1]) + Y;
               double Z = double.Parse(line[1]) +Z;
             }
             */
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] line1 = Console.ReadLine().Split(" ");
                string[] line2 = Console.ReadLine().Split(" ");
                string[] line3 = Console.ReadLine().Split(" ");
                string[] line4 = Console.ReadLine().Split(" ");
                string[] lane1 = Console.ReadLine().Split(" ");
                string[] lane2 = Console.ReadLine().Split(" ");
                string[] lane3 = Console.ReadLine().Split(" ");
                string[] lane4 = Console.ReadLine().Split(" ");

                double X1 = double.Parse(line1[0]); //1
                double Y1 = double.Parse(line1[1]); //2 
                double Z1 = double.Parse(line1[2]); //3
                double X2 = double.Parse(line2[0]); //4
                double Y2 = double.Parse(line2[1]); //5 
                double Z2 = double.Parse(line2[2]); //6 
                double X3 = double.Parse(line3[0]); //7 
                double Y3 = double.Parse(line3[1]); //8 
                double Z3 = double.Parse(line3[2]); //9 
                double X4 = double.Parse(line4[0]); //10 
                double Y4 = double.Parse(line4[1]); //11
                double Z4 = double.Parse(line4[2]); //12
                double X5 = double.Parse(lane1[0]); //13
                double Y5 = double.Parse(lane1[1]); //14
                double Z5 = double.Parse(lane1[2]); //15
                double X6 = double.Parse(lane2[0]); //16
                double Y6 = double.Parse(lane2[1]); //17
                double Z6 = double.Parse(lane2[2]); //18
                double X7 = double.Parse(lane3[0]); //19
                double Y7 = double.Parse(lane3[1]); //20
                double Z7 = double.Parse(lane3[2]); //21
                double X8 = double.Parse(lane4[0]); //22
                double Y8 = double.Parse(lane4[1]); //23
                double Z8 = double.Parse(lane4[2]); //24
                                                    
                double distancia1 = System.Math.Sqrt(System.Math.Pow((X5 - X1), 2) + System.Math.Pow((Y5 - Y1), 2) + System.Math.Pow((Z5 - Z1), 2));

                double distancia5 = System.Math.Sqrt(System.Math.Pow((X6 - X1), 2) + System.Math.Pow((Y6 - Y1), 2) + System.Math.Pow((Z6 - Z1), 2));

                double distancia6 = System.Math.Sqrt(System.Math.Pow((X7 - X1), 2) + System.Math.Pow((Y7 - Y1), 2) + System.Math.Pow((Z7 - Z1), 2));

                double distancia7 = System.Math.Sqrt(System.Math.Pow((X8 - X1), 2) + System.Math.Pow((Y8 - Y1), 2) + System.Math.Pow((Z8 - Z1), 2));

                // -----------------------------------------------------------------------------------------------------------------------------------------------

                double distancia2 = System.Math.Sqrt(System.Math.Pow((X5 - X2), 2) + System.Math.Pow((Y5 - Y2), 2) + System.Math.Pow((Z5 - Z2), 2));

                double distancia8 = System.Math.Sqrt(System.Math.Pow((X6 - X2), 2) + System.Math.Pow((Y6 - Y2), 2) + System.Math.Pow((Z6 - Z2), 2));

                double distancia9 = System.Math.Sqrt(System.Math.Pow((X7 - X2), 2) + System.Math.Pow((Y7 - Y2), 2) + System.Math.Pow((Z7 - Z2), 2));

                double distancia10 = System.Math.Sqrt(System.Math.Pow((X8 - X2), 2) + System.Math.Pow((Y8 - Y2), 2) + System.Math.Pow((Z8 - Z2), 2));

                // -----------------------------------------------------------------------------------------------------------------------------------------------

                double distancia3 = System.Math.Sqrt(System.Math.Pow((X5 - X3), 2) + System.Math.Pow((Y5 - Y3), 2) + System.Math.Pow((Z5 - Z3), 2));

                double distancia11 = System.Math.Sqrt(System.Math.Pow((X6 - X3), 2) + System.Math.Pow((Y6 - Y3), 2) + System.Math.Pow((Z6 - Z3), 2));

                double distancia12 = System.Math.Sqrt(System.Math.Pow((X7 - X3), 2) + System.Math.Pow((Y7 - Y3), 2) + System.Math.Pow((Z7 - Z3), 2));

                double distancia13 = System.Math.Sqrt(System.Math.Pow((X8 - X3), 2) + System.Math.Pow((Y8 - Y3), 2) + System.Math.Pow((Z8 - Z3), 2));

                // -----------------------------------------------------------------------------------------------------------------------------------------------
                double distancia4 = System.Math.Sqrt(System.Math.Pow((X5 - X4), 2) + System.Math.Pow((Y5 - Y4), 2) + System.Math.Pow((Z5 - Z4), 2));

                double distancia14 = System.Math.Sqrt(System.Math.Pow((X6 - X4), 2) + System.Math.Pow((Y6 - Y4), 2) + System.Math.Pow((Z6 - Z4), 2));

                double distancia15 = System.Math.Sqrt(System.Math.Pow((X7 - X4), 2) + System.Math.Pow((Y7 - Y4), 2) + System.Math.Pow((Z7 - Z4), 2));

                double distancia16 = System.Math.Sqrt(System.Math.Pow((X8 - X4), 2) + System.Math.Pow((Y8 - Y4), 2) + System.Math.Pow((Z8 - Z4), 2));

                // -----------------------------------------------------------------------------------------------------------------------------------------------


                if (distancia1 <= distancia2 & distancia1 <= distancia3 & distancia1 <= distancia4)
                    {
                        Console.WriteLine("{0:F}", distancia1);
        
                    }
               

                     if (distancia2 <= distancia1 & distancia2 <= distancia3 & distancia2 <= distancia4)
                    {
                        Console.WriteLine("{0:F}", distancia2);
         
                    }
              

                    if (distancia3 <= distancia1 & distancia3 <= distancia2 & distancia3 <= distancia4)
                    {
                        Console.WriteLine("{0:F}", distancia3);

                    }
              

                    if (distancia4 < distancia1 & distancia4 < distancia2 & distancia4 < distancia3)
                    {
                        Console.WriteLine("{0:F}", distancia4);
 
                    }
             

                //  System.Console.WriteLine("DISTANCIA:{0:F}", distancia);

            }
        }

    }
}
