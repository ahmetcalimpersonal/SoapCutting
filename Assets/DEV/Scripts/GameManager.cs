using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<Transform> firstPositions;
    public List<Transform> targetPositions;
    public KnifeController knifeController;
    public int positionIndex = -1;
    public GameObject levelCompletePanel;
    private void Start()
    {
        SetPositionsToKnife();
    }
    public void SetPositionsToKnife()
    {
        if (positionIndex < 2)
        {
            //Change the target moving position of knife and first position that will move back
            positionIndex++;

            knifeController.currentTargetPosition = targetPositions[positionIndex];

            knifeController.currentFirstPosition = firstPositions[positionIndex];

            knifeController.moveToFirstPosition = true;
            knifeController.allowControl = false;
        }
        else
        {
            //All layers cleared
            Debug.Log("Finished!");

            knifeController.allowControl = false;
            CompleteLevel();
        }
    }
    public void CompleteLevel()
    {
        levelCompletePanel.SetActive(true);
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
