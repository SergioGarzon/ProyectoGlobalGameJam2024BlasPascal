using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClosePanel : MonoBehaviour
{
    public GameObject panel;
    private int variable;

    private void Start()
    {
        variable = 0;
    }

    public void ClosePanelGame()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }

    public void OpenPanel()
    {
        if (panel != null && variable == 0)
        {
            variable = 1;
            panel.SetActive(true);            
        } else
        {
            variable = 0;
            panel.SetActive(false);
        }
    }

}
