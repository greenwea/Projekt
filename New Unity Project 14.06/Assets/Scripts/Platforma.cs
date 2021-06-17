using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforma : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;

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
        
    }

    void OnTriggerEnter2D(Collider2D other)//kolizja z powerupem
    {
        Debug.Log(other.name);

        moveSpeed = moveSpeed + 1;
        int randChance = Random.Range(1, 101);
            if (randChance < 20)
        {
            ManagerGry.instance.LifesUp();
        }




            Destroy(other.gameObject);

    }

    void FixedUpdate()//nieskonczenie pobiera klikniecia
    {
        TouchMove();
    }

    void TouchMove()//rejestruje czy klikasz praw oczy lewo czy nic
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(touchPos.x < 0)
            {
                rb.velocity = Vector2.left * moveSpeed;
            }
            else
            {
                rb.velocity = Vector2.right * moveSpeed;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
