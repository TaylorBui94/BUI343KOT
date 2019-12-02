using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class initGameBoard : MonoBehaviour
{   
    public GameObject[] players;
    public GameObject[] playerPrefabs;
    public Vector3[] playerLocations;
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
        int playercount = numPlayers.playercount; // grab dropdown player count
            Debug.Log("playercount is " + playercount); // inside check
        // load all player prefabs into player array
        GameObject[] player=Resources.LoadAll("PlayerPrefabs") as GameObject[];
        // uh maybe check if anything is being loaded into player array
        // initialize player locations
        Vector3[] playerLocations = new[] {new Vector3(-354f,125f,0f),
                                            new Vector3(-91f,118f,0f),
                                            new Vector3(177f,120f,0f),
                                            new Vector3(-359f,-132f,0f),
                                            new Vector3(-90f,-132f,0f),
                                            new Vector3(185f,-129f,0f)};      
         
        for(int i = 0; i < playercount; i++) {
            // use Quaternion.identity for no rotation
            Debug.Log("playercount in instantiate is " + playercount); // inside check
            Debug.Log("inside for loop" + i);
            Instantiate(player[i], playerLocations[i], Quaternion.identity);
            Debug.Log("after instantiate " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
