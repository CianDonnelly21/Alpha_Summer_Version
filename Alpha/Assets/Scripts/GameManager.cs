using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

//Scene Changer

//Text in game eg. gems collected, health, and time
public Button PlayButton;

void Start() 
    {
        PlayButton.onClick.AddListener(LevelOne);
    }

void Update()
    {
        
    }

void LevelOne()
    {
        SceneManager.LoadScene(1);
   
    }

    void LevelTwo()
    {
        SceneManager.LoadScene(2);
    }

    void LevelThree()
    {
        SceneManager.LoadScene(3);
    }

    void Win()
    {
        SceneManager.LoadScene(4);
    }

    void Lose()
    {
        SceneManager.LoadScene(5);
    }
}