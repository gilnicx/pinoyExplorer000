using UnityEngine;
using System.Collections;

public class Fading : MonoBehaviour {
	
	public Texture2D fadeOutTexture; //the texture that will load 
	public float fadeSpeed = 0.8f; //fade speed adjust nyo sa inspector
	
	private int drawDepth = -1000; 
	private float alpha = 1.0f;  //Texture value between 0 - 1 
	private int fadeDir = -1; //fade direction fade in -1 and out 1 
	
	void OnGUI () {
		alpha += fadeDir * fadeSpeed * Time.deltaTime; //speedtime covert to seconds
		alpha = Mathf.Clamp01 (alpha);
		
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawDepth;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);
	}
	public float BeginFade (int direction) {
		fadeDir = direction; 
		return (fadeSpeed);
	}
	
	void Update () {
		
		if (Input.GetButtonDown ("Fire1"))
		   BeginFade (-1);
		
	}
	
}


