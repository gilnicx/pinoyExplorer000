using UnityEngine;
using System.Collections;

public class spriteActivate : MonoBehaviour {
	public GameObject spriteActive;
	public bool isIncative;
	public bool isActive;


	// Use this for initialization
	void Start () {
		spriteActive.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if(isIncative){
			spriteActive.gameObject.SetActive (true);
		}
		if(isActive){
			spriteActive.gameObject.SetActive (false);
		}
	}
}
