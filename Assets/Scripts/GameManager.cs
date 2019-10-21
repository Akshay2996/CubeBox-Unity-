using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool GameHasEnded = false;
    public float Restartdelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }
    
    public void EndGame()
    {
        if(GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", Restartdelay);//Restart Game with a Delay
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
