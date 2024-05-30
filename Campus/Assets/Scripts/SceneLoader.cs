using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string targetSceneName;

    public void LoadSceneOnClick()
    {
       
        SceneManager.LoadScene(targetSceneName);
    }
    public void QuitScene()
    {
        Application.Quit();
    }
}
