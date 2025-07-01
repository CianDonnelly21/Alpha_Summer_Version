using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Food_Spawn : MonoBehaviour {

public GameObject BananaOne;
public GameObject BananaTwo;
public GameObject BananaThree;
public GameObject Cherry;
public GameObject Hotdog;
public GameObject BananaMan;
public GameObject CrouchMan;
public GameObject Olive;
public GameObject BoxMovable;

void Start()
    {
        BananaOne.gameObject.SetActive(true);
        BananaTwo.gameObject.SetActive(false);
        BananaThree.gameObject.SetActive(false);
        Cherry.gameObject.SetActive(false);
        Hotdog.gameObject.SetActive(true);
        Olive.gameObject.SetActive(false);

        BananaOne.gameObject.transform.position = new Vector3(Random.Range(-10, 15), 5, -1);
    }

void Update()
    {  

    }

void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("BananaOne"))
        {
            BananaOne.gameObject.SetActive(false);
            BananaTwo.gameObject.transform.position = new Vector3(Random.Range(-10, 15), 5, -1);
            BananaTwo.gameObject.SetActive(true);
        }

        if(other.CompareTag("BananaTwo"))
        {
            BananaTwo.gameObject.SetActive(false);
            BananaThree.gameObject.transform.position = new Vector3(Random.Range(-10, 15), 5, -1);
            BananaThree.gameObject.SetActive(true);
        } 

        if(other.CompareTag("BananaThree"))
        {
            BananaThree.gameObject.SetActive(false);
            Cherry.gameObject.SetActive(true);
            Olive.gameObject.SetActive(true);
        }

        if(other.CompareTag("Cherry"))
        {
            Cherry.gameObject.SetActive(false);
            
            //How it loads next scene
            int NextIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(NextIndex);
        }

        if(other.CompareTag("Death"))
        {
            BananaMan.gameObject.SetActive(false);
            CrouchMan.gameObject.SetActive(false);
            BananaOne.gameObject.SetActive(false);
            BananaTwo.gameObject.SetActive(false);
            BananaThree.gameObject.SetActive(false);
            Cherry.gameObject.SetActive(false);
            Hotdog.gameObject.SetActive(false);
        }

        if(other.CompareTag("Olive"))
        {
            Olive.gameObject.SetActive(false);
            BoxMovable.gameObject.SetActive(false);
        }
    }
}