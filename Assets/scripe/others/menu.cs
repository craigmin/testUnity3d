using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	public static int yinxiao = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(yinxiao == 1){
		GameObject.Find ("yinxiao Text").GetComponent<GUIText> ().text = "音效："    +"开";
		}
		if (yinxiao == -1) {
		GameObject.Find ("yinxiao Text").GetComponent<GUIText> ().text = "音效："    +"关";		
		}
		GameObject.Find ("Classics Text").GetComponent<GUIText> ().text = "经典" ;
		GameObject.Find ("Can Text").GetComponent<GUIText> ().text = "禅" ;
		GameObject.Find ("Jijie Text").GetComponent<GUIText> ().text = "街机" ;
		if (Input.GetMouseButtonUp (0)) {
			Ray pos = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(pos,out hit)) {
				if (hit.transform.name == "Cube4"){
					move.xuanze = 1;
					Application.LoadLevelAsync("classics");
				}
				if (hit.transform.name == "Cube3"){
					move.xuanze = 2;
					Application.LoadLevelAsync("jieji");
				}
				if (hit.transform.name == "Cube1"){
					move.xuanze = 3;
					Application.LoadLevelAsync("can");
				}
				if (hit.transform.name == "Cube2"){
					yinxiao = (-1)*yinxiao;
				}
			}
		}
	}
}
