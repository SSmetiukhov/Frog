
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public GameObject pauseButton;
    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    
    public void Resume()
    {
        pauseButton.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        ScoreDisplay.RemoveScore();
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void Home()
    {
        ScoreDisplay.RemoveScore();
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene(0);
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }
    
}
