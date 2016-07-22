using UnityEngine;
using System.Collections;

public class spriteActivate0 : MonoBehaviour {
	public GameObject spriteActive;
	public bool isInactive;
	public bool isActive;
	public AudioClip Audio;



	// Use this for initialization
	void Start () {
		spriteActive.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnButtonDown(){
		
		if(isInactive){
			spriteActive.gameObject.SetActive (true);

		}
		if(isActive){
			spriteActive.gameObject.SetActive (false);
		}
	}
}
