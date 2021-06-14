using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTick : MonoBehaviour
{
   public void toggleTick()
	{
		Transform child = gameObject.transform.GetChild(1);
		child.gameObject.SetActive(!child.gameObject.activeSelf);
	}
}
