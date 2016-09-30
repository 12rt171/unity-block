//チュートリアル1再生

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tutorial1 : MonoBehaviour {
    //チュートリアル文章
    string[] words = new string[12];
    //文章回し用変数
    int i = 0;
    //画像を表示するキャンバス
    GameObject canvas;
    //キャンバスに張り付ける画像
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    public GameObject image7;
    public GameObject image8;
    public GameObject image9;
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
        words[0] = "本作品を手に取って頂き、ありがとうございます";
        words[1] = "このゲームの遊び方などについて説明します";
        words[2] = "自機は右キー左キーで動かすことが出来ます";
        words[3] = "spaceキーを押すとボールが出てきます";
        words[4] = "画面内を動き回るボールを自機に当てて跳ね返します";
        words[5] = "赤いブロックに当てるとブロックが消えます";
        words[6] = "赤いブロックに当てるとブロックが消えます";
        words[7] = "全部のブロックを消すことが出来ればクリアです";
        words[8] = "ボールが一番下の壁に届いてしまうと1ミスとなります";
        words[9] = "残機が0の状態でミスするとゲームオーバーになってしまいます";
        words[10] = "それでは引き続きゲームをお楽しみください";
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
                img = Instantiate(image1, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        if (i == 2)
        {
            if (img == null)
            {
                img = Instantiate(image2, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        if (i == 3)
        {
            if (img == null)
            {
                img = Instantiate(image3, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        if (i == 4)
        {
            if (img == null)
            {
                img = Instantiate(image4, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        if (i == 5)
        {
            if (img == null)
            {
                img = Instantiate(image5, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        if (i == 6)
        {
            if (img == null)
            {
                img = Instantiate(image6, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        if (i == 7)
        {
            if (img == null)
            {
                img = Instantiate(image7, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        if (i == 8)
        {
            if (img == null)
            {
                img = Instantiate(image8, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        if (i == 9)
        {
            if (img == null)
            {
                img = Instantiate(image9, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        //全文表示後自身を削除し本編スタート
        if (i == 11)
        {
            Instantiate(setstage, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(sinkou, new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(this.gameObject);
            Destroy(GameObject.Find("pressanykey(Clone)").gameObject);
        }
	}
}
