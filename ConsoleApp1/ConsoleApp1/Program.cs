using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        int[] iArr = Array.ConvertAll(
                         (Console.ReadLine()).Split(','),
                         n => int.Parse(n));
        //string[] s = Console.ReadLine().Split(',');
        //int[] iArr2 = Array.ConvertAll(s, n => int.Parse(n));

        for(int i=1; i<iArr.Length; i++)
        {
            for(int j=0; j < i; j++)
            {
                if (iArr[j] > iArr[i])
                {
                    int tmp = iArr[i];
                    iArr[i] = iArr[j];
                    iArr[j] = tmp;
                }
            }
        }
        for(int i=0; i < iArr.Length; i++)
            Console.Write("{0} ", iArr[i]);        
        Console.ReadKey();
    }

  
}