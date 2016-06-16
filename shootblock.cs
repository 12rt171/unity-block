using UnityEngine;
using System.Collections;
using System;

public class shootblock : MonoBehaviour {
    //フレーム調査用
    int frame;
    //一秒に一回までしか撃てないように制限
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
        n = UnityEngine.Random.value;
        if (n > 0.98)
        {
            if (flag == false)
            {
            Instantiate(shot, position, Quaternion.identity);
            flag = true;
            }
        }
        frame++;
        if (frame == 180)
        {
            flag = false;
            frame = frame % 180;
        }
	}
}
