using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckInputFields3Task : MonoBehaviour
{
	public GameObject ErrorWindow;
	public GameObject NextWindow;
	public TMP_Text TMPmessage;

	public TMP_InputField InputChest1;
	public TMP_InputField InputChest2;
	public TMP_InputField InputChest3;
	public TMP_InputField InputBrak;

	public void SolveTask()
	{
		var solve1 = Helpers.ParseToDouble(InputChest1.text);
		var solve2 = Helpers.ParseToDouble(InputChest2.text);
		var solve3 = Helpers.ParseToDouble(InputChest3.text);
		var solveBrak = Helpers.ParseToDouble(InputBrak.text);

		string message = "Ошибка в: ";

		if (solve1 != 0.34)
		{
			InputChest1.text = "Неверно";
			message += "Р1 ";
		}
		else
		{
			InputChest1.text = "Правильно!";
			Score.ScoreCount += 75;
		}

		if (solve2 != 0.4)
		{
			InputChest2.text = "Неверно";
			message += "Р2 ";
		}
		else
		{
			InputChest2.text = "Правильно!";
			Score.ScoreCount += 75;
		}

		if (solve3 != 0.26)
		{
			InputChest3.text = "Неверно";
			message += "Р3 ";
		}
		else
		{
			InputChest3.text = "Правильно!";
			Score.ScoreCount += 75;
		}
		if (solveBrak != 0.035)
		{
			InputBrak.text = "Неверно";
			message += "Brak ";
		}
		else
		{
			InputBrak.text = "Хорошая работа";
			Score.ScoreCount += 125;
		}



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
