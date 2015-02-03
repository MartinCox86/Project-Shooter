using UnityEngine;
using System.Collections;

public class gamecontrol : MonoBehaviour {
	
	public GameObject mainBackground;
	public Camera maincamera;
	public int gamelevel = 1;
	
	void Start () {
	
		startlevel(gamelevel);
		
	}
	
	void startlevel(int which){
		
		Vector3 backgroundscale = mainBackground.transform.localScale;
		
		if(which==1){
			
			backgroundscale.x = 1280;//maincamera.pixelWidth;
			backgroundscale.y = 8640;//maincamera.pixelHeight;
					
		}
		
		mainBackground.transform.localScale = backgroundscale;
		
	}
	
}
