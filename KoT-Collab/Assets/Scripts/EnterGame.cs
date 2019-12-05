using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterGame : MonoBehaviour
{
    public void loadGameBoard()
    {
        SceneManager.LoadScene("GameBoard");
    } 
}
