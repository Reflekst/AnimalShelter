using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelector : MonoBehaviour
{
    public GameObject agentTemplate;
    public Text nameText, hpText, counterText;
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
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            if (hit.collider.tag == "AgentTag")
            {
                AgentController target = hit.transform.GetComponent<AgentController>();
                if (target != null)
                {
                    targetName = target.name;
                    targetHp = target.clone.CheckLifeValue;
                    ShowAgentUi();
                }
            }
            else
            {
                HideAgentUi();
            }
        }
    }
    private void ShowAgentUi()
    {
        agentTemplate.gameObject.SetActive(true);
        nameText.text = targetName;
        hpText.text = targetHp.ToString();
    }
    private void HideAgentUi()
    {
        agentTemplate.gameObject.SetActive(false);
    }
    public void DisplayDividers()
    {
        string tmp = "";
        for (int i = 1; i <= 100 ; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                tmp += "MarkoPolo";
            else if (i % 3 == 0)
               tmp += "Marko";
            else if (i % 5 == 0)
                tmp += "Polo";
            else
                tmp += i.ToString();
            tmp += " ";
        }
        counterText.text = tmp;
    }
}
