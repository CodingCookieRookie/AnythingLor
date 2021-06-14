using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Claim : MonoBehaviour
{
	[SerializeField]
	private GameObject RateBox;
	[SerializeField]
	private UnityEngine.UI.Button ClaimButton;
	public static bool claimed;

	private void Update()
	{
		if (claimed)
		{
			ClaimButton.interactable = false;
		}
	}
	public void claim()
	{
		claimed = true;
		RateBox.SetActive(true);
		ClaimButton.interactable = false;
		transform.parent.gameObject.SetActive(false);
	}
}
