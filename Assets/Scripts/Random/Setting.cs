using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
	[SerializeField]
	private GameObject settingBox;
    public void openSetting()
	{
		settingBox.SetActive(true);
	}

	public void closeSetting()
	{
		settingBox.SetActive(false);
	}
}
