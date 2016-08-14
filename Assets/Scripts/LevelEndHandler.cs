using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndHandler : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneName.Game_Over_Success.ToString());
        }
    }

}
