using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClosePanel : MonoBehaviour
{
    public GameObject panel;

    public void ClosePanelGame()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }
}
