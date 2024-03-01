using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button mainMenuButton;
    void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
        
    }

    // Update is called once per frame
    public void MainMenu(){
    SceneManager.LoadScene("MainMenu");

    }
}
