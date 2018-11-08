using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMoving : MonoBehaviour {

	public float velocidade = 0.1f;
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
	}
	void Update () {
		/*float vertical = Input.GetAxis("Vertical") * velocidade;
		float horizontal = Input.GetAxis("Horizontal") * velocidade;

		vertical += Time.deltaTime;
		horizontal += Time.deltaTime;

		transform.Translate(horizontal, 0, vertical);

		if(Input.GetKeyDown("escape"))
			Cursor.lockState = CursorLockMode.None;*/

		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

	}
}
