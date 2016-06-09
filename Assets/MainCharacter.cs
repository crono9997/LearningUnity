using UnityEngine;
using System.Collections;

public class MainCharacter : MonoBehaviour {

	public float speed = 10;

	public GameObject enemy;
	public GameObject bullet;
	public GameObject body;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			GameObject go = (GameObject)Instantiate(enemy, new Vector3(Random.Range(-20.0f, 20.0f), 0, Random.Range(-20.0f, 20.0f)), Quaternion.identity);
			go.GetComponent<Enemy>().mc = this.gameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 cameraNormal = (Camera.main.transform.position - transform.position).normalized * -1;





		if(Input.GetKey(KeyCode.A)) {
			transform.Translate(Quaternion.Euler(0, 90, 0) * cameraNormal * -speed * Time.deltaTime);
		} else if(Input.GetKey(KeyCode.D)) {
			transform.Translate(Quaternion.Euler(0, 90, 0) * cameraNormal * speed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.W)) {
			transform.Translate(cameraNormal * speed * Time.deltaTime);
		} else if(Input.GetKey(KeyCode.S)) {
			transform.Translate(cameraNormal * -speed * Time.deltaTime);
		}

		if(Input.GetKeyDown(KeyCode.Space)) {
			Rigidbody rb = GetComponent<Rigidbody>();
			rb.AddForce(new Vector3(0, 800, 0));
		}

		body.transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y, 0);
		if(Input.GetKeyDown(KeyCode.J)) {
			GameObject go = (GameObject)Instantiate(bullet, transform.position + new Vector3(0, -0.5f, 0), body.transform.rotation);
		}


	}
}
