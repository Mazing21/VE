using UnityEngine;
using UnityEngine.SceneManagement;
public class menuLogicScript : MonoBehaviour
{
     public void OnClickPlayButton()
     {
        SceneManager.LoadScene(1);
     }
    public void OnClickQuitButton()
    {
        Application.Quit();
    }
}
