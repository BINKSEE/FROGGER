using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreBoardMenu : MonoBehaviour
{
      public void ReturnMain ()
  {
    SceneManager.LoadScene(0);
  }

  public void QuitGame ()
  {
    Debug.Log("QUIT");
    Application.Quit();
  }
}
