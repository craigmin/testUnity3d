using UnityEngine;
using System.Collections;

public class hittt : MonoBehaviour {
	string rez;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if(rez!=""){
			string rez2=RaycastFunct(Input.mousePosition);
			if(rez==rez2){
					if(rez=="heise"){
						print("000000000");

					}
				}
			}
		}
	}
	string RaycastFunct(Vector3 tach)
	{
		Ray pos;
//		Debug.Log(GameObject.Find("cursor").transform.position+"%%"+GameObject.Find("RateAppYes").transform.position);
//		if(MogaCursorScript.simulateMouseButtonUp||MogaCursorScript.simulateMouseButtonDown)
//		{
//			Debug.Log(GameObject.Find("cursor").transform.position+"%%"+GameObject.Find("RateAppYes").transform.position);
//			
//			RaycastHit hit;
//			
//			if(Physics.Raycast(GameObject.Find("cursor").transform.position,Vector3.forward,out hit,30))
//			{
//				return hit.transform.name;
//			}
//			return "";
//		}
//		else
//		{
			pos=Camera.main.ScreenPointToRay(tach+Vector3.forward*4.71f);
			RaycastHit hit;
			
			if(Physics.Raycast(pos,out hit,30))
			{
				return hit.transform.name;
			}
			return "";
			
		}
//	}
}
