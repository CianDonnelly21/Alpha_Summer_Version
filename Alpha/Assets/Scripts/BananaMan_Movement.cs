using UnityEngine;

public class BananMan_Movement : MonoBehaviour {

public float speed = 0.1f;

void Start() 
{

}

void Update()
{
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * speed);
        }
}
}