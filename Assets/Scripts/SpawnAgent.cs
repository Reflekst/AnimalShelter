using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAgent : MonoBehaviour
{
    [SerializeField] GameObject agent;
    [SerializeField] private int maxAgentNumber;
    [SerializeField] private int spawnDelayMin, spawnDelayMax;
    [SerializeField] private bool continueSpawning = true;
    private int xPos;
    private int zPos;

    void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        while (continueSpawning)
        {
            if (GameObject.FindGameObjectsWithTag("AgentTag").Length < maxAgentNumber)
            {
                xPos = Random.Range(0, 10);
                zPos = Random.Range(0, 10);
                Instantiate(agent, new Vector3(xPos, 0.34f, zPos), Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(spawnDelayMin, spawnDelayMax));
            }
            else
                yield return new WaitForSeconds(0);
        }
    }
}


