using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuUI;

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Oyun zamanýný normale döndür
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Oyun zamanýný durdur
    }

    public void Restart()
    {//aa
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Resume();
    } 
    public void QuitGame()//þimdilik ana menü olmadýðýndan oyunu kapatýyor
    {
        Application.Quit(); // Oyunu kapat
    }
}
