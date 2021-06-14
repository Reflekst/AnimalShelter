using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAgent : MonoBehaviour
{
    [SerializeField] GameObject agent;
    [SerializeField] private int maxAgentNumber;
    [SerializeField] private int spawnDelayMin, spawnDelayMax;
    private int xPos;
    private int zPos;
    private int agentCount;


    void Start()
    {
        InvokeRepeating("Spawn", 0, 1);
    }

    private void Spawn()
    {
        {
            xPos = Random.Range(0, 10);
            zPos = Random.Range(0, 10);
            Instantiate(agent, new Vector3(xPos, 0.34f, zPos), Quaternion.identity);
            agentCount++;
        }
    }


}
