using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject pelota;
    public float velocidad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.D))
        {
            pelota.transform.Translate(0.56f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            pelota.transform.Translate(-0.56f, 0, 0);
        }
    }
}
