﻿//チュートリアル3再生

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tutorial3 : MonoBehaviour {
    //チュートリアル文章
    string[] words = new string[5];
    //文章回し用変数
    int i = 0;
    //画像を表示するキャンバス
    GameObject canvas;
    //キャンバスに張り付ける画像
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    //画像の一時保存用変数
    GameObject img;
    //チュートリアル終了後本編に移行
    public GameObject setstage;
    public GameObject sinkou;

	// Use this for initialization
	void Start () {
        //画像を張り付けるキャンバスの取得
        canvas = GameObject.Find("Canvas 1");
        //チュートリアル文章
        words[0] = "今回のステージから新しくギミックが登場します";
        words[1] = "今回のステージでは破壊不能なフェンスが行く手を阻みます";
        words[2] = "フェンスとフェンスの合間をすり抜けて奥のブロックを破壊しましょう";
        words[3] = "それでは、頑張って下さい！";
	}
	
	// Update is called once per frame
	void Update () {
        //何かキーが押されたら次の文へ
        if (Input.anyKeyDown)
        {
            i++;
            Destroy(img);
        }
        //文章表示
        this.gameObject.GetComponent<Text>().text = words[i];
        if (i == 0)
        {
            if (img == null)
            {
                img = Instantiate(image1, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        } 
        if (i == 1)
        {
            if (img == null)
            {
                img = Instantiate(image2, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        if (i == 2)
        {
            if (img == null)
            {
                img = Instantiate(image3, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        if (i == 3)
        {
            if (img == null)
            {
                img = Instantiate(image4, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        //全文表示後自身を削除し本編スタート
        if (i == 4)
        {
            Instantiate(setstage, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(sinkou, new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(this.gameObject);
            Destroy(GameObject.Find("pressanykey(Clone)").gameObject);
        }
	}
}
