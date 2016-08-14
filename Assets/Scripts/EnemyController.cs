using UnityEngine;

public class EnemyController : MonoBehaviour {

    private int moveDirection = 1;

    [SerializeField]
    private PlayerHealthHandler playerHealthHandler;

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveDirection, 0);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.CompareTag("EnemyWayPoint"))
        {
            moveDirection = -moveDirection;
            gameObject.transform.Rotate(0, 180, 0);
        }
        else if (coll.gameObject.CompareTag("Player"))
        {
            playerHealthHandler.LoseLife();
        }
    }
}
