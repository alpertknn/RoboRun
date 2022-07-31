public bool isPaused = false;
public AudioSource audio;

[SerializeField] GameObject pauseMenu;

public void PauseGame()
{
    pauseMenu.SetActive(true);
    Time.timeScale=0f;
    isPaused=true;
    audio.Pause();
}

public void ResumeGame()
{
    pauseMenu.SetActive(false);
    Time.timeScale=1f;
    isPaused=false;
    audio.Play();
}

public void LoadMenu()
{
    Time.timeScale= 1f;
    SceneManager.LoadScene("GameMenu");
}
public void QuitGame()
{
    Application.Quit();
    Debug.Log("Quit!")
}