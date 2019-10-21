using UnityEngine;

public class ENDTrigger : MonoBehaviour {

    public GameManager gameManager;
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }


}
