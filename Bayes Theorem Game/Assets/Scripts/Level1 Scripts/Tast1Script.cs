﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//public static class Helpers
//{
//	public static double ParseToDouble(string value)
//	{
//		double result = double.NaN;
//		value = value.Trim();
//		if (!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), out result))
//		{
//			if (!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out result))
//			{
//				return double.NaN;
//			}
//		}
//		return result;
//	}
//}

public class Tast1Script : MonoBehaviour
{
	public GameObject ErrorWindow;
	public GameObject NextWindow;
	public TMP_Text TMPmessage;
	//public TMP_Text Score;

    public TMP_InputField InputChest1;
	public TMP_InputField InputChest2;
	public TMP_InputField InputChest3;

	public void Reset()
	{
		InputChest1.text = string.Empty;
		InputChest2.text = string.Empty;
		InputChest3.text = string.Empty;
	}

	public void SolveTask()
	{
		var solve1 = Helpers.ParseToDouble(InputChest1.text);
		var solve2 = Helpers.ParseToDouble(InputChest2.text);
		var solve3 = Helpers.ParseToDouble(InputChest3.text);
		string message = "Ошибка в: ";

		if (solve1 != 0.35)
		{
			InputChest1.text = "Неверно";
			message += "Р1 ";
		}
		else
		{
			InputChest1.text = "Правильно!";
			Score.ScoreCount += 25;
		}

		if (solve2 != 0.19)
		{
			InputChest2.text = "Неверно";
			message += "Р2 ";
		}
		else
		{
			InputChest2.text = "Правильно!";
			Score.ScoreCount += 25;
		}

		if (solve3 != 0.47)
		{
			InputChest3.text = "Неверно";
			message += "Р3";
		}
		else
		{
			InputChest3.text = "Правильно!";
			Score.ScoreCount += 25;
		}

		Debug.Log(message);


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
