using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
         pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    public void Mainmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level");
    }
}
