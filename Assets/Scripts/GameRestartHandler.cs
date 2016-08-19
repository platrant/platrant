using UnityEngine;
using System.Collections;

public class GameRestartHandler : MonoBehaviour
{

    private float timeBeforeRestart = 0;
    void Start()
    {
        timeBeforeRestart = 5;
    }

    void Update()
    {
        if (timeBeforeRestart > 0)
        {
            timeBeforeRestart -= Time.deltaTime;
        }
        else
        {
            ExtendedSceneManager.LoadScene(SceneName.Main_Menu);
        }
    }
}
