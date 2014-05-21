using UnityEngine;
using System.Collections;

public class produceheise : MonoBehaviour {
	public GameObject rocks;
	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateObstacle", 1f, 0.6f);
	}
	
	// Update is called once per frame
	void CreateObstacle () {
		Instantiate(rocks);
	}
}
