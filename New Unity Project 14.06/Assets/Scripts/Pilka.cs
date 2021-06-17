using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilka : MonoBehaviour

{
    Rigidbody2D rb;
    //int life=2;
    
    //public Text lifeText;
    
    public float bounceForce;
    bool gameStarted;
    int zmienna;
    //public GameObject Bloczek;
    //int BloczekHP = 2;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            if (Input.GetMouseButton(0))
            {
                
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if (touchPos.y > 1.5)
                    ManagerGry.instance.GoToMenu();
                {

                }

                if (touchPos.x < 0)
                {
                    zmienna = 1;
                }
                else
                {
                    zmienna = -1;
                }
                StartBounce(zmienna);
                gameStarted = true;
                ManagerGry.instance.LifesUp();
                ManagerGry.instance.GameStart();
                /*if (Input.anyKeyDown)
                {
                    StartBounce();
                    gameStarted = true;
                    ManagerGry.instance.GameStart();

                */
            }
        }
    }

    void StartBounce(int zmienna) // Zaczyna pi³ke w losowym kierunku
    {
        Vector2 randomDirection = new Vector2(zmienna, 1);

        rb.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
    }
    /*
    public void LifesUp()
    {
        life++;
        life.Text = life.ToString();
        
    }
    public void LifesDown()
    {
        life--;
        life.Text = life.ToString();
    }*/


        void OnCollisionEnter2D(Collision2D collision2D)//kolizja z przegrana i punk upem
    {
        if (collision2D.gameObject.tag == "Przegrana")
        {
            ManagerGry.instance.LifesDown();
            if (ManagerGry.instance.life == 0)
            {
                ManagerGry.instance.Restart();
            }
        }
        else if (collision2D.gameObject.tag == "Przegrana2")
        {
            ManagerGry.instance.LifesDown();
            if (ManagerGry.instance.life == 0) {
                ManagerGry.instance.Restart2();
            }
        }

        else if (collision2D.gameObject.tag == "Platforma")
        {
            ManagerGry.instance.ScoreUp();
        }
        /*else if (collision2D.gameObject.tag == "Bloczek")
        {
            BloczekHP--;
            if (BloczekHP == 0)
                {
            Bloczek.gameObject.SetActive(false);
                }
            for (int i = 0; i < 10; i++) {
                ManagerGry.instance.ScoreUp();
            }*/
        }
    }


