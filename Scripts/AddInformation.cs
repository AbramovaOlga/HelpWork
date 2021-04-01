using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AddInformation : MonoBehaviour
{ 
    public Image shadow;
    public Image image;
    public Button Button;

    public Button Return;
    public Vector3 startPos;

    void Start()
    {
        startPos = this.transform.position;

        Button button = Button.GetComponent<Button>();
        button.onClick.AddListener(AddInform);

        Button button1 = Return.GetComponent<Button>();
        button1.onClick.AddListener(ReturnVoid);
    }

    void AddInform()
    {
        shadow.transform.position = new Vector3(94f, 167.25f, 0f);
        image.transform.position = new Vector3(94f, 167.25f, 0F);
    }

    void ReturnVoid()
    {
         shadow.transform.position = startPos;
         image.transform.position = startPos;
    }
}
