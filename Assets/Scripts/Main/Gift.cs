using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    [SerializeField]
    private GameObject giftObject;
    [SerializeField]
    private UnityEngine.UI.Text pointsText; 
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(delegate { openGift(); });
    }
     void Update()
	{
        pointsText.text = "Points I have: " + Profile.points;
    }
	public void openGift()
    {
        giftObject.SetActive(true);
    }
}
