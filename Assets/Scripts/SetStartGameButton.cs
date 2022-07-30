using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartGameButton : MonoBehaviour
{
    public void CallGameStarted()
    {
        LevelController.Instance.SetGameStartedStatus(true);
        LevelController.Instance.SetGameOverStatus(false);
    }
}
