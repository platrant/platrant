using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    private const string GAME_OVER_SCENE = "Game_Over";

    [SerializeField]
    private bool shouldAutoload;
    [SerializeField]
    private float autoloadNextLevelAfter;

    void Start()
    {
        if(shouldAutoload)
        {
            Invoke("LoadNextLevel", autoloadNextLevelAfter);
        }
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RequestQuit()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneName.GAME_OVER.ToString());
    }
}
