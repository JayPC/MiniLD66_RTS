using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public bool isColliding(float x, float y, float w, float h, float x2, float y2, float w2, float h2){
		return !(y+h <= y2|| y>= y2+h2 || x+w <= x2|| x >= x2+w2);
	}

}
