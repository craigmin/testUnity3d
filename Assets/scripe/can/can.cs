using UnityEngine;
using System.Collections;

public class can : MonoBehaviour {
	public int defen = 0;
	public static int i ;
	public int p = 0;
	public static float b ;
	public Camera cam;
	public Transform prefab;
	public Transform prefab1;
	public Transform prefab2;
	public Transform prefab3;
	public int range = 4;
	public float timer ;
	public static int v ;
	public float timer1;
	public static float timerlast;
	public static float timelost;
	public int notclick = 0;
	public static int testFloat;
	private static string[] song = new string[]{"soundJ","soundI","soundJ","soundI","soundH","soundL","soundM","soundL","soundJ","soundL","soundM","soundM","soundM","soundM","soundM","soundJ","soundL","soundJ","soundM","soundM","soundM","soundL","soundM","soundM","soundO","soundL","soundL","soundL","soundM","soundC","soundH","soundI","soundI","soundI","soundI","soundI","soundI","soundH","soundH","soundO","soundO","soundO","soundO","soundO","soundP","soundO","soundM","soundL","soundM","soundC","soundH","soundB","soundJ","soundI","soundJ","soundI","soundH","soundL","soundM","soundL","soundJ","soundL","soundM","soundM","soundM","soundM","soundM","soundJ","soundL","soundJ","soundM","soundM","soundM","soundL","soundM","soundM","soundO","soundL","soundL","soundL","soundM","soundC","soundH","soundI","soundI","soundI","soundI","soundI","soundI","soundH","soundH","soundO","soundO","soundO","soundO","soundO","soundP","soundO","soundM","soundL","soundM","soundC","soundH","soundB"};
	public static bool DEBUG = false;
	public float speed=10f ;
	public AudioClip soundJ;
	
	
	void Start () {
		b = 1.5f;
		i = 0;
		testFloat = PlayerPrefs.GetInt("testFloat", 0);
		GameObject.Find ("StartText").GetComponent<GUIText> ().text = "开始" ;
		GameObject.Find ("Score").GetComponent<GUIText> ().text = "时间：" + "30.000";
	}
	void Update () {
		
		if(p == 50){
			p = 0;
		}
		if (v == 1) {
			timer = (Time.time - timer1);
			GameObject.Find ("Score").GetComponent<GUIText> ().text = "时间：" +(30 - timer).ToString(".000");
		}

		if (v == 2) {
			GameObject.Find ("Score").GetComponent<GUIText> ().text = "时间：" + (0).ToString(".000");
		}
		if(((30 - timer))>0){
		if (notclick == 0) {
			if (Input.GetMouseButtonDown (0)) {
				Debug.Log ("GetMouseButtonUp");
				Ray pos = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit hit;
				
				if (Physics.Raycast (pos, out hit)) {
					if (hit.transform.name == "heise") {
							Debug.Log ("GetMouseButtonUp11111");
						if ((b + 1) < hit.transform.position.y && (b + 4) > hit.transform.position.y) {											            
								Debug.Log ("GetMouseButtonUp22222");
							
							Instantiate (prefab2, new Vector3 (hit.transform.position.x, hit.transform.position.y, hit.transform.position.z - 0.1f), Quaternion.identity);
							Sound(song[p++]);
							if (hit.transform.position.y < 4 && hit.transform.position.y > 2) {
								Debug.Log(hit.transform.position.y+" -------- 开始");
								Startime ();
								GameObject.Find ("StartText").GetComponent<GUIText> ().text="";
							}

						
							
							b = hit.transform.position.y;
							defen++;
							i++;
							
							
							//transform.Translate (0, 2.5f, 0, Camera.main.transform);
							cam.transform.Translate (Vector3.up*speed*0.25f);
							

								
								
								Instantiate (prefab, new Vector3 (0.753F, 2.5f * i + 8.3f, 0), Quaternion.identity);
								Instantiate (prefab1, new Vector3 (0.7579032f - Random.Range (0, range) * 1.5f, 2.5f * i + 8.3f, 0), Quaternion.identity);
								
								
							
							
							
						} else {
							
						}
						
					} 
					
					if (hit.transform.name == "backgroud1" || hit.transform.name == "backgroud2" || hit.transform.name == "backgroud3" || hit.transform.name == "backgroud4") {
						if ((b + 1) < hit.transform.position.y && (b + 4) > hit.transform.position.y) {
							Instantiate (prefab3, new Vector3 (hit.transform.position.x, hit.transform.position.y, hit.transform.position.z - 0.3f), Quaternion.identity);
								soundJ = Resources.Load("Audio/" + "end level") as AudioClip;
								if (menu.yinxiao == 1) {
							AudioSource.PlayClipAtPoint(soundJ, new Vector3(transform.position.x, b , transform.position.z),1.0f); 
								}
							notclick = 1;
							StartCoroutine (Wait ());
							timelost = timer;
							recordTime();
							Lost ();			
						}
					}
				}
			}
		}
		}else{
			soundJ = Resources.Load("Audio/" + "end level") as AudioClip;
			if (menu.yinxiao == 1) {
			AudioSource.PlayClipAtPoint(soundJ, new Vector3(transform.position.x, b , transform.position.z),1.0f); 
			}
			notclick = 1;
			StartCoroutine (Wait ());
			timelost = timer;
			recordTime();
			Win();			
		}
	}
	IEnumerator Wait(){
		yield return new WaitForSeconds(3);
		Gameover.moshi = 3;
		Application.LoadLevelAsync("Gameover");
	}
	void Startime(){
		log(timer+" -------- Startime");
		v = 1;
		timer1=Time.time;
	}

	void Lost(){
		Debug.Log (timer+" -------- Lost");
		v = 3;
	}
	void Win(){
		v = 2;
	}
	void recordTime(){
		if(testFloat == 0){
			testFloat = i;
			PlayerPrefs.SetInt("testFloat",testFloat);		
		}
		if(testFloat<i){
			testFloat = i;
			PlayerPrefs.SetInt("testFloat",testFloat);
		}
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
	
	public static void log(string loginfo){
		if(DEBUG) {
			Debug.Log (loginfo);
		}
	}
}
