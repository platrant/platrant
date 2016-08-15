using UnityEngine;
using UnityEngine.SceneManagement;

public static class Extensions
{
    public static void LoadNextScene(this Scene scene)
    {
        SceneManager.LoadScene(scene.buildIndex + 1);
    }

    public static bool CompareTag(this GameObject gameObject, TagName tag)
    {
        return gameObject.CompareTag(tag.ToString());
    }
}