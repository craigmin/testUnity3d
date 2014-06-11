using UnityEngine;
using System.Collections;

public class Gameover : MonoBehaviour {
	public float timelost;
	public int v;
	public float timerlast;
	public float testFloat;
	public float clickable ;
	public static int moshi = 0;
	// Use this for initialization
	void Start () {
		testFloat = PlayerPrefs.GetFloat ("testFloat", 0);
		clickable = PlayerPrefs.GetFloat ("clickable", 0);
	}

	// Update is called once per frame
	void Update () {
		if(moshi == 1){
				if (creatObject.v == 3) {
			GameObject.Find ("lose Text").GetComponent<GUIText> ().text = "失败：" + creatObject.timelost.ToString(".000");
		}
		else{
			GameObject.Find ("lose Text").GetComponent<GUIText> ().text ="" + creatObject.timerlast.ToString(".000") ;
			GameObject.Find ("record Text").GetComponent<GUIText> ().text ="最高纪录" + creatObject.testFloat.ToString(".000") ;
		}
		if (Input.GetMouseButtonUp (0)) {
			Ray pos = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(pos,out hit)) {
				if(hit.transform.name == "quit" ){
					Application.LoadLevelAsync("menu");
				}
				if(hit.transform.name == "retry" ){
					move.xuanze = 1;
					Application.LoadLevelAsync("classics");
			}
				if(hit.transform.name == "share" ){
					// to  do something
				}
		}
	}
}
		if (moshi == 2) {
			GameObject.Find ("lose Text").GetComponent<GUIText> ().text =""+ jieji.i;
			GameObject.Find ("record Text").GetComponent<GUIText> ().text ="最高纪录" + jieji.recordtimes;
			if (Input.GetMouseButtonUp (0)) {
				Ray pos = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit hit;
				
				if(Physics.Raycast(pos,out hit)) {
					if(hit.transform.name == "quit" ){
						Application.LoadLevelAsync("menu");
					}
					if(hit.transform.name == "retry" ){
						move.xuanze = 2;
						Application.LoadLevelAsync("jieji");
					}
					if(hit.transform.name == "share" ){
						// to  do something
					}
				}
			}
		}
		if (moshi == 3) {
			GameObject.Find ("lose Text").GetComponent<GUIText> ().text =""+ can.i;
			GameObject.Find ("record Text").GetComponent<GUIText> ().text ="最高纪录" + can.testFloat;
			if (Input.GetMouseButtonUp (0)) {
				Ray pos = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit hit;
				
				if(Physics.Raycast(pos,out hit)) {
					if(hit.transform.name == "quit" ){
						Application.LoadLevelAsync("menu");
					}
					if(hit.transform.name == "retry" ){
						move.xuanze = 3;
						Application.LoadLevelAsync("can");
					}
					if(hit.transform.name == "share" ){
						// to  do something
					}
				}
			}
		}
	}

}