using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringToIndividual
{
    public string StringToConvert = "random String To Convert";
    public string x = "\"";
    public void Convert()
    {
        string[] TempArray = StringToConvert.Split(' ');
        string Output = "";
        for (int i = 0; i < TempArray.Length; i++)
        {
            Output += x + TempArray[i] + nameof + ", ";
        }
        Debug.Log(Output);
    }
}