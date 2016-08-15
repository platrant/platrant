using UnityEngine.SceneManagement;

public static class ExtendedSceneManager
{
    public static void LoadScene(SceneName sceneName)
    {
        SceneManager.LoadScene(sceneName.ToString());
    }

    public static void LoadNextScene()
    {
        SceneManager.GetActiveScene().LoadNextScene();
    }
}