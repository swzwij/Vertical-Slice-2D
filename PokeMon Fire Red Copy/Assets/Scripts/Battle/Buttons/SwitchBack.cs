using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchBack : MonoBehaviour
{
    public GameObject Basis;
    public GameObject Attacks;

    public void Switch()
    {
        if (Basis != null)
        {
            Attacks.SetActive(false);
            Basis.SetActive(true);
        }
    }
}
