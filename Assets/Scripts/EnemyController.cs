using UnityEngine;

public class EnemyController : MonoBehaviour {

    [SerializeField]
    private int movementVelocity = 1;

    [SerializeField]
    private PlayerHealthHandler playerHealthHandler;

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(movementVelocity, 0);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag(TagName.EnemyWayPoint))
        {
            movementVelocity= -movementVelocity;
            gameObject.transform.Rotate(0, 180, 0);
        }
        else if (coll.gameObject.CompareTag(TagName.Player))
        {
            playerHealthHandler.LoseLife();
        }
    }
}
