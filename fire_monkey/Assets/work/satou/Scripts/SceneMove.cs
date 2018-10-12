using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{ 
    [SerializeField]
    public SCENES scene;

    [SerializeField]
    SCENES debug;

    //現在のシーンの名前
    string SceneName;

    //カウント
    public float time;

    //階層取得用
    public static int floor;

    //ワープまでの時間
    [SerializeField]
    private float warpTime = 10;

    void Start()
    {
        SceneName = SceneManager.GetActiveScene().name;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        DebugKey();
    }

    void Move()
    {
        //シーン名を取得
        SceneName = SceneManager.GetActiveScene().name;

        if(SceneName == "Clear")
        {
            SceneManage.SceneMove(scene);
        }


        if (SceneName == "GameOver")
        {
            time += Time.deltaTime;

            if (time > warpTime)
            {
                Choose(); 
            }
        }
    }

    void DebugKey()
    {
        //タイトルに戻る
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Title");
        }

        //各シーンの初期位置にワープ
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManage.SceneMove(debug);
        }
    }

    void Choose()
    {
        switch (floor)
        {
            case 0:
                SceneManager.LoadScene("school6");
                break;
            case 1:
                SceneManager.LoadScene("school5");
                break;
            case 2:
                SceneManager.LoadScene("school1");
                break;
            default:
                break;
        }
    }
}
