using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public Button MainMenuButton;
    public Button UlangButton;
    private void Start(){
	
    MainMenuButton.onClick.AddListener(MainMenu);
    UlangButton.onClick.AddListener(Ulang);
    }
    
    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void Ulang(){
        SceneManager.LoadScene("PinballGame");
    }
}
