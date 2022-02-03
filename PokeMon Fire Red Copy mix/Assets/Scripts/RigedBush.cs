using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigedBush : MonoBehaviour
{
    public bool isTriggerd;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isTriggerd = true;
        print("is triggerd");
    }

}
