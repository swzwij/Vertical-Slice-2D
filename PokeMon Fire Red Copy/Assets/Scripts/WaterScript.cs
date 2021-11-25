using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    [SerializeField] private GameObject _water1;
    [SerializeField] private GameObject _water2;
    [SerializeField] private GameObject _water3;
    [SerializeField] private GameObject _water4;
    [SerializeField] private GameObject _water5;
    [SerializeField] private GameObject _water6;
    [SerializeField] private GameObject _water7;
    [SerializeField] private GameObject _water8;

    void Start()
    {
        _water1.SetActive(false);
        _water2.SetActive(false);
        _water3.SetActive(false);
        _water4.SetActive(false);
        _water5.SetActive(false);
        _water6.SetActive(false);
        _water7.SetActive(false);
        _water8.SetActive(false);

        StartCoroutine(WaterAni());

    }

    IEnumerator WaterAni()
    {
        yield return new WaitForSeconds(0.5f);
        _water1.SetActive(true);
        _water2.SetActive(false);
        _water3.SetActive(false);
        _water4.SetActive(false);
        _water5.SetActive(false);
        _water6.SetActive(false);
        _water7.SetActive(false);
        _water8.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        _water1.SetActive(false);
        _water2.SetActive(true);
        _water3.SetActive(false);
        _water4.SetActive(false);
        _water5.SetActive(false);
        _water6.SetActive(false);
        _water7.SetActive(false);
        _water8.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        _water1.SetActive(false);
        _water2.SetActive(false);
        _water3.SetActive(true);
        _water4.SetActive(false);
        _water5.SetActive(false);
        _water6.SetActive(false);
        _water7.SetActive(false);
        _water8.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        _water1.SetActive(false);
        _water2.SetActive(false);
        _water3.SetActive(false);
        _water4.SetActive(true);
        _water5.SetActive(false);
        _water6.SetActive(false);
        _water7.SetActive(false);
        _water8.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        _water1.SetActive(false);
        _water2.SetActive(false);
        _water3.SetActive(false);
        _water4.SetActive(false);
        _water5.SetActive(true);
        _water6.SetActive(false);
        _water7.SetActive(false);
        _water8.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        _water1.SetActive(false);
        _water2.SetActive(false);
        _water3.SetActive(false);
        _water4.SetActive(false);
        _water5.SetActive(false);
        _water6.SetActive(true);
        _water7.SetActive(false);
        _water8.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        _water1.SetActive(false);
        _water2.SetActive(false);
        _water3.SetActive(false);
        _water4.SetActive(false);
        _water5.SetActive(false);
        _water6.SetActive(false);
        _water7.SetActive(true);
        _water8.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        _water1.SetActive(false);
        _water2.SetActive(false);
        _water3.SetActive(false);
        _water4.SetActive(false);
        _water5.SetActive(false);
        _water6.SetActive(false);
        _water7.SetActive(false);
        _water8.SetActive(true);

        StartCoroutine(WaterAni());

    }
}

