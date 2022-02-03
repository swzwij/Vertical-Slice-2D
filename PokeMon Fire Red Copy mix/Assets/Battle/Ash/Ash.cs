using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ash : MonoBehaviour
{
    [SerializeField] private GameObject _frame1;
    [SerializeField] private GameObject _frame2;
    [SerializeField] private GameObject _frame3;
    [SerializeField] private GameObject _frame4;
    [SerializeField] private GameObject _frame5;

    public Transform target;

    public float speed;

    private bool shouldMove;

    private void Update()
    {
        float step = speed * Time.deltaTime;
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            CallAnimation();
            
        }

        if(shouldMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    public void CallAnimation()
    {
        StartCoroutine(Animation());
    }

    IEnumerator Animation()
    {
        shouldMove = true;

        _frame1.SetActive(true);

        yield return new WaitForSeconds(0.25f);

        _frame1.SetActive(false);
        _frame2.SetActive(true);

        yield return new WaitForSeconds(0.25f);

        _frame2.SetActive(false);
        _frame3.SetActive(true);

        yield return new WaitForSeconds(0.25f);

        _frame3.SetActive(false);
        _frame4.SetActive(true);

        yield return new WaitForSeconds(0.25f);

        _frame4.SetActive(false);
        _frame5.SetActive(true);

        yield return new WaitForSeconds(0.25f);

        _frame5.SetActive(false);

        shouldMove = false;
    }
}
