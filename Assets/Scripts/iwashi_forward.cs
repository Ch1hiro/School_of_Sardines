using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iwashi_forward : MonoBehaviour {

    public Rigidbody iwashiRigid;

	// Use this for initialization
	void Start () {
        iwashiRigid = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
        iwashiRigid.velocity = transform.forward;
	}
}
