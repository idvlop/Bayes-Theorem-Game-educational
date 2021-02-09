using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TaskAgainScript : MonoBehaviour
{
    public GameObject ErrorWindow;

    public TMP_InputField InputChest1;
    public TMP_InputField InputChest2;
    public TMP_InputField InputChest3;

    public void DoAgain()
	{
        if (InputChest1.text == "Правильно!")
            Score.ScoreCount -= 25;
        InputChest1.text = string.Empty;

        if (InputChest2.text == "Правильно!")
            Score.ScoreCount -= 25;
        InputChest2.text = string.Empty;

        if (InputChest3.text == "Правильно!")
            Score.ScoreCount -= 25;
        InputChest3.text = string.Empty;

        ErrorWindow.SetActive(false);
    } 
}
