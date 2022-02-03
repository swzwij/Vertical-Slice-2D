using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerAnimation : MonoBehaviour
{
    [SerializeField] private GameObject _flower1;
    [SerializeField] private GameObject _flower2;
    [SerializeField] private GameObject _flower3;
    [SerializeField] private GameObject _flower4;
    [SerializeField] private GameObject _flower5;

    void Start()
    {
        _flower1.SetActive(false);
        _flower2.SetActive(false);
        _flower3.SetActive(false);
        _flower4.SetActive(false);
        _flower5.SetActive(false);

        StartCoroutine(FlowerAni());

    }

    IEnumerator FlowerAni()
    {
        yield return new WaitForSeconds(0.2f);
        _flower1.SetActive(true);
        _flower2.SetActive(false);
        _flower3.SetActive(false);
        _flower4.SetActive(false);
        _flower5.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        _flower1.SetActive(false);
        _flower2.SetActive(true);
        _flower3.SetActive(false);
        _flower4.SetActive(false);
        _flower5.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        _flower1.SetActive(false);
        _flower2.SetActive(false);
        _flower3.SetActive(true);
        _flower4.SetActive(false);
        _flower5.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        _flower1.SetActive(false);
        _flower2.SetActive(false);
        _flower3.SetActive(false);
        _flower4.SetActive(true);
        _flower5.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        _flower1.SetActive(false);
        _flower2.SetActive(false);
        _flower3.SetActive(false);
        _flower4.SetActive(false);
        _flower5.SetActive(true);

        StartCoroutine(FlowerAni());

    }
}
