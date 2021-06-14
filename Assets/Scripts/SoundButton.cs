using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
	[SerializeField]
	private UnityEngine.Sprite[] sprites;
	[SerializeField]
	private UnityEngine.UI.Image soundImage;
	private void Start()
	{
		GetComponent<UnityEngine.UI.Button>().onClick.AddListener(delegate{ toggleSound(); });
	}
	public void toggleSound()
	{
		Music.mute = !Music.mute;
	}

	private void Update()
	{
		if (Music.mute)
		{
			soundImage.sprite = sprites[1];
		}
		else
		{
			soundImage.sprite = sprites[0];
		}
	}
}
