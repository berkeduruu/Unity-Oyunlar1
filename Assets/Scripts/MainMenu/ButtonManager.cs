using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject SettingMenu;


    public void PlayGames()
    {
        SceneManager.LoadScene("GameSelectMenu");
    }

    public void StoreMenu()
    {
        SceneManager.LoadScene("StoreMenu");
    }

    public void SettingsMenu()
    {
        SettingMenu.SetActive(true);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
