using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    private const string LIVES_GAME_OBJ_NAME = "Remaining Lives";

    [SerializeField]
    private int remainingLives = 3;

    [SerializeField]
    private LevelManager levelManager;

    [SerializeField]
    private PlayerMovement player;

    public void Start()
    {
        UpdateLivesComponent();
    }

    public int RemainingLives
    {
        get {return remainingLives;}
        set {remainingLives = value;}
    }

    public void LoseLife()
    {
        remainingLives--;
        if (!IsAlive())
            levelManager.GameOver();
        else
        {
            UpdateLivesComponent();
            player.SendMessage("ResetPosition");
        }
    }
    
    public void UpdateLivesComponent()
    {
        char fontAwesomeHealthSymbol = ''; //A heart symbol in the font-awesome font family
        UpdateRemainingLivesText(new string(fontAwesomeHealthSymbol, remainingLives));
    }

    private void UpdateRemainingLivesText(string newText)
    {
        GameObject.Find(LIVES_GAME_OBJ_NAME).GetComponent<UnityEngine.UI.Text>().text = newText;
    }

    public bool IsAlive()
    {
        return remainingLives > 0;
    }
}
