using System;
using System.Collections.Generic;

public class Document
{

    public int maxSumm = 100; 

    public List<string> getArray()
    {
        List<string> arr = new List<string>();
        Row row = new Row();
        arr.Add(row.Code);
        arr.Add(row.Sum.ToString());
        return arr;
    }

    public string number="abc123";

    public string date()
    {
        DateTime corenntDate = DateTime.Now;
        int dayOfWeek =(int)corenntDate.DayOfWeek;
        DateTime dt = new DateTime(corenntDate.Year, corenntDate.Month, corenntDate.Day-dayOfWeek+1);
        return dt.ToString("dd/MM/yyyy");
    }
   
}