using UnityEngine;
using System.Collections;

public class sceneSelect : MonoBehaviour {

	public bool is1 = false;
	public bool is2 = false;
	public bool is3 = false;
	public bool is4 = false;
	public bool isQuit = false;

	void OnMouseDown(){
		if (is1){
			Application.LoadLevel ("1");
		}
		if (is2){
			Application.LoadLevel ("2");
		}
		if (is3){
			Application.LoadLevel ("3");
		}
		if (is4){
			Application.LoadLevel ("0");
		}
		if (isQuit) {
			Application.Quit ();
		}
	}
}
