using UnityEngine;
using System.Collections;

public class AbyssCollider : MonoBehaviour {

    public const string PLAYER_TAG = "Player";
    
    [SerializeField]
    private PlayerHealthManager healthManager;

    [SerializeField]
    private LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == PLAYER_TAG)
        {
            healthManager.LoseLife();
            Destroy(coll.gameObject);
            UpdateLivesComponent(healthManager.GetRemainingLives());
        }
    }

    private void UpdateLivesComponent(int remainingLives)
    {
        char fontAwesomeHealthSymbol = '-';//'\uf004;';
        UpdateRemainingLivesText(new string(fontAwesomeHealthSymbol, remainingLives));
    }

    private void UpdateRemainingLivesText(string newText)
    {
        GameObject.Find("Remaining Lives").GetComponent<UnityEngine.UI.Text>().text = newText;
    }

	void Start () { }
	void Update () { }
}
