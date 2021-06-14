using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomise : MonoBehaviour
{
	[SerializeField]
	private Sprite[] backgrounds;
	[SerializeField]
	private Image image;
	[SerializeField]
	private Button anything;
	[SerializeField]
	private Text splitCostText;
	[SerializeField]
	private Image claimImage;
	[SerializeField]
	private Button claimButton;
	[SerializeField]
	private Image rateImage;
	private static int count;
	private int[] allCosts = new int[] { 30, 29, 28 };
	public int cost;
	public static Randomise randomiseInstance;
	[SerializeField]
	private GameObject[] splitTicks;

	private static Sprite savedImage;
	private static float savedCost;
	private static int savedIndex = -1;

	private void Start()
	{
		if (count >= 3) anything.interactable = false;
		if (savedIndex != -1)
		{
			image.sprite = savedImage;
			rateImage.sprite = savedImage;
			claimImage.sprite = savedImage;
			claimButton.interactable = !Claim.claimed;
			splitCostText.text = "Split cost: " + returnCost();
		}
	}
	public void randomise()
	{
		randomiseInstance = this;
		if (count >= 2) anything.interactable = false;
		count++;
		int a = Random.Range(0, 2);
		savedIndex = a;
		savedCost = allCosts[a];
		savedImage = backgrounds[a];
		image.sprite = savedImage;
		rateImage.sprite = savedImage;
		claimImage.sprite = savedImage;
		claimButton.interactable = !Claim.claimed;
		splitCostText.text = "Split cost: " + returnCost();
	}

	public double returnCost()
	{
		int numOfSharers = 0;
		foreach (GameObject tick in splitTicks)
		{
			if (tick.activeSelf)
			{
				numOfSharers++;
			}
		}
		numOfSharers = numOfSharers == 0 ? 1 : numOfSharers;
		return savedCost / numOfSharers;
	}
}
