using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentDataScript : ScriptableObject
{
    private int healthPoint;

    private void OnEnable()
    {
        healthPoint = 3;   
    }
    
    private void TakeDamage()
    {
        healthPoint--;
        if (healthPoint == 0)
        {
            Death();
        }
    }
    private void Death()
    {

    }    

}
