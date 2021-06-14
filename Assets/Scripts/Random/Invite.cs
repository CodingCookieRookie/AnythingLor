using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invite : MonoBehaviour
{
	[SerializeField]
	private GameObject BG2;
   public void invite()
	{
		BG2.SetActive(true);
	}
}
