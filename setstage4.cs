//ステージ4のセット

using UnityEngine;
using System.Collections;

public class setstage4 : MonoBehaviour {
    //blockのプレハブを作成
    public GameObject block;
    public GameObject shootblock;
    //blockのカウント用
    GameObject obj;
    //sinkou.csにステージ4の情報を書き込むため
    sinkou stage4;
    //初期残機
    int zanki;
    //位置座標用
    new Vector3 position = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {

        stage4 = GameObject.Find("Text").GetComponent<sinkou>();
        //残機設定
        zanki = 10;
        stage4.zanki = zanki;
        //ブロックの配置
        for (int x = 12;  x>= -12; x -= 6)
        {
            position = new Vector3(x, position.y, 7);
            obj = (GameObject)Instantiate(shootblock, position, Quaternion.identity);
            obj.transform.parent = transform;
            obj.GetComponent<shootblock>().seed = x * 10;
        }
        for (int x = 13; x >= -13; x -= 2)
        {
            for (int z = 3; z >= 0; z -= 2)
            {
                position = new Vector3(x, position.y, z);
                obj = (GameObject)Instantiate(block, position, Quaternion.identity);
                obj.transform.parent = transform;
            }
        }
        for (int x = 12; x >= -12; x -= 2)
        {
            for (int z = 4; z >= 0; z -= 2)
            {
                position = new Vector3(x, position.y, z);
                obj = (GameObject)Instantiate(block, position, Quaternion.identity);
                obj.transform.parent = transform;
            }
        }
        GameObject.Find("gameover").GetComponent<gameover>().retry = "scene4";
        GameObject.Find("gameclear").GetComponent<gameclear>().retry = "scene4";
	}
	
	// Update is called once per frame
	void Update () {
        //残りブロックのカウント
        stage4.count = transform.GetChildCount();
	}
}
