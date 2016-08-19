using UnityEngine;
using System.Collections;

public class AboutSceneHandler : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKey)
        {
            ExtendedSceneManager.LoadScene(SceneName.Main_Menu);
        }
    }
}
