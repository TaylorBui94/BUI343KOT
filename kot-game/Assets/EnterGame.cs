using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class EnterGame : MonoBehaviour
{
    public void loadGameBoard()
    {
        SceneManager.LoadScene("GameBoard");
    } 
}
