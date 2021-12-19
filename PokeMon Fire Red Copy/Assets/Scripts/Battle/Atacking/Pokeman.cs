using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokeman : MonoBehaviour
{
    public Slider HP;
    public float DMG;
    public float levens;

    public bool pid = false;
    public bool chaar = false;

    public GameObject enemy;
    private Pokeman enemyscript;



    public void Tackle()
    {
        enemyscript.levens -= DMG;

        enemyscript.HP.value = enemyscript.levens;
        print(enemyscript.levens+ "enemy");

        if (enemyscript.levens <= 0)
        {
            EnemyDeath();

        }

    }
    public void Peck()
    {
        enemyscript.levens -= DMG;
        enemyscript.HP.value = enemyscript.levens;

        print(enemyscript.levens + "player");
        if (levens <= 0)
        {
            PlayerDeath();
        }
    }

    public void Growl()
    {
        DMG += 2f;
        print(DMG + "DMG");
    }

    public void Screech()
    {
        enemyscript.DMG -= 2f;
        print(enemyscript.DMG + "DMG");
    }


    private void Start()
    {
        enemyscript = enemy.GetComponent<Pokeman>();



        HP.maxValue = levens;
        HP.value = levens;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space") && chaar)
        {
            Growl();

        }
        if (Input.GetKeyDown("t") && chaar)
        {
            Tackle();
        }
        if (Input.GetKeyDown("r") && pid)
        {
            Screech();
        }
    }


    public void PlayerDeath()
    {
        print(message: "you lose");
    }

    public void EnemyDeath()
    {
        print(message: "game over/ win");
    }

    public void Counter()
    {
        Peck();
       // Screech();

        /*
        int r = Random.Range(0, 10);
        if(r > 2)
        {
            Peck();
            print(enemyscript.levens);
        }
        if(r <= 2)
        {
            Screech();
            print(DMG + "DMG");
        }
        */
    }
}
