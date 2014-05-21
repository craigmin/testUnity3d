#pragma strict

function Start () {

}
var defen:int = 0;
var cam:Camera;
function Update () {
if(Input.GetMouseButton(0))//Down或Up
{
var ray =cam.ScreenPointToRay (Input.mousePosition);
var hit: RaycastHit;
if(Physics.Raycast(ray,hit))
{
if(hit.collider.gameObject.tag=="Finish")//射线碰撞到的物体标签
{//transform.position=hit.point;
//print(hit.point);//鼠标点击的坐标
    Debug.Log("lllllll");
    defen++;
  
   gameObject.Find("Score").GetComponent(GUIText).text="得分：" + defen;
}
if(hit.collider.gameObject.tag=="Respawn"){

     Application.Quit();
}
}

}
}

