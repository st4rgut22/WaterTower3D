using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Person : MonoBehaviour {
    //get the list of tiles 
    GameObject[] towerArray = GameController.towerArray;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//check if moved into new tile

	}

    private void battle(GameObject rebel,GameObject owner){
        //the rebel must defeat the owner to become the new owner
        //maybe by trying to push him off the tower
    }



    protected IEnumerator towerCoroutine(){
        while (true)
        {
            yield return new WaitForSeconds(3f);
            getNewTower();
        }
    }

    protected GameObject getNewTower(){
        //who is the owner of the tower
        float xPos = gameObject.transform.position.x;
        float zPos = gameObject.transform.position.z;
        int xPosInt = (int)Mathf.Floor(xPos);
        int zPosInt = (int)Mathf.Floor(zPos);
        int towerIndex = 5*(zPosInt + 3)+(xPosInt + 3);
        //tower array contains towers, with people inside
        Debug.Log("tower index is " + towerIndex);
        TowerController tc = towerArray[towerIndex].GetComponent<TowerController>();
        //if this is not the person's tower he must take it 
        if (this != tc.person) 
        {
            Debug.Log("You have entered someone's square");
            return towerArray[towerIndex];
        }
        else { return null; }
    } 
}
