using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteFriend : MonoBehaviour
{
	private void Start()
	{
		GetComponent<Button>().onClick.AddListener(del);
	}
	public void del()
	{
		Destroy(transform.parent.gameObject);
	}
}
