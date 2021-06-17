using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerGry : MonoBehaviour
{
    public static ManagerGry instance;

    public int life = 1;
    public Text lifeText;
    int score;
    public Text scoreText;
    public Text scoreTextt;
    public GameObject gameStartUI;
    public GameObject Bloczek;
    public int bloczekcount = 22;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LifesUp()
    {

        life++;
        lifeText.text = life.ToString();

    }
    public void LifesDown()
    {
        life--;
        lifeText.text = life.ToString();
    }
    public void GameStart()
    {
        gameStartUI.SetActive(false);
        scoreText.gameObject.SetActive(true);
        //Bloczek.SetActive(true);

    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void Restart2()
    {
        SceneManager.LoadScene("Game2");
    }
    public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
        scoreTextt.text = bloczekcount.ToString();

    }


    public void BloczekCount()
    {
        bloczekcount--;
        if (bloczekcount == 0)
        {
            Restart2();
        }
    }

}
