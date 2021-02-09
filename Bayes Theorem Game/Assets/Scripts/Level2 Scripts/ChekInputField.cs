using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChekInputField : MonoBehaviour
{
	public GameObject ErrorWindow;
	public GameObject NextWindow;
	public TMP_Text TMPmessage;

	public TMP_InputField InputChest1;
	public TMP_InputField InputChest2;

	public void SolveTask()
	{
		var solve1 = Helpers.ParseToDouble(InputChest1.text);
		var solve2 = Helpers.ParseToDouble(InputChest2.text);
		string message = "Ошибка в: ";

		if (solve1 != 0.37)
		{
			InputChest1.text = "Неверно";
			message += "Р1 ";
		}
		else
		{
			InputChest1.text = "Правильно!";
			Score.ScoreCount += 50;
		}

		if (solve2 != 0.63)
		{
			InputChest2.text = "Неверно";
			message += "Р2 ";
		}
		else
		{
			InputChest2.text = "Правильно!";
			Score.ScoreCount += 50;
		}

		//Debug.Log(message);


		if (message != "Ошибка в: ")
		{
			ErrorWindow.SetActive(true);
			TMPmessage.text = message;
		}
		else
		{
			NextWindow.SetActive(true);
		}

	}
}
