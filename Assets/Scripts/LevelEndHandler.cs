using UnityEngine;

public class LevelEndHandler : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag(TagName.Player))
        {
            ExtendedSceneManager.LoadScene(SceneName.Game_Over_Success);
        }
    }

}
