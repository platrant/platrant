using UnityEngine;

public class CoinHandler : MonoBehaviour {

    [SerializeField]
    private int coinValue;
    
    private void OnCollisionEnter2D(Collision2D coll)
    {
        GameObject gameObjHit = coll.gameObject;

        if (gameObjHit.CompareTag("Player"))
        {
            gameObjHit.SendMessage("UpdateScore", coinValue);
            Destroy(gameObject);
        }
    }
}
