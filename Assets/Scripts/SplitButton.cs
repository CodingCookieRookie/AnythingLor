using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplitButton : MonoBehaviour
{
    private bool autoSplit;
    [SerializeField]
    private GameObject autoSplitTick;
    [SerializeField]
    private GameObject[] friendSplitButtons;
    // Update is called once per frame
    void Update()
    {
        autoSplit = autoSplitTick.activeInHierarchy;
        if (autoSplit)
        {
            foreach (GameObject x in friendSplitButtons)
            {
                x.gameObject.SetActive(true);
                x.transform.parent.GetComponent<Button>().interactable = false;
            }
        }
        else
		{
            foreach (GameObject x in friendSplitButtons)
            {
                x.transform.parent.GetComponent<Button>().interactable = true;
            }
        }
    }
}
