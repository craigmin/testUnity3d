using UnityEngine;


public class movebackgroud : MonoBehaviour {

	public GameObject rocks;
	private int i = 0;
	void Start () {
		InvokeRepeating ("Createrocks", 1f, 0.5f);
	}

	void Createrocks()
	{
		Instantiate (rocks);
		i++;
		if(i==50){
			CancelInvoke();
		}
	}
}

	
