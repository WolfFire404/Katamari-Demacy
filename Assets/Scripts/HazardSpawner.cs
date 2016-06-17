using UnityEngine;
using System.Collections;

public class HazardSpawner : MonoBehaviour
{
    public GameObject[] Hazards;
    public GameObject Player;
    public Vector3 spawnValues;
    public float startWait;
    public float spawnWait;

    void Start()
    {
        StartCoroutine(hazard());
    }

    IEnumerator hazard()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < Hazards.Length; i++)
            {
                GameObject Hazard = Hazards[Random.Range(0, Hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                var g = (GameObject)Instantiate(Hazard, spawnPosition, Quaternion.Euler(0, 0, Random.Range(0, 360)));
                var size = Random.Range(Player.transform.localScale.x * 0.1f, Player.transform.localScale.x * 2f);
                g.transform.localScale = new Vector3(size, size, 1);
                yield return new WaitForSeconds(spawnWait);
            }
        }
    }
}

