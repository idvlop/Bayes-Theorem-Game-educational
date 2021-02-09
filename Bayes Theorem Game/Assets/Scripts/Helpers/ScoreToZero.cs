using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreToZero : MonoBehaviour
{

    void Start()
    {
        var name = SceneManager.GetActiveScene().name;
        if (name == "Level1")
            Score.ScoreCount = 0;
    }

}
