using UnityEngine;
using System.Collections;

public class AbyssCollider : MonoBehaviour {

    private const string PLAYER_TAG = "Player";

    [SerializeField]
    private LevelManager levelManager;
    [SerializeField]
    private PlayerMovement player;

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == PLAYER_TAG)
            coll.gameObject.SendMessage("LoseLife");
    }

    void Start () {
        
    }
}
