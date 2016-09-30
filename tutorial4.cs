//チュートリアル4再生

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tutorial4 : MonoBehaviour {
    //チュートリアル文章
    string[] words = new string[6];
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
        words[0] = "このステージでは新しく白いブロックが出てきます";
        words[1] = "白いブロックはランダムに緑色の弾を撃ってきます";
        words[2] = "自機がこの弾に当たってしまうと1ミスとなります";
        words[3] = "ボールに当たった場合は何ともありません";
        words[4] = "それでは頑張って下さい！";

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
        if (i == 4)
        {
            if (img == null)
            {
                img = Instantiate(image5, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                img.transform.SetParent(canvas.transform, false);
            }
        }
        //全文表示後自身を削除し本編スタート
        if (i == 5)
        {
            Instantiate(setstage, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(sinkou, new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(this.gameObject);
            Destroy(GameObject.Find("pressanykey(Clone)").gameObject);
        }
	}
}
