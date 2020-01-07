using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {

    public Animator ani;
   

	// Use this for initialization
	void Start () {
        ani = gameObject.GetComponent<Animator>();
	}

    public void OpenDoor()
    {
        ani.SetBool("character_nearby", true);
        Destroy(this);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
