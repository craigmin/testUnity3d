#pragma strict

function Start () {

}
var jishu:int=0;
var prefab : Transform ;
var curObject:GameObject ;
function Update () {


	// Use this for initialization
	
	// Update is called once per frame

		if(Input.GetMouseButton(1))
			
		{    
			
			var ray = Camera.main.ScreenPointToRay (Input.mousePosition);    
			
			var hit : RaycastHit;    
			
			if (Physics.Raycast (ray, hit))    
				
			{    
				curObject =  hit.collider.gameObject;
				// 显示当前选中对象的名称
				
				print(curObject);
			    Instantiate (prefab, Vector3(1, 0, 0), Quaternion.identity);
                jishu++;
                print(jishu);
				
			}
			
			
			
		}

	}
