using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

    private string[] menuItems = {"Start", "Exit"};

    public void Exit()
    {
        Application.Quit();
    }

    void OnGUI()
    {
        for(int k = 0; k < menuItems.Length; k++)
        {
            if (GUI.Button(new Rect(15,(200 + (k * 32)), 128, 32), menuItems[k]))
            {
                if(k.Equals(0))
                {
                    SceneManager.LoadScene("Level_01");
                }
                else if(k.Equals(1))
                {
                    Exit();
                }
            }
        }
    }
}
