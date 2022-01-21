using UnityEngine;
using UnityEngine.UI;

public class EndSceneController : MonoBehaviour
{
    public PlayerData transfer;
    public Text scoreText;
    public Text nameText;
    public int myScore;
    void Start()
    {

        myScore = transfer.score;
        nameText.text = transfer.playerName;

    }

    private void Update()
    {
        scoreText.text = "My Score: " + myScore;

    }


}