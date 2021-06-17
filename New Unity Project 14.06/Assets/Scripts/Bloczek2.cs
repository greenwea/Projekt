using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloczek2 : MonoBehaviour
{
    public GameObject bloczek;
    int BloczekHP = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision2D)//kolizja z przegrana i punk upem
    {
        if (collision2D.gameObject.tag == "Pilka")
        {
            BloczekHP--;
            if (BloczekHP == 0)
            {
                bloczek.gameObject.SetActive(false);
                ManagerGry.instance.BloczekCount();
            }
            for (int i = 0; i < 10; i++)
            {
                ManagerGry.instance.ScoreUp();
            }
        }
    }
}