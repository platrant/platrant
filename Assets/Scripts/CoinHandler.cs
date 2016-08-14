using UnityEngine;

public class CoinHandler : MonoBehaviour {
    
    private void OnCollisionEnter2D(Collision2D coll)
    {
        GameObject gameObjHit = coll.gameObject;

        if (gameObjHit.CompareTag("Player"))
        {
            gameObjHit.SendMessage("UpdateScore");
            Destroy(gameObject);
        }
    }
}
