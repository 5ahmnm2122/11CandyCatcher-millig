
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCandy : MonoBehaviour
{
    [SerializeField] GameObject[] candyPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;




    void Start()
    {
        StartCoroutine(CandySpawn());

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

    private void OnTriggerEnter(Collider other)
    {
        Object.Destroy(this.gameObject);

    }

}
