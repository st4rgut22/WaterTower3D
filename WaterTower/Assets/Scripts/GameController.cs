using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject waterTower;
    public GameObject follower;
    public GameObject player;
    public static int boardLength;
    private float xPos = -2.5f;
    public static GameController instance = null;
    public static GameObject[] towerArray = new GameObject[boardLength * boardLength];
    private float zPos;


    private void Awake()
    {
        if (instance == null)
        {
            instance = gameObject.AddComponent<GameController>();
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    //set up the scene
    // Use this for initialization
    void Start()
    {
        ////keeps track of index in array holding the tower tiles 
        //int towerTilePos = 0;
        //player.transform.position = new Vector3(-0.5f, 0, -0.5f);
        //for (int i = 0; i < boardLength; i++)
        //{
        //    zPos = -2.5f;
        //    for (int j = 0; j < boardLength; j++)
        //    {
        //        GameObject singleTower = Instantiate(waterTower);
        //        towerArray[towerTilePos] = singleTower;
        //        singleTower.transform.position = new Vector3(xPos, 0, zPos);
        //        Debug.Log("x position : " + xPos + " z position: " + zPos);
        //        zPos = zPos + 1.0f;
        //        ++towerTilePos;
        //    }
        //    xPos = xPos + 1.0f;
        //}

    }

    // Update is called once per frame
    void Update()
    {

    }
}
