using UnityEngine;
using System.Collections;

public class GameRestartHandler : MonoBehaviour
{

    private float time = 0;
    void Start()
    {
        time = 5;
    }

    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            ExtendedSceneManager.LoadScene(SceneName.Main_Menu);
        }
    }
}
