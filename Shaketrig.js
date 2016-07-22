#pragma strict

private var camerashake : CameraShake;
public var audio1 : AudioClip;
var audio2: AudioSource;
var debris : Transform;
var spawnDebri : Transform;


function Start () 
{
	camerashake = GameObject.Find("MainCamera").GetComponent(CameraShake);
	audio2 = GetComponent.<AudioSource>();

}

function OnMouseDown ()
{
	{
	    
	    GetComponent.<AudioSource>().PlayOneShot(audio1, 1);
	    Instantiate(debris, spawnDebri.transform.position, spawnDebri.transform.rotation);
		camerashake.CameraShake();
		yield WaitForSeconds(13);
		Application.LoadLevel("AfterEQ");
	}
 
}
