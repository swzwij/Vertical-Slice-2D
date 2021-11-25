using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushScript : MonoBehaviour
{
    [SerializeField] private GameObject _bush1;
    [SerializeField] private GameObject _bush2;
    //[SerializeField] private GameObject _Leave1;
    //[SerializeField] private GameObject _Leave2;
    //[SerializeField] private ParticleSystem _leaves;

    private bool isEncounter;

    private void Start()
    {

        _bush2.SetActive(false);
        _bush1.SetActive(true);
        //_Leave1.SetActive(false);
        //_Leave2.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _bush1.SetActive(true);
        _bush2.SetActive(false);

        int encounter = Random.Range(1, 16);

        if (encounter == 12) isEncounter = true;
        else isEncounter = false;

        if (isEncounter)
        {
            print("Encounter");
        }

        //StartCoroutine(BushEnter());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _bush1.SetActive(false);
        _bush2.SetActive(true);
    }

    /*IEnumerator BushEnter()
    {
        

        yield return new WaitForSeconds(0.2f);
        _Leave1.SetActive(true);
        _Leave2.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        _Leave1.SetActive(false);
        _Leave2.SetActive(true);

        yield return new WaitForSeconds(0.2f);
        _Leave1.SetActive(false);
        _Leave2.SetActive(false);
    }*/

}