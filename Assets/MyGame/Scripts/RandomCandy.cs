
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomCandy : MonoBehaviour
{
    [SerializeField] GameObject[] candyPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    public PlayerData transfer;
    public Text nameText;
    public Text scoreText;
    public int myScore;




    void Start()
    {
        nameText.text = transfer.playerName;
        StartCoroutine(CandySpawn());
        myScore = transfer.score;


    }

    private void Update()
    {
        scoreText.text = "Score: " + myScore;
        transfer.score = myScore;
    }


    IEnumerator CandySpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, 7);
            GameObject gameObject = Instantiate(candyPrefab[Random.Range(0, candyPrefab.Length)],
            position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }

    }


}
