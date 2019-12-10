using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSpeed : MonoBehaviour
{
    public Dropdown SpeedMenu;
    public static string SaveData;
    public Text SpeedText;

    public void Choice()
    {
        if (SpeedMenu.value == 1)
            SaveData = "1";
        else if (SpeedMenu.value == 2)
            SaveData = "2";
        else if (SpeedMenu.value == 3)
            SaveData = "3";
        else SaveData = "Default";

    }
    private void Start()
    {
        SpeedText.text = SaveData;
    }


}
