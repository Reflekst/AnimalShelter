using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Agent", menuName = "Sc/Agent")]
public class AgentDataScript : ScriptableObject
{
    private int healthPoint;
    public bool lifeState;
    private void OnEnable()
    {
        healthPoint = 3;   
    }

    public void TakeDamage()
    {
        healthPoint--;
        if (healthPoint == 0)
        {
            Death();
        }
    }

    private void Death()
    {
        lifeState = false;
    }
    public bool CheckLifestate
    {
        get
        {
            return lifeState;
        }
    }
}
