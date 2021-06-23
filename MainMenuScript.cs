using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
  public static int howManyPlayers;

  void Start()
  {

  }

  void Update()
  {

  }

  public void two_player()
  {
    SoundManagerScript.buttonAudioSource.Play();
    howManyPlayers = 2;
    SceneManager.LoadScene("Pagade");
  }



  public void four_player()
  {
    SoundManagerScript.buttonAudioSource.Play();
    howManyPlayers = 4;
    SceneManager.LoadScene("Pagade");
  }

  public void artificial()
  {
    SoundManagerScript.buttonAudioSource.Play();
    SceneManager.LoadScene("game");
  }

  public void quit()
  {
    SoundManagerScript.buttonAudioSource.Play();
    Application.Quit();
  }
}
