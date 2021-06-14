using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAgent : MonoBehaviour
{
    [SerializeField] GameObject agent;
    [SerializeField] int maxAgentNumber;
    [SerializeField] int spawnDelayMin, spawnDelayMax;
    private int xPos;
    private int zPos;
    private int agentCount;


    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (agentCount <= maxAgentNumber)
        {
            xPos = Random.Range(0, 10);
            zPos = Random.Range(0, 10);
            Instantiate(agent, new Vector3(xPos, 0.34f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(spawnDelayMin,spawnDelayMax));
            agentCount++;
        }
    }


}
