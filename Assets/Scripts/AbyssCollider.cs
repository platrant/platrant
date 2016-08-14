using UnityEngine;
using System.Collections;

public class AbyssCollider : MonoBehaviour {

    private const string PLAYER_TAG = "Player";
    
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == PLAYER_TAG)
            coll.gameObject.SendMessage("LoseLife");
    }
}
