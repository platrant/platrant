using UnityEngine;
using System.Collections;

public class AbyssCollider : MonoBehaviour {

    private const string LIVES_GAME_OBJ_NAME = "Remaining Lives";
    private const string PLAYER_TAG = "Player";

    [SerializeField]
    private PlayerHealthManager playerHealthManager;
    [SerializeField]
    private LevelManager levelManager;
    [SerializeField]
    private PlayerMovement player;

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == PLAYER_TAG)
            KillPlayer();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == PLAYER_TAG)
            player.RotatePlayer();
    }

    private void KillPlayer()
    {
        playerHealthManager.LoseLife();
        if(playerHealthManager.IsAlive()){
            player.ResetPosition();
            UpdateLivesComponent();
        }
    }

    private void UpdateLivesComponent()
    {
        int remainingLives = playerHealthManager.RemainingLives;
        char fontAwesomeHealthSymbol = ''; //A heart symbol in the font-awesome font family
        UpdateRemainingLivesText(new string(fontAwesomeHealthSymbol, remainingLives));
    }

    private void UpdateRemainingLivesText(string newText)
    {
        GameObject.Find(LIVES_GAME_OBJ_NAME).GetComponent<UnityEngine.UI.Text>().text = newText;
    }

    void Start () {
        UpdateLivesComponent();
    }
}
