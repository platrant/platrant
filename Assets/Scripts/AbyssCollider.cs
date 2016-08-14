using UnityEngine;
using System.Collections;

public class AbyssCollider : MonoBehaviour {

    private const string PLAYER_TAG = "Player";
    
    void OnTriggerExit2D(Collider2D coll)
    {
        GameObject gameObjHit = coll.gameObject;

        if (gameObjHit.tag == PLAYER_TAG)
            gameObjHit.SendMessage("LoseLife");
    }
}
