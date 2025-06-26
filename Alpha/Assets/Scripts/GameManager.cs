using UnityEngine;
using System.Collections;


public class GameManager : MonoBehaviour {

public GameObject Banana;
public GameObject BananaTwo;
public GameObject BananaThree;
public GameObject Cherry;
public GameObject BananaMan;
public GameObject CrouchMan;

void Start()
    {
        Banana.gameObject.SetActive(true);
        BananaTwo.gameObject.SetActive(false);
        BananaThree.gameObject.SetActive(false);
        Cherry.gameObject.SetActive(false);

        Banana.gameObject.transform.position = new Vector3(Random.Range(-2, 1), 5, -1);
    }

void Update()
    {

    }

void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Banana"))
        {
            Banana.gameObject.SetActive(false);
            BananaTwo.gameObject.transform.position = new Vector3(Random.Range(-4, 10), 5, -1);
            BananaTwo.gameObject.SetActive(true);
        }

        if(other.CompareTag("BananaTwo"))
        {
            BananaTwo.gameObject.SetActive(false);
            BananaThree.gameObject.transform.position = new Vector3(Random.Range(-4, 10), 5, -1);
            BananaThree.gameObject.SetActive(true);
        } 

        if(other.CompareTag("BananaThree"))
        {
            BananaThree.gameObject.SetActive(false);
            Cherry.gameObject.SetActive(true);
        }
    }
}