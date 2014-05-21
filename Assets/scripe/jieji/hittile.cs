using UnityEngine;


public class hittile : MonoBehaviour {
	public int defen = 0;
	public Camera cam;
	void Start () {
	
	}

	void Update(){

	if(Input.GetMouseButtonDown(0))
		{
			Ray pos = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(pos,out hit)) {
				if(hit.transform.name == "heise")//射线碰撞到的物体标签
				{
					Debug.Log("click heise");
					defen++;
  
					GameObject.Find("Score").GetComponent<GUIText>().text="得分：" + defen;
				} else {
					Debug.Log(hit.transform.name);
				}
			}
		}
	}

}
