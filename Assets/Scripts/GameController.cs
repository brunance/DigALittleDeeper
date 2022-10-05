using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOver;

    public static GameController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void BeginGame()
    {
        SceneManager.LoadScene("ClipScene");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
