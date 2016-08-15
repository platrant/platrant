using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour {
    
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
