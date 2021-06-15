using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelector : MonoBehaviour
{
    public GameObject agentTemplate;
    public Text nameText, hpText;
    private string targetName;
    private int targetHp;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Scan();
        }
    }
    private void Scan()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100)) ;
        {
            if (hit.collider.tag == "AgentTag")
            {
                AgentController target = hit.transform.GetComponent<AgentController>();
                targetName = target.name;
                targetHp = target.clone.CheckLifeValue;
                ShowUi();
            }
            else
            {
                HideUi();
            }
        }
    }
    private void ShowUi()
    {
        agentTemplate.gameObject.SetActive(true);
        nameText.text = targetName;
        hpText.text = targetHp.ToString();
    }
    private void HideUi()
    {
        agentTemplate.gameObject.SetActive(false);
    }
}
