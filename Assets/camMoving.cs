using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMoving : MonoBehaviour {

	Vector2 visao;
	Vector2 regular;
	public float sensitividade = 5.0f;
	public float suavidade = 2.0f;
	GameObject personagem;
	void Start () {
		personagem = this.transform.parent.gameObject;
	}
	void Update () {
		var movimento = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
		movimento = Vector2.Scale(movimento, new Vector2(sensitividade * suavidade, sensitividade * suavidade));
		regular.x = Mathf.Lerp(regular.x, movimento.x, 1f / suavidade);
		regular.y = Mathf.Lerp(regular.y, movimento.y, 1f / suavidade);
		visao.y = Mathf.Clamp(visao.y,-45f,45f);
		visao += regular;

		transform.localRotation = Quaternion.AngleAxis(-visao.y, Vector3.right);
		personagem.transform.localRotation = Quaternion.AngleAxis(visao.x, personagem.transform.up);		
	}
}
