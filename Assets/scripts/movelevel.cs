using UnityEngine;
using System.Collections;

public class movelevel : MonoBehaviour {
	
	public float speed;
	
	void Update () {
		
		Vector3 mycurrentposition = gameObject.transform.position;
		mycurrentposition.y = mycurrentposition.y+(speed*Time.deltaTime);
		gameObject.transform.position = mycurrentposition;
		
	}
	
}
