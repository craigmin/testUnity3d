using UnityEngine;


public class hittile : MonoBehaviour {
	public int defen = 0;
	public Camera cam;
	void Start () {
	
	}

	void Update(){
		if(Input.GetMouseButtonDown(0))//Down或Up
		{
			//Debug.Log("GetMouseButtonDown");
			Ray pos = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(pos,out hit)) {
				//Debug.Log(hit.transform.name);
				if(hit.transform.name == "heise")//射线碰撞到的物体标签
				{
					//transform.position=hit.point;
					//print(hit.point);//鼠标点击的坐标
					Debug.Log("click heise");
					defen++;
  
					//GameObject.Find("Score").GetComponent(GUIText).text="得分：" + defen;
				} else {
					Debug.Log(hit.transform.name);
				}
			}
			
			
			/*var ray =cam.ScreenPointToRay (Input.mousePosition);
			var hit: RaycastHit;
			if(Physics.Raycast(ray,hit))
			{
				if(hit.collider.gameObject.tag=="Finish")//射线碰撞到的物体标签
				{
					//transform.position=hit.point;
					//print(hit.point);//鼠标点击的坐标
					Debug.Log("lllllll");
					defen++;
  
					gameObject.Find("Score").GetComponent(GUIText).text="得分：" + defen;
				}
			if(hit.collider.gameObject.tag=="Respawn"){

				Application.Quit();
			}*/
		}
	}

}
