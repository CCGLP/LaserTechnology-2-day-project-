using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	[SerializeField]
	private int casillasX;
	[SerializeField]
	private int casillasY;  


	[SerializeField]
	private GameObject square; 
	[SerializeField]
	private Vector2 mapSize; 
	// Use this for initialization
	void Start () {
		

		square.transform.localScale = new Vector3 (mapSize.x / casillasX , mapSize.y / casillasY, 1); 
		float x = this.transform.position.x - mapSize.x * 0.5f + square.transform.localScale.x * 0.5f ; 
		float y = this.transform.position.y - mapSize.y * 0.5f + square.transform.localScale.y * 0.5f; 

		for (int i = 0; i < casillasX; i++) {
			for (int j = 0; j < casillasY; j++) {
				y += mapSize.y / casillasY; 
				Instantiate (square, new Vector3(x, y, 0), square.transform.rotation);
			}

			x += mapSize.x / casillasX; 
			y = this.transform.position.y - mapSize.y * 0.5f + square.transform.localScale.y * 0.5f; 
		}



	}
	
	// Update is called once per frame
	void Update () {
		
	}


	#if UNITY_EDITOR
	void OnDrawGizmos(){
		Gizmos.DrawWireCube (this.transform.position, new Vector3 (mapSize.x, mapSize.y, 1));
	}
	#endif


}
