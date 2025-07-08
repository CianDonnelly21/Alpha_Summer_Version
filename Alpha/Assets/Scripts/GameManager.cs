using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour {

//Scene Changer

//Text in game eg. gems collected, health, and time
public Button PlayButton;

public int gems;
public TextMeshProUGUI Gems_Left;

void Start() 
    {
        PlayButton.onClick.AddListener(LevelOne);
        gems = 0;
    }

void Update()
    {

    }

public void UpdateGems(int NumberOfGems)
    {
        gems -= NumberOfGems;
        Gems_Left.text = "Gems Left: " + gems;
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