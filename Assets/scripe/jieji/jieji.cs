using UnityEngine;
using System.Collections;

public class jieji : MonoBehaviour {
	public float speed=0.5f;
	public static int i ;
	public Camera cam;
	public int p = 0;
	public static float b ;
	public Transform prefab3;
	public Transform prefab2;
	public Transform prefab1;
	public Transform prefab;
	public int range = 4;
	public int startgame = 0;
	public static float recordtimes;
	public int clickable = 0;
	//public float d ;
	private static string[] song1 = new string[]{"soundJ","soundI","soundJ","soundI","soundH","soundL","soundM","soundL","soundJ","soundL","soundM","soundM","soundM","soundM","soundM","soundJ","soundL","soundJ","soundM","soundM","soundM","soundL","soundM","soundM","soundO","soundL","soundL","soundL","soundM","soundC","soundH","soundI","soundI","soundI","soundI","soundI","soundI","soundH","soundH","soundO","soundO","soundO","soundO","soundO","soundP","soundO","soundM","soundL","soundM","soundC","soundH","soundB","soundJ","soundI","soundJ","soundI","soundH","soundL","soundM","soundL","soundJ","soundL","soundM","soundM","soundM","soundM","soundM","soundJ","soundL","soundJ","soundM","soundM","soundM","soundL","soundM","soundM","soundO","soundL","soundL","soundL","soundM","soundC","soundH","soundI","soundI","soundI","soundI","soundI","soundI","soundH","soundH","soundO","soundO","soundO","soundO","soundO","soundP","soundO","soundM","soundL","soundM","soundC","soundH","soundB"};
	public AudioClip soundJ;
//	public Vector2 velocity = new Vector2(0, (4+i));

	public Vector2 velocity ;
	void Start () {
//		Vector2 velocity = new Vector2(0, 4);
//		rigidbody2D.velocity = velocity;
		b = 1.5f;	
		i = 0;
		recordtimes = PlayerPrefs.GetFloat ("recordtimes", 0);
		GameObject.Find ("StartText").GetComponent<GUIText> ().text = "开始" ;
		Instantiate (prefab, new Vector3 (0.753F, 10.8f, 0), Quaternion.identity);
		Instantiate (prefab1, new Vector3 (0.7579032f - Random.Range (0, range) * 1.5f, 10.8f, 0), Quaternion.identity);
		Instantiate (prefab, new Vector3 (0.753F, 13.3f, 0), Quaternion.identity);
		Instantiate (prefab1, new Vector3 (0.7579032f - Random.Range (0, range) * 1.5f, 13.3f, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		if(p == 50){
			p = 0;
		}
		GameObject.Find ("Score").GetComponent<GUIText> ().text = "得分：" + i;
		if (startgame == 1) {
			Vector2 velocity = new Vector2(0, (4+0.1f*i));
			Debug.Log ("i的值"+ i);
			//Vector2 velocity = new Vector2(0,4);
		    rigidbody2D.velocity = velocity;

		}
		if (cam.transform.position.y - b > 8) {
			recordTime();
			StartCoroutine (Wait ());
		}
		if(clickable == 0){
			if (Input.GetMouseButtonDown (0)) {
				//cam.transform.Translate (Vector3.up * speed);
				Debug.Log ("GetMouseButtonUp");
				Ray pos = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit hit;
				
				if (Physics.Raycast (pos, out hit)) {
					if (hit.transform.name == "heise") {

						if ((b + 1) < hit.transform.position.y && (b + 4) > hit.transform.position.y) {	
							b = hit.transform.position.y;
						    Sound(song1[p++]);
							i++;
							speed += 0.008f*i;
 //							d += 0.008f*i;
							Instantiate (prefab2, new Vector3 (hit.transform.position.x, hit.transform.position.y, hit.transform.position.z - 0.1f), Quaternion.identity);
							Instantiate (prefab, new Vector3 (0.753F, 2.5f * i + 13.3f, 0), Quaternion.identity);
							Instantiate (prefab1, new Vector3 (0.7579032f - Random.Range (0, range) * 1.5f, 2.5f * i + 13.3f, 0), Quaternion.identity);
							Debug.Log(b+" -------- 点击坐标");
							Debug.Log(cam.transform.position.y+" -------- 摄像机坐标");
							if (hit.transform.position.y < 4 && hit.transform.position.y > 2) {
								startgame = 1;
								GameObject.Find ("StartText").GetComponent<GUIText> ().text="";
							}
						
						}
					}
					if (hit.transform.name == "backgroud1" || hit.transform.name == "backgroud2" || hit.transform.name == "backgroud3" || hit.transform.name == "backgroud4") {
						if ((b + 1) < hit.transform.position.y && (b + 4) > hit.transform.position.y) {
							Instantiate (prefab3, new Vector3 (hit.transform.position.x, hit.transform.position.y, hit.transform.position.z - 0.3f), Quaternion.identity);
							clickable = 1;
							recordTime();
							StartCoroutine (Wait ());
						}
					}
				}
			}
		}
	}
	IEnumerator Wait(){
		yield return new WaitForSeconds(0.1f);
		Gameover.moshi = 2;
		Application.LoadLevelAsync("Gameover");
	}
	void Sound(string c){
		
		StartCoroutine(PlaySound(c));
	}
	private IEnumerator PlaySound(string c){
		soundJ = Resources.Load("Audio/" + c) as AudioClip;
		if (menu.yinxiao == 1) {
						AudioSource.PlayClipAtPoint (soundJ, new Vector3 (transform.position.x, cam.transform.position.y, transform.position.z), 1.0f);
				}
			yield return null;
		
	}

	void recordTime(){
		if(recordtimes == 0){
			recordtimes = i;
			PlayerPrefs.SetFloat("recordtimes",recordtimes);
		}
		if(recordtimes<i){
			recordtimes = i;
			PlayerPrefs.SetFloat("recordtimes",recordtimes);
		}
	}

}
