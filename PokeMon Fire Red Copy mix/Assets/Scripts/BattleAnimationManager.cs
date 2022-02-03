using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleAnimationManager : MonoBehaviour
{
    [SerializeField] private GameObject _frame1;
    [SerializeField] private GameObject _frame2;
    [SerializeField] private GameObject _frame3;
    [SerializeField] private GameObject _frame4;
    [SerializeField] private GameObject _frame5;
    [SerializeField] private GameObject _frame6;
    [SerializeField] private GameObject _frame7;
    [SerializeField] private GameObject _frame8;
    [SerializeField] private GameObject _frame9;
    [SerializeField] private GameObject _frame10;
    [SerializeField] private GameObject _frame11;
    [SerializeField] private GameObject _frame12;
    [SerializeField] private GameObject _frame13;
    [SerializeField] private GameObject _frame14;
    [SerializeField] private GameObject _frame15;
    [SerializeField] private GameObject _frame16;
    [SerializeField] private GameObject _frame17;
    [SerializeField] private GameObject _frame18;
    [SerializeField] private GameObject _frame19;
    [SerializeField] private GameObject _frame20;
    [SerializeField] private GameObject _frame21;
    [SerializeField] private GameObject _frame22;
    [SerializeField] private GameObject _frame23;
    [SerializeField] private GameObject _frame24;
    [SerializeField] private GameObject _frame25;
    [SerializeField] private GameObject _frame26;
    [SerializeField] private GameObject _frame27;
    [SerializeField] private GameObject _frame28;
    [SerializeField] private GameObject _frame29;
    [SerializeField] private GameObject _frame30;
    [SerializeField] private GameObject _frame31;
    [SerializeField] private GameObject _frame32;
    [SerializeField] private GameObject _frame33;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            CallAnimation();
        }
    }

    public void CallAnimation()
    {
        StartCoroutine(Animation());
    }

    IEnumerator Animation()
    {
        yield return new WaitForSeconds(.5f);

        _frame33.SetActive(true);

        yield return new WaitForSeconds(0.2f);

        _frame33.SetActive(false);

        yield return new WaitForSeconds(.1f);

        _frame33.SetActive(true);

        yield return new WaitForSeconds(0.2f);

        _frame33.SetActive(false);

        yield return new WaitForSeconds(0.1f);

        _frame1.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame1.SetActive(false);
        _frame2.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame2.SetActive(false);
        _frame3.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame3.SetActive(false);
        _frame4.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame4.SetActive(false);
        _frame5.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame5.SetActive(false);
        _frame6.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame6.SetActive(false);
        _frame7.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame7.SetActive(false);
        _frame8.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame8.SetActive(false);
        _frame9.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame9.SetActive(false);
        _frame10.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame10.SetActive(false);
        _frame11.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame11.SetActive(false);
        _frame12.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame12.SetActive(false);
        _frame13.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame13.SetActive(false);
        _frame14.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame14.SetActive(false);
        _frame15.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame15.SetActive(false);
        _frame16.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame16.SetActive(false);
        _frame17.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame17.SetActive(false);
        _frame18.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame18.SetActive(false);
        _frame19.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame19.SetActive(false);
        _frame20.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame20.SetActive(false);
        _frame21.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame21.SetActive(false);
        _frame22.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame22.SetActive(false);
        _frame23.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame23.SetActive(false);
        _frame24.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame24.SetActive(false);
        _frame25.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame25.SetActive(false);
        _frame26.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame26.SetActive(false);
        _frame27.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame27.SetActive(false);
        _frame28.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame28.SetActive(false);
        _frame29.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame29.SetActive(false);
        _frame30.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame30.SetActive(false);
        _frame31.SetActive(true);

        yield return new WaitForSeconds(0.03f);

        _frame31.SetActive(false);
        _frame32.SetActive(true);

        yield return new WaitForSeconds(1f);

        _frame32.SetActive(false);


        SceneManager.LoadScene("Battle");
    }
}
