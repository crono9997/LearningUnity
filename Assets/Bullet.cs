using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(transform.forward * 20 * Time.deltaTime);
	}

	void OnTriggerEnter(Collider col) {
		print(col);
		if (col.gameObject.tag == "Enemy") {
			Destroy(col.gameObject);
		}
	}
}
