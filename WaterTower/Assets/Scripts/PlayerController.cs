using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Person {
    public Camera firstPerson;
    public Camera overhead;
    GameObject result;

    void showOverhead(){
        firstPerson.enabled = false;
        overhead.enabled = true;
    }

    void showFirstPerson(){
        firstPerson.enabled = true;
        overhead.enabled = false;
    }

    // Use this for initialization
	//center is -0.5f,-0.5f
    //x bounds are 0 and -1
    //z bounds are 0 and -1
    void Start () {
        //StartCoroutine(towerCoroutine());
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void FixedUpdate()
    {
        //if enemy goes in your square, then enter first person

    }
}
