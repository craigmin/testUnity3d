using UnityEngine;
using System.Collections;

public class M_hit : MonoBehaviour {
//	string rez;
//	public	bool NotClickable=false;
//
//	// Use this for initialization
	void Start () {
	
	}
//	
//	// Update is called once per frame
////	void Update () {
////		if(Input.GetButtonDown("Fire1")){  
////			
////			 ray = Camera.main.ScreenPointToRay(Input.mousePosition);  			
////			 hit = RaycastHit; 		 		
////			if(Physics.Raycast(ray,hit)){  		
////					hit.collider.SendMessage("ApplyDamage",1,SendMessageOptions.DontRequireReceiver);  
////			}  
////            }  
////	        }
////	void	ApplyDamage(){
////		Debug.Log("HitMe!");  
////	}
	void Update () {
		RaycastHit hit;
		Ray r = Camera.mainCamera.ScreenPointToRay (Input.mousePosition);
		if (Input.GetButtonDown ("Fire1"))  {
			if(Physics.Raycast (r,out hit)){
				if(hit.collider.gameObject.name=="heise"){
					Debug.Log("mmm");
				}
			}		
		}
	}
	}


