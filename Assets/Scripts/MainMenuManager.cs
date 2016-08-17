using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour {

    private string[] menuItems = {"Start", "About"};
    private int selectedIndex;
    GameObject[] buttons;
    Button[] buttonArray;
    Canvas menuCanvas;

    void Start()
    {
        selectedIndex = 0;
        menuCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        buttonArray = menuCanvas.GetComponentsInChildren<Button>();
        buttonArray[selectedIndex].Select();
    }

    public void About()
    {
        //TODO
    }

    void Update()
    {
        if(Input.GetKey("enter") || Input.GetKey("return"))
        {
            buttonArray[selectedIndex].onClick.Invoke();
        }

        if (Input.GetKeyDown("down"))
        {
            selectedIndex = menuSelection(menuItems, selectedIndex, "down");
            buttonArray[selectedIndex].Select();
        }

        else if (Input.GetKeyDown("up"))
        {
            selectedIndex = menuSelection(menuItems, selectedIndex, "up");
            buttonArray[selectedIndex].Select();
        }
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

    public void NewGame()
    {
        ExtendedSceneManager.LoadScene(SceneName.LEVEL_01);
    }
}
