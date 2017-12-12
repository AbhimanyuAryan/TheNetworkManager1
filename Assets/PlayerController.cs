//adapted from example script available at
//https://docs.unity3d.com/ScriptReference/Input.GetAxis.html
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    Rigidbody rb;
	public float speed = 25.0F;
    public float rotationSpeed = 50.0F;

    void Start(){
        rb = this.GetComponent<Rigidbody>(); 
    }

	// Update is called once per frame
	void Update () {
	
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        Quaternion turn = Quaternion.Euler(0f, rotation, 0f); 

        rb.MovePosition(rb.position + this.transform.forward * translation); 
        rb.MoveRotation(rb.rotation * turn); 

        // transform.Translate(0, 0, translation);
        // transform.Rotate(0, rotation, 0);
	}
}
