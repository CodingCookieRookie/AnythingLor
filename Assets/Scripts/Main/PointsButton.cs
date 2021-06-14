using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsButton : MonoBehaviour
{
    [SerializeField]
    private int cost;
    private void cancel()
    {
        transform.parent.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(buyDiscount);
    }

    public void buyDiscount()
	{
        if (Profile.points >= cost)
		{
            Profile.points -= cost;
            cancel();
		} else
		{
            cancel();
		}
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
