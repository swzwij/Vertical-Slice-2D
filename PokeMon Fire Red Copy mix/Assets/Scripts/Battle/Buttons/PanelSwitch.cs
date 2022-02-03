using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwitch : MonoBehaviour
{
    public GameObject Basis;
    public GameObject Attacks;

    public void Start()
    {
        Attacks.SetActive(false);
    }
    public void Switch()
    {
        if(Attacks != null)
        {
            Attacks.SetActive(true);
            Basis.SetActive(false);
        }
    }
}
