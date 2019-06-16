using UnityEngine;
using System.Collections;

public class ballmove : MonoBehaviour {

	public float force;
	public Transform ballchecker;

	private int count;
	void Start () {
		//GetComponent<Rigidbody2D>().AddForce (new Vector2 (1f, 0.5f) * Time.deltaTime * force);
	// ball going up with force...now up only wen we press space
		//wenever level loadede start


		transform.position=new Vector2(0.0f,-2.19f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (1f, 0.5f) * Time.deltaTime * force);
		}
		if (transform.position.y < ballchecker.transform.position.y) {
			Application.LoadLevel (Application.loadedLevel);
		}
	}
		/*void OnTriggerEnter2D(Collider other)
		{
			if (other.gameObject.Tag ("pickup")) 
			{
				
				count = count + 1;
			OnGUI ();
			}

		}
		
	void OnGUI()
	{
		GUILayout.Label (count.ToString ());
	
	}*/
}

