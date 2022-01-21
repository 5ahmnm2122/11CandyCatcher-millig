
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public PlayerData transfer;
    public Text playerName;

    public void NextScene(string scene)
    {
        transfer.playerName = playerName.text;
        SceneManager.LoadScene(scene);
    }


}
