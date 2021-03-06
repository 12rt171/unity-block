﻿//ステージ2のセット

using UnityEngine;
using System.Collections;

public class setstage2 : MonoBehaviour {
    //blockのプレハブを作成
    public GameObject block;
    //blockのカウント用
    GameObject obj;
    //sinkou.csにステージ2の情報を書き込むため
    sinkou stage2;
    //初期残機
    int zanki;
    //位置座標用
    new Vector3 position = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
        //残機を書き込むための準備
        stage2 = GameObject.Find("sinkou(Clone)").GetComponent<sinkou>();
        //残機設定
        zanki = 10;
        stage2.zanki = zanki;
        //ブロックの配置
        //通常タイプ
        for (int x = 13; x >= -13; x -= 2)
        {
            for (int z = 7; z >= 0; z -= 2)
            {
                position = new Vector3(x, position.y, z);
                obj = (GameObject)Instantiate(block, position, Quaternion.identity);
                obj.transform.parent = transform;
            }
        }
        for (int x = 12; x >= -12; x -= 2)
        {
            for (int z = 6; z >= 0; z -= 2)
            {
                position = new Vector3(x, position.y, z);
                obj = (GameObject)Instantiate(block, position, Quaternion.identity);
                obj.transform.parent = transform;
            }
        }
        //ゲームオーバー時のリトライ用にこのシーンを設定
        GameObject.Find("gameover").GetComponent<gameover>().retry = "scene2";
        //ゲームクリア時のリトライ用にこのシーンを設定
        GameObject.Find("gameclear").GetComponent<gameclear>().retry = "scene2";
	}
	
	// Update is called once per frame
	void Update () {
        //残りブロックのカウント
        stage2.count = transform.GetChildCount();
	}
}
