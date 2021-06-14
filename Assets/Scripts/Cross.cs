using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour
{
   public void cancel()
	{
		transform.parent.gameObject.SetActive(false);	
	}
}
