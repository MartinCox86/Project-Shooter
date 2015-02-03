using UnityEngine;
using System.Collections;

public class playerfire : MonoBehaviour {
	
	public GameObject abullet;
	
	void Update () {
		
		shoot();

	}
	
	void shoot(){
		
	float hoz = Input.GetAxis("P1_Horizontal2");
	float vert = Input.GetAxis("P1_Vertical2");
		
		if(hoz!=0||vert!=0){
				
			GameObject thisbull = Instantiate(abullet) as GameObject;
				
			thisbull.transform.position = gameObject.transform.position;
			thisbull.GetComponent<movebullet>().origin = gameObject.transform.position;
				
			Vector2 rot = new Vector2(hoz,vert);
			
			Debug.Log("hoz is " +hoz+". and vert is "+vert);
			
			//if(hoz!=0&&vert!=0){
				
				Vector2 v = rot - new Vector2(0,0);
				
				var angleRadians=Mathf.Atan2(v.y, v.x);
				
				float angleDegrees = angleRadians * Mathf.Rad2Deg;
				
				if (angleDegrees<0) {
	     			angleDegrees+=360;
				}
				
				Debug.Log(angleDegrees);
				
				Vector3 bulletangle = thisbull.transform.eulerAngles;
				bulletangle.z = angleDegrees;
				thisbull.transform.eulerAngles = bulletangle;
	
			}
		
	}
	
	
}
