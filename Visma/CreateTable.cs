using System;
using System.Collections.Generic;

public  class  CreateTable
{
    Document document = new Document();
  
    List<List<string>> table = new List<List<string>>();

    public int totalSum=0;
    public int endSum = 0;
    public int lastSum;
    int alphaNumber = 0;
    char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();


    public List<List<string>> createTable()
    {
        while(totalSum <= document.maxSumm)
        {
            
            int value = sum();
            totalSum += value;
            if (!(totalSum > document.maxSumm))
            {
                List<string> row = new List<string>();
                row.Add(alpha[alphaNumber].ToString());
                row.Add(value.ToString());
                alphaNumber++;
                table.Add(row);
            }
            else
            {

                endSum=totalSum - value;
                lastSum = value;
            }
        }
        return table;
    }

    public int sum()
    {
        Random rnd = new Random();
        return (int)rnd.Next(1, document.maxSumm/3);
    }

}