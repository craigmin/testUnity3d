using UnityEngine;


public class move : MonoBehaviour {
	public Vector2 velocity = new Vector2(0, -4);
	public int range = 4;
	public GameObject gameObject;

	// Use this for initialization
	void Start () {
	


		rigidbody2D.velocity = velocity;
		transform.position = new Vector3(transform.position.x- Random.Range(0, range)*1.5f, transform.position.y , transform.position.z);
	
	}
	void  Update(){
		Destroy (gameObject, 4);
	}
	// Update is called once per frame

}
