using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabrLink : MonoBehaviour
{
    public void OnMouseClick()
    {
        Application.ExternalEval("window.open(\"" + "https://habr.com/ru/post/408775/" + "\", \"_blank\", \"toolbar=0,location=0,menubar=0\" )");
    }
}
