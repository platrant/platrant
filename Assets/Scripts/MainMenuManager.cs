using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

    private string[] menuItems = {"Start", "Exit"};
    private int selectedIndex;

    void Start()
    {
        selectedIndex = 0;
    }

    public void Exit()
    {
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetButton("up"))
        {
            selectedIndex = menuSelection(menuItems, selectedIndex, "down");
        }

        if (Input.GetButton("up"))
        {
            selectedIndex = menuSelection(menuItems, selectedIndex, "up");
        }
    }

    void OnGUI()
    {
        for(int k = 0; k < menuItems.Length; k++)
        {
            if (GUI.Button(new Rect(30,(200 + (k * 32)), 128, 32), menuItems[k]))
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
        GUI.FocusControl(menuItems[selectedIndex]);
    }

    private int menuSelection(string[] menuItems, int selectedItem, string direction)
    {
        if (direction == "up")
        {
            if (selectedItem == 0)
            {
                selectedItem = menuItems.Length - 1;
            }
            else
            {
                selectedItem -= 1;
            }
        }

        if (direction == "down")
        {
            if (selectedItem == menuItems.Length - 1)
            {
                selectedItem = 0;
            }
            else
            {
                selectedItem += 1;
            }
        }

        return selectedItem;
    }
}
