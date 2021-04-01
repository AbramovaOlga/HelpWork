using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LinkSend : MonoBehaviour
{
    public Button Button;
    public string url;

    void Start()
    {
        Button button = Button.GetComponent<Button>();
        button.onClick.AddListener(openUrl);
    }

    void openUrl()
    {
        
        Application.OpenURL(url);
    }
}
