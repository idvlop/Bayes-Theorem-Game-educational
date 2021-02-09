using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Helpers
{
	public static double ParseToDouble(string value)
	{
		double result = double.NaN;
		value = value.Trim();
		if (!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), out result))
		{
			if (!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out result))
			{
				return double.NaN;
			}
		}
		return result;
	}
}

