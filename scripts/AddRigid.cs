using UnityEngine;
using System.Collections;

public class AddRigid : MonoBehaviour {
	public GameObject[] Object;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseButton () {

		for (int i = 0; i < Object.Length; i++) 
		{
			Object [i].AddComponent <Rigidbody>();

		}

	}
}
