using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathprofiLink : MonoBehaviour
{
    public void OnMouseClick()
    {
        Application.ExternalEval("window.open(\"" + "http://www.mathprofi.ru/formula_polnoj_verojatnosti_formuly_bajesa.html" + "\", \"_blank\", \"toolbar=0,location=0,menubar=0\" )");
    }
}
