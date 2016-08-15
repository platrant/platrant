using UnityEngine;
using System.Collections;

public class Abyss : MonoBehaviour {
    
    [SerializeField]
    private PlayerHealthHandler playerHealthHandler;
    

    void OnTriggerEnter2D(Collider2D coll)
    {
        coll.gameObject.SendMessage("Rotate");
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag(TagName.Player))
           playerHealthHandler.LoseLife();
    }
}
