using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject SettingMenu;


    public void PlayGames()
    {
        SceneManager.LoadScene(1);// 1 is index of select games scene
    }

    public void StoreMenu()
    {
        SceneManager.LoadScene(2);// 2 is index of scane store
    }

    public void SettingsMenu(bool select)
    {
        if (select)
        {
            SettingMenu.SetActive(true);//for open setting button
        }
        else
        {
            SettingMenu.SetActive(false);//for close settings button
        }
    }


    public void QuitApp()
    {
        Application.Quit();
    }
}
