using UnityEngine;
using System.Collections;

public class MainCharacter : MonoBehaviour {

	public float speed = 10;

	public GameObject enemy;
	public GameObject bullet;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			GameObject go = (GameObject)Instantiate(enemy, new Vector3(Random.Range(-20.0f, 20.0f), 0, Random.Range(-20.0f, 20.0f)), Quaternion.identity);
			go.GetComponent<Enemy>().mc = this.gameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)) {
			transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
		} else if(Input.GetKey(KeyCode.D)) {
			transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
		}

		if(Input.GetKey(KeyCode.W)) {
			transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
		} else if(Input.GetKey(KeyCode.S)) {
			transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
		}

		if(Input.GetKeyDown(KeyCode.Space)) {
			Rigidbody rb = GetComponent<Rigidbody>();
			rb.AddForce(new Vector3(0, 400, 0));
		}

		if(Input.GetKeyDown(KeyCode.J)) {
			GameObject go = (GameObject)Instantiate(bullet, transform.position + new Vector3(0, -0.5f, 0), transform.rotation);
		}

	}
}
