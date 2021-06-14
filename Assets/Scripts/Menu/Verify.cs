using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Verify : MonoBehaviour
{
    [SerializeField]
    private InputField usernameInputField;
    [SerializeField]
    private InputField passwordInputField;
    [SerializeField]
    private Text error;
    [SerializeField]
    private string sceneNameToLoad;
    private const string defaultUser = "admin";
    public void enter()
	{
        if (usernameInputField.text.Equals(defaultUser) && passwordInputField.text.Equals(defaultUser))
		{
            SceneManager.LoadScene(sceneNameToLoad);
		} else
		{
            error.text = "Wrong username or password!";
		}
	}
}
