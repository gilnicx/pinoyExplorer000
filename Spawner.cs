using UnityEngine;

public class Spawner : MonoBehaviour
{
	
	public GameObject[] Object;                // The enemy prefab to be spawned.
	public float spawnTime = 3f;            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.


void Start (){
	{
		// Find a random index between zero and one less than the number of spawn points.
			InvokeRepeating ("Start", spawnTime,spawnTime);
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		int GameObjectIndex = Random.Range (0, Object.Length);

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		Instantiate (Object[GameObjectIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}

}