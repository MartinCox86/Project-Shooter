using UnityEngine;
using System.Collections;

public class moveplayer : MonoBehaviour {

	public float speed;
	public GameObject mainbackground;
	public Camera maincamera;
	
	void Update () {
		
		playermovements();
			
	}
	
	void playermovements(){
		
		Vector3 myoriginalposition = gameObject.transform.position;
		Vector3 mycurrentposition = gameObject.transform.position;

		if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow)){
			
			mycurrentposition.x = mycurrentposition.x-(speed*Time.deltaTime);
			
		}
		if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow)){
			
			mycurrentposition.x = mycurrentposition.x+(speed*Time.deltaTime);
			
		}
		if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow)){
			
			mycurrentposition.y = mycurrentposition.y+(speed*Time.deltaTime);
			
		}
		if(Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow)){
			
			mycurrentposition.y = mycurrentposition.y-(speed*Time.deltaTime);

		}
		
		
		float hoz = Input.GetAxis("P1_Horizontal");
		float vert = Input.GetAxis("P1_Vertical");

		if(hoz!=0){
				mycurrentposition.x = mycurrentposition.x+((Input.GetAxis("P1_Horizontal")*speed)*Time.deltaTime);
		}
		
		if(vert!=0){
				mycurrentposition.y = mycurrentposition.y+((Input.GetAxis("P1_Vertical")*speed)*Time.deltaTime);
		}
		
		
		Vector3 screenpos = maincamera.WorldToScreenPoint(mycurrentposition);
		if(screenpos.x<0||screenpos.x>maincamera.pixelWidth){
			mycurrentposition.x = myoriginalposition.x;
		}
		if(screenpos.y<0||screenpos.y>maincamera.pixelHeight){
			mycurrentposition.y = myoriginalposition.y;
		}

		gameObject.transform.position = mycurrentposition;
		
	}
	
}
