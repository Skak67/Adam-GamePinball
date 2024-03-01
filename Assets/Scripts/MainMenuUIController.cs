using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MainMenuUIController : MonoBehaviour
{
  public Button playButton;
  public Button exitButton;
  public Button creditButton;

  


  private void Start(){
    playButton.onClick.AddListener(PlayGame);
    exitButton.onClick.AddListener(ExitGame);
    creditButton.onClick.AddListener(CreditGame);
    
  }
  public void PlayGame(){
    SceneManager.LoadScene("PinballGame");

  }
  public void CreditGame(){
    SceneManager.LoadScene("Credit");

  }

  private void ExitGame(){
    Application.Quit();

  }
 
}
