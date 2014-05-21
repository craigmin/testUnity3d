using UnityEngine;


public class movebackgroud : MonoBehaviour {

	public GameObject rocks;

	void Start () {
		int i = 0;
		if (i<=10) {
			InvokeRepeating ("Createrocks", 1f, 0.5f);
			i++;
				}
	}

	void Createrocks()
	{
			Instantiate (rocks);
	}
}

	
