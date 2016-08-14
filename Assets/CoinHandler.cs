using UnityEngine;

public class CoinHandler : MonoBehaviour {
    
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            coll.gameObject.SendMessage("UpdateScore");
            Destroy(gameObject);
        }
    }
}
