using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKeyPopupWindow : MonoBehaviour
{
    public GameObject Panel;
    
    public void OpenKeyPopUpWindow()
	{
        if(Panel != null)
		{
			bool isActive = Panel.activeSelf;

			Panel.SetActive(!isActive);
		}

	}
}
