using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WikiLink : MonoBehaviour
{
    public void OnMouseClick()
    {
        Application.ExternalEval("window.open(\"" + "https://ru.wikipedia.org/wiki/%D0%A2%D0%B5%D0%BE%D1%80%D0%B5%D0%BC%D0%B0_%D0%91%D0%B0%D0%B9%D0%B5%D1%81%D0%B0" + "\", \"_blank\", \"toolbar=0,location=0,menubar=0\" )");
    }
}
