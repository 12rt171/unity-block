//弾幕を撃ってくるブロックの挙動

using UnityEngine;
using System.Collections;
using System;

public class shootblock : MonoBehaviour {
    //フレーム調査用
    int frame;
    //3秒に1回までしか撃てないように制限
    bool flag;
    //乱数のシード用
    public int seed;
    //乱数回し用
    public float n;
    //弾
    public GameObject shot;
    //位置用
    Vector3 position;

	// Use this for initialization
	void Start () {
        //初期フレーム0
        frame = 0;
        //撃った判定
        flag = false;
        //乱数のシード
        UnityEngine.Random.seed = seed;
        position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 1);
	}
	
	// Update is called once per frame
	void Update () {
        //乱数を生成
        n = UnityEngine.Random.value;
        //乱数が規定値以上なら弾幕を生成。規定値を大きくするほど弾幕を張る可能性が低くなる。
        if (n > 0.98)
        {
            //3秒に1回までに制限するため
            if (flag == false)
            {
               Instantiate(shot, position, Quaternion.identity);
               flag = true;
            }
        }
        //フレーム回し
        frame++;
        //3秒に1回リセット
        if (frame == 180)
        {
            flag = false;
            frame = frame % 180;
        }
	}
}
