using UnityEngine;
using System.Collections;

public class RobotTestScriptFree : MonoBehaviour {
	private Animator anim;
	private float pulo = 0;
	void Start () {
	
		anim = this.gameObject.GetComponent<Animator> ();
		Cursor.lockState = CursorLockMode.Locked;

	}
	void Update () {
		MovimentoBeatEmUp();
	}
	private void MovimentoBeatEmUp(){
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
			
		if(Input.GetKey("up") || Input.GetKey("w")) 
			anim.SetInteger("Speed", 2);
		else if (Input.GetKey("down") || Input.GetKey("s")) 
			anim.SetInteger("Speed", 1);
		else 
			anim.SetInteger("Speed", 0);

		if (Input.GetKey ("space")) {
			pulo = 1;
			anim.SetBool ("Jumping", true);
		}
		if (pulo > 0.5) 
			pulo -= Time.deltaTime;
		else if (anim.GetBool ("Jumping") == true) 
			anim.SetBool ("Jumping", false);

		return;
	}

	private void MovimentoRunner(){
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
			
		Input.GetKey("up"); 
		anim.SetInteger("Speed", 2);

		if (Input.GetKey ("space")) {
			pulo = 1;
			anim.SetBool ("Jumping", true);
		}
		if (pulo > 0.5) 
			pulo -= Time.deltaTime;
		else if (anim.GetBool ("Jumping") == true) 
			anim.SetBool ("Jumping", false);

		return;
	}
}
