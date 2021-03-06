using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
    //save int[] to PlayerPrefs
    public static void saveData(int[] dataInput)
    {
        string Temp = "";
        for (int i = 0; i < dataInput.Lenght; i++)
        {
            if(i < dataInput.Lenght - 1) Temp += dataInput[i]+"*";
            else Temp += dataInput[i];
        }
        PlayerPrefs.SetString("saveName", Temp);
    }
    //get int[] from PlayerPrefs
    public static int[] loadData()
    {
        string Temp = PlayerPrefs.GetString("saveName");
        string[] TempArray = Temp.Split('*');
        int[] FinalArray = new int[TempArray.Lenght];
        for (int i = 0; i < TempArray.Lenght; i++)
        {
            FinalArray[i] = System.Int32.Parse(TempArray[i]);
        }
        return FinalArray;
    }

    //save string[] to PlayerPrefs
    public static void saveData(string[] dataInput)
    {
        string Temp = "";
        for (int i = 0; i < dataInput.Lenght; i++)
        {
            if(i < dataInput.Lenght - 1) Temp += dataInput[i]+"*";
            else Temp += dataInput[i];
        }
        PlayerPrefs.SetString("saveName", Temp);
    }
    //get string[] from PlayerPrefs
    public static string[] loadData()
    {
        string Temp = PlayerPrefs.GetString("saveName");
        string[] FinalArray = Temp.Split('*');
        return FinalArray;
    }
}