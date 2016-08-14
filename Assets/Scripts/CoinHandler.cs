using UnityEngine;

public class CoinHandler : MonoBehaviour {

    [SerializeField]
    private int coinValue;
    [SerializeField]
    private ScoreManager scoreHandler;
    
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            scoreHandler.UpdateScore(coinValue);
            Destroy(gameObject);
        }
    }
}
