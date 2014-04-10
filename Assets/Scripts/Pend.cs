using UnityEngine;
using System.Collections;

public class Pend : MonoBehaviour {
	public float angle = 40.0f;
	public float speed = 1.5f;
	
	Quaternion qStart, qEnd;
	
	void Start () {
		qStart = Quaternion.AngleAxis ( angle, Vector3.forward);
		qEnd   = Quaternion.AngleAxis (-angle, Vector3.forward);
	}
	
	void Update () {
		transform.rotation = Quaternion.Lerp (qStart, qEnd, (Mathf.Sin(Time.time * speed) + 1.0f) / 2.0f);
	}
}