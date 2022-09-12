using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeFinishTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<KnifeController>())
        {
            //If there is no soap piece when knife arrive the finish, the level will be completed, otherwise set position of knife to next layer of soap.
            gameManager.SetPositionsToKnife();
        }
    }
}
