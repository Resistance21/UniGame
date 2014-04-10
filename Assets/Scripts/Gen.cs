using UnityEngine;
using System.Collections;

public class Gen : MonoBehaviour {
	public float Y = 30 ;
	public bool Spawn = true ;
	public GameObject NewLane;
	public float life = 15 ;
	public float delay = 3 ;
	
	private GameObject  B ;
	void Start () {
		
		
		//B = GameObject.Find("SpawnOn");
		StartCoroutine(Go());  
		
		
	}
	
	
	IEnumerator Go() {
		
		//  if ( B.active == false) {
		//Spawn = false;   
		//}
		
		yield return new WaitForSeconds (delay);
		if (Spawn == true) {
			GameObject clone;
			
			clone = Instantiate(NewLane, (transform.position + new Vector3(0,Y,0)), transform.rotation) as GameObject;
			//clone.velocity = transform.TransformDirection(Vector3.forward * 10);
			yield return new WaitForSeconds (life*2);
			// or just  put a number here
			Destroy(gameObject);
		}
	}
}