using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_R_U_D4Path : MonoBehaviour {
    GameObject MainScript;
    StageState stageState;
    public GameObject PseudoPlayer;
    void Start()
    {
        MainScript = GameObject.Find("Main Script");
        stageState = MainScript.GetComponent<StageState>();
        PseudoPlayer = GameObject.Find("Pseudo-player");

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "AIPlayer")
        {

            if (stageState.DownFlag == true)
            {
                PseudoPlayer.SendMessage("LeftMessage");
            }
            else if (stageState.LeftFlag == true)
            {
                PseudoPlayer.SendMessage("DownMessage");
            }
            else if (stageState.RightFlag)
            {
                PseudoPlayer.SendMessage("RightMessage");
            }
            else if (stageState.UpFlag)
            {
                PseudoPlayer.SendMessage("UpMessage");
            }

            Debug.Log("Centorで当たり判定が発生しました。");
        }
    }
}
