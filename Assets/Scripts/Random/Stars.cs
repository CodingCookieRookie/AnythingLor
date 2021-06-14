using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stars : MonoBehaviour
{
    [SerializeField]
    private GameObject[] stars;
    [SerializeField]
    private Text pointsText;
    private int index;

	// Start is called before the first frame update
	[System.Obsolete]
	void Start()
    {
       index = transform.GetSiblingIndex();
        GetComponent<Button>().onClick.AddListener(delegate { pressStart(); });
    }

    public void pressStart()
	{
        for(int i = 0; i <= index; i ++)
		{
            stars[i].GetComponent<Image>().color = Color.yellow;
		}
        for (int i = 0; i < 5; i++)
		{
            stars[i].GetComponent<Button>().interactable = false;
        }
        pointsText.text = string.Format("You have rated {0} stars and earned {1} points!", index + 1, (index + 1) * 5);
        Profile.points += (index + 1) * 5;
	}
}
