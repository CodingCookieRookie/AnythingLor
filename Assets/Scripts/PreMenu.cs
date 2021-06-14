using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PreMenu : MonoBehaviour
{
    private const float maxTimer = 1.5f;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        /*timer += Time.deltaTime;
        if (timer >= maxTimer) UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");*/
        GetComponent<Image>().color += new Color(0, 0, 0, Time.deltaTime * 0.5f);
        if (GetComponent<Image>().color.a >= 1f) UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
