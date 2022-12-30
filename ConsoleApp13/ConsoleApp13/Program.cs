using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
	struct File
	{
        string head;
        string number;
        string tail;
	}
    static List<string> Solution(List<string> files)
    {
        List<string> answer = files;
        List<File> files2 = new List<File>();
        //string head;
        //string number;
        //string tail;
        bool ishead = true;
        int numIndex = 0;

        for (int i = 0; i < files.Count; i++)
		{
            files[i] = files[i].ToUpper();
            numIndex = 0;
            for (int j = 0; j < files[i].Length; j++)
            {
                char temp = files[i][j];
                if (ishead && char.IsNumber(temp)) 
				{
                    string head = files[i].Substring(0, j);
                    Console.WriteLine($"{head}");
                    numIndex = j;
                    ishead = false;
                }
				if (!ishead && !char.IsNumber(temp))
				{
                    string number = files[i].Substring(numIndex, j);
                    Console.WriteLine($"{number}");
                }
            }
            ishead = true;
        }
		
        
        

        return answer;
    }

    static void Main()
    {
        List<string> files1 = new List<string>()
            { "img12.png", "img10.png", "img02.png", "img1.png", "IMG01.GIF", "img2.JPG" };
        List<string> files2 = new List<string>()
            { "F-5 Freedom Fighter", "B-50 Superfortress", "A-10 Thunderbolt II", "F-14 Tomcat" };
        Solution(files1);
        Solution(files2);
    }
}