using UnityEngine;
using System.Collections;

public class AbyssCollider : MonoBehaviour {

    private const string LIVES_GAME_OBJ_NAME = "Remaining Lives";
    [SerializeField]
    private PlayerHealthManager playerHealthManager;
    [SerializeField]
    private LevelManager levelManager;
    [SerializeField]
    private PlayerMovement player;

    void OnTriggerExit2D(Collider2D coll)
    {
        GameObject gObj = coll.gameObject;
        if (gObj == player.gameObject)
        {
            playerHealthManager.LoseLife();
            if(playerHealthManager.IsAlive()){
                player.Reset();
                UpdateLivesComponent(playerHealthManager.RemainingLives);
            }
        }
    }

    private void UpdateLivesComponent(int remainingLives)
    {
        char fontAwesomeHealthSymbol = '';
        UpdateRemainingLivesText(new string(fontAwesomeHealthSymbol, remainingLives));
    }

    private void UpdateRemainingLivesText(string newText)
    {
        GameObject.Find(LIVES_GAME_OBJ_NAME).GetComponent<UnityEngine.UI.Text>().text = newText;
    }

	void Start () {}
	void Update () {}
}
