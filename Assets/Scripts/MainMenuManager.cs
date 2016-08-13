using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

    private string[] menuItems = {"Start", "Exit"};
    private int menuPos;
	void Start()
    {
        menuPos = 0;
    }
	void Update () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void OnGUI()
    {
        GUIText platRant = new GUIText();
        GUI.Label(new Rect(0, 15, 100, 40), "platRant");
        for(int k = 0; k < menuItems.Length; k++)
        {
            if (GUI.Button(new Rect(0,(200 + (k * 32)), 128, 32), menuItems[k]))
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
