using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Agent", menuName = "Sc/Agent")]
public class AgentDataScript : ScriptableObject
{
    [SerializeField] private int healthPoint;
    private void OnEnable()
    {
        healthPoint = 3;   
    }

    public void TakeDamage()
    {
        healthPoint--;
    }
 
    public bool CheckLifestate
    {
        get
        {
            return 0 >= healthPoint;
        }
    }
    public int CheckLifeValue
    {
        get
        {
            return healthPoint;
        }
    }
}
