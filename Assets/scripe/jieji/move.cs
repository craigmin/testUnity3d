using UnityEngine;


public class move : MonoBehaviour {
	public Vector2 velocity = new Vector2(0, -4);
	//public int range = 4;
	public GameObject gameObject;
	public static int xuanze = 0;

	// Use this for initialization
	void Start () {

		rigidbody2D.velocity = velocity;
		//transform.position = new Vector3(transform.position.x- Random.Range(0, range)*1.5f, transform.position.y , transform.position.z);
	
	}
	void  Update(){
				//Destroy (gameObject, 10);
		if (xuanze == 2) {
						if (gameObject.transform.position.y < jieji.b - 10) {
								Destroy (gameObject);
						}
				}
		if (xuanze == 1) {
			if (gameObject.transform.position.y < creatObject.b - 10) {
				Destroy (gameObject);
			}
		}
		if (xuanze == 3) {
			if (gameObject.transform.position.y < can.b - 10) {
				Destroy (gameObject);
			}
		}

		}
   }
