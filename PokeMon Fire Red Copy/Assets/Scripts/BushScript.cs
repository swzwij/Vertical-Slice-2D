using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushScript : MonoBehaviour
{
    [SerializeField] private GameObject _bush1;
    [SerializeField] private GameObject _bush2;

    [SerializeField] private GameObject _bushTop1;

    [SerializeField] private GameObject _leaves1;
    [SerializeField] private GameObject _leaves2;

    private bool isEncounter;

    private void Start()
    {

        _bush1.SetActive(true);
        _bush2.SetActive(false);
        _bushTop1.SetActive(false);
        _leaves1.SetActive(false);
        _leaves2.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        int encounter = Random.Range(1, 16);

        if (encounter == 12) isEncounter = true;
        else isEncounter = false;

        if (isEncounter)
        {
            print("Encounter");
        }

        StartCoroutine(BushEnter());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _bushTop1.SetActive(false);
    }

    IEnumerator BushEnter()
    {
        _bush1.SetActive(false);
        _bush2.SetActive(true);

        yield return new WaitForSeconds(0.2f);

        StartCoroutine(Leaves());

        _bush1.SetActive(true);
        _bush2.SetActive(false);
        _bushTop1.SetActive(true);
    }

    IEnumerator Leaves()
    {

        _leaves1.SetActive(true);
        _leaves2.SetActive(false);

        yield return new WaitForSeconds(0.2f);

        _leaves1.SetActive(false);
        _leaves2.SetActive(true);

        yield return new WaitForSeconds(0.2f);

        _leaves1.SetActive(false);
        _leaves2.SetActive(false);
    }

}