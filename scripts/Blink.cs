using UnityEngine;
using System.Collections;

public class Blink : MonoBehaviour {
	
	private RaycastHit lastRaycastHit;
	public AudioClip audioClip;
	private float timeStamp;

	
	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		
	}
	
	private GameObject GetLookAtObject()
	{
		Vector3 origin = transform.position;
		Vector3 direction = Camera.main.transform.forward;
		float range = 200;
		
		if (Physics.Raycast (origin, direction, out lastRaycastHit, range) && (timeStamp <= Time.time))
			
			return lastRaycastHit.collider.gameObject;
		else
			return null;
		
	}
	
	private void TeleportToLookAt()
		
	{
		transform.position = lastRaycastHit.point + lastRaycastHit.normal * 2;
		timeStamp = Time.time + 1;
		if (audioClip !=  null)
			AudioSource.PlayClipAtPoint (audioClip, transform.position,1);

		
	}
	
	// Update is called once per frame
	
	void Update ()
		
	{
		if (Input.GetButtonDown ("Fire1"))
			if (GetLookAtObject () != null)
				TeleportToLookAt ();
		
	}
	
}
