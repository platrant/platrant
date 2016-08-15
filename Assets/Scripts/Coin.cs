using UnityEngine;

public class Coin : MonoBehaviour {

    [SerializeField]
    private int coinValue;
    [SerializeField]
    private ScoreHandler scoreHandler;
    
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag(TagName.Player))
        {
            scoreHandler.UpdateScore(coinValue);
            Destroy(gameObject);
        }
    }
}
