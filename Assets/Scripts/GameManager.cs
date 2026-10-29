using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private int playerScore;
    [SerializeField] private int iaScore;
    [SerializeField] private TextMeshProUGUI playerScoreText;
    [SerializeField] private TextMeshProUGUI aiScoreText;

    public void PlayerAddPoint()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
    }

}
