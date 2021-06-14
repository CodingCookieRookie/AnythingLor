using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    private Slider slider;
	private const float maxCost = 500;
	private static float biddedCost;
	[SerializeField]
	private InputField costInputField;
	[SerializeField]
	private Text percent;
	private void Start()
	{
		slider = GetComponent<Slider>();
		costInputField.text = biddedCost.ToString();
		slider.value = biddedCost / maxCost;
		slider.onValueChanged.AddListener(delegate { changeSliderValue(); });
	}
	// Update is called once per frame
	void Update()
    {
		
		if (float.Parse(costInputField.text) > maxCost)
		{
			costInputField.text = maxCost.ToString();
		}
		biddedCost = float.Parse(costInputField.text);
		percent.text = (float.Parse(costInputField.text) / 25 ).ToString("0.00") + "%";

	}

	private void changeSliderValue()
	{
		costInputField.text = ((slider.value / 1) * maxCost).ToString("0.00");

	}

}
