using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ZmienScene()
    {
        SceneManager.LoadScene(2);

    }

    public void ZmienLevel1()
    {
        SceneManager.LoadScene(1);

    }

    public void ZmienLevel2()
    {
        SceneManager.LoadScene("Game2");

    }

    public void menu()
    {
        
        SceneManager.LoadScene("Menu");

    }





    public void Wyjdz() {
        Application.Quit();
    }





}
