using UnityEngine;

public class BananaMan_Movement : MonoBehaviour {

public float speed = 0.1f;
public GameObject CrouchMan;
public GameObject BananaMan;

void Start() 
    {
        BananaMan.gameObject.SetActive(true);
        CrouchMan.gameObject.SetActive(false);
    }

void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.back * speed);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * 1);
        }
        //Double Jump
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * 7);
        }

        //Crouch 
        if (Input.GetKey(KeyCode.DownArrow))
        {
            BananaMan.transform.position = transform.position;

            CrouchMan.gameObject.SetActive(true);
            BananaMan.gameObject.SetActive(false);
        }
        else 
        {
            CrouchMan.transform.position = transform.position;

            CrouchMan.gameObject.SetActive(false);
            BananaMan.gameObject.SetActive(true);
        }
    }
}