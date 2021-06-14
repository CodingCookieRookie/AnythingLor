using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadScene : MonoBehaviour {
    
    [SerializeField]
    private string sceneName;

    public void load()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void exit()
    {
        Application.Quit();
    }

}
