using UnityEngine.SceneManagement;

public static class ExtendedSceneManager
{
    public static void LoadScene(SceneName sceneName)
    {
        SceneManager.LoadScene(sceneName.ToString());
    }
}