using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TriggerGameOver : MonoBehaviour
{
    
    public Collider bola;
    public GameObject GameOverCanvas;
  

  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
        // sprite3.gameObject.SetActive(true);
        GameOverCanvas.SetActive(true);
    }
  }
}
