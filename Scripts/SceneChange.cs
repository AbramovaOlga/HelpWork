using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public Button Button;
    public string sceneName;

    void Start()
    {
        Button button = Button.GetComponent<Button>();
        button.onClick.AddListener(Change);
    }

    void Change()
    {
        SceneManager.LoadScene(sceneName);
    }
}
