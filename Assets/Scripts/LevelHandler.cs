using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour {

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
        SceneManager.GetActiveScene().LoadNextScene();
    }

    public void GameOver()
    {
        ExtendedSceneManager.LoadScene(SceneName.GAME_OVER);
    }
}
