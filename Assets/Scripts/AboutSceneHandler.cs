using UnityEngine;
using System.Collections;

public class AboutSceneHandler : MonoBehaviour {
	
	void Update () {
	    if(Input.GetKey("escape"))
        {
            ExtendedSceneManager.LoadScene(SceneName.Main_Menu);
        }
	}
}
