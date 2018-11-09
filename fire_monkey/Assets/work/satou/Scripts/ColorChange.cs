using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    GameObject color;

    jp.gulti.ColorBlind.ColorBlindnessSimulator cbs;

    //0でオフ 1でP型 2でD型
    public int trg = 0;


	// Use this for initialization
	void Start () {
        Init();
	}
	
	// Update is called once per frame
	void Update () {

        Change();

	}

    void Init() {
        color = GameObject.Find("Camera (eye)");
        cbs = color.GetComponent<jp.gulti.ColorBlind.ColorBlindnessSimulator>();
    }

    void Change() {

        var trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);

        #region VRモードで使う
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu)) {
            Debug.Log("メニューボタンをクリックした");

            if(trg == 0) {
                trg = 1;
            }else

            if(trg == 1) {
                trg = 2;
            }else

            if(trg == 2) {
                trg = 0;
            }

            switch (trg) {
                case 0:
                cbs.enabled = false;
                break;

                case 1:
                cbs.enabled = true;
                break;

                case 2:
                cbs.enabled = true;
                break;

                default:
                break;
            }
        }
        #endregion

        #region デバッグで使った

        //色弱モードスイッチ
        if (Input.GetKeyDown(KeyCode.C)) {

            trg++;
            if(trg > 2) {
                trg = 0;
            }

            switch (trg) {
                case 0:
                GetComponent<jp.gulti.ColorBlind.ColorBlindnessSimulator>().enabled = false;
                break;

                case 1:
                GetComponent<jp.gulti.ColorBlind.ColorBlindnessSimulator>().enabled = true;
                break;

                case 2:
                GetComponent<jp.gulti.ColorBlind.ColorBlindnessSimulator>().enabled = true;
                break;

                default:
                break;
            }
        }
        #endregion
    }
}
