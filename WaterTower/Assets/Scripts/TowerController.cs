using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public GameObject follower;
    public GameObject person;
    //Transform towerLocation;
    //private float xLeft;
    //private float xRight;
    //private float zLeft;
    //private float zRight;
    // Use this for initialization
    void Start()
    {
        person = Instantiate(follower);
        person.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
	// Update is called once per frame
	void Update () {
		
	}
}