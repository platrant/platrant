using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    private int score;

    public void UpdateScore(int scoreValueAmount)
    {
        score += scoreValueAmount;
        GameObject.Find("Score").GetComponent<UnityEngine.UI.Text>().text = "Score: " + score;
    }
}
