using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    GameObject playerPokemon;
    GameObject enemyPokemon;
    private void Start()
    {
        playerPokemon = GameObject.Find("Charmander");
        enemyPokemon = GameObject.Find("Pidgey");
    }
    public void Counters()
    {
        float enemyDMG = enemyPokemon.GetComponent<Pokeman>().DMG;
        //float playerHP = playerPokemon.GetComponent<Pokeman>().HP.value;
       // playerHP -= enemyDMG;
        
    }
}
