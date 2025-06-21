using UnityEngine;

public class BananMan_Movement : MonoBehaviour {

public float horizontalInput;

void Start() 
{

}

void Update()
{
    horizontalInput = Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right );
}
}