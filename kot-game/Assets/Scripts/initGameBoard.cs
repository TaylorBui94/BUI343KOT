using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class initGameBoard : MonoBehaviour
{   
    public GameObject canvas; // canvas placed into inspector
    public GameObject[] players; // items placed into inspector
    private Vector3[] playerLocations; // use array
    // Start is called before the first frame update
    void Start() {
        //make new player array here
        Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
        int playercount = numPlayers.playercount; // grab dropdown player count
            Debug.Log("playercount is " + playercount); // inside check
        // load all player prefabs into player array
        //players = new GameObject[playercount];
        Debug.Log("player length is " + players.Length); // inside check
        Debug.Log("player length is " + players.Length); // inside check
        // uh maybe check if anything is being loaded into player array
        // initialize player locations
        Vector3[] playerLocations = new[] {new Vector3(-462f,139f,0f),
                                            new Vector3(-87f,139f,0f),
                                            new Vector3(180f,139f,0f),
                                            new Vector3(-356f,-132f,0f),
                                            new Vector3(-87,-132f,0f),
                                            new Vector3(190f,-129f,0f)};      
         
        for(int i = 0; i < playercount; i++) {
            // use Quaternion.identity for no rotation
            Instantiate(players[i], playerLocations[i], Quaternion.identity, canvas.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
