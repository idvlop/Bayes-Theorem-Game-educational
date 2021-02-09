using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Task3Again : MonoBehaviour
{
    public GameObject ErrorWindow;

    public TMP_InputField InputChest1;
    public TMP_InputField InputChest2;
    public TMP_InputField InputChest3;
    public TMP_InputField InputBrak;

    public void DoAgain()
    {
        if (InputChest1.text == "Правильно!")
            Score.ScoreCount -= 75;
        InputChest1.text = string.Empty;

        if (InputChest2.text == "Правильно!")
            Score.ScoreCount -= 75;
        InputChest2.text = string.Empty;

        if (InputChest3.text == "Правильно!")
            Score.ScoreCount -= 75;
        InputChest3.text = string.Empty;

        if (InputBrak.text == "Хорошая работа")
            Score.ScoreCount -= 125;
        InputBrak.text = string.Empty;

        ErrorWindow.SetActive(false);
    }
}
