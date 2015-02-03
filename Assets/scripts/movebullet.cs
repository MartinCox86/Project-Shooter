using UnityEngine;
using System.Collections;

public class movebullet : MonoBehaviour {
	
	public Vector3 origin;
	Camera maincamera;
	public float speed;
	
	void Start(){
		maincamera = GameObject.Find("Main Camera").camera;
	}
	
	void Update () {
		
		//this would work fine for stationary objects
		float myspeed = speed * Time.deltaTime;
		transform.Translate(Vector3.right * myspeed); 
		
		Vector3 mycurrentposition = gameObject.transform.position;
		
		Vector3 screenpos = maincamera.WorldToScreenPoint(mycurrentposition);
		
		if(screenpos.x<0||screenpos.x>maincamera.pixelWidth){
			Destroy(gameObject);
		}
		if(screenpos.y<0||screenpos.y>maincamera.pixelHeight){
			Destroy(gameObject);
		}
		
	}
	
}
