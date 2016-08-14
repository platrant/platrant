using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;

    public void UpdateScore(int scoreValueAmount)
    {
        score += scoreValueAmount;
        GameObject.Find("Score").GetComponent<UnityEngine.UI.Text>().text = "Score: " + score;
    }
}