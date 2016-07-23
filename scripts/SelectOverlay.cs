using UnityEngine;
using System.Collections;

public class SelectOverlay : MonoBehaviour {
	public GameObject spriteActive;
	public bool isInactive;
	public bool isActive;
	public AudioClip selectsound;
	AudioSource selectaudio;



	// Use this for initialization
	void Start () {
		
		spriteActive.gameObject.SetActive (false);
		selectaudio = GetComponent<AudioSource> ();
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){

		selectaudio.PlayOneShot (selectsound, 1);
		
		if(isInactive){
			spriteActive.gameObject.SetActive (true);

		}
		if(isActive){
			spriteActive.gameObject.SetActive (false);
		}
	}
}
