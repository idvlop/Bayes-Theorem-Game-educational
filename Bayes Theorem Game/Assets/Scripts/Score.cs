using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int ScoreCount { get; set; }
    public TMP_Text ScoreText;

    void Update()
    {
        //Debug.Log("ScoreCount = " + ScoreCount);
        //Debug.Log("ScoreText.text = " + ScoreText.text);
        ScoreText.text = "Счет: " + ScoreCount;
    }

}