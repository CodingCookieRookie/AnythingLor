using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour
{
	[SerializeField]
	private GameObject loginUI;
   public void login()
	{
		loginUI.SetActive(true);
	}
}
