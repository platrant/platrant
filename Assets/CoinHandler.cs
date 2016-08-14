using UnityEngine;
using System.Collections;

public class CoinHandler : MonoBehaviour {



    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            //score++;
            Destroy(gameObject);
            GameObject.Find("Score").GetComponent<UnityEngine.UI.Text>().text = "Score: ";// + score;
        }
    }
}
