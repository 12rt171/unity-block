//玉の挙動

using UnityEngine;
using System.Collections;

public class sphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //初速の決定
        this.GetComponent<Rigidbody>().velocity = new Vector3(0,0,10);
	}
	
	// Update is called once per frame
	void Update () {
        //速度制限&最低速度保障
        if (this.GetComponent<Rigidbody>().velocity.x > 10)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(10, this.GetComponent<Rigidbody>().velocity.y, this.GetComponent<Rigidbody>().velocity.z);
        }
        if (this.GetComponent<Rigidbody>().velocity.x < -10)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(-10, this.GetComponent<Rigidbody>().velocity.y, this.GetComponent<Rigidbody>().velocity.z);
        }
        if (this.GetComponent<Rigidbody>().velocity.y > 10)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x,10, this.GetComponent<Rigidbody>().velocity.z);
        }
        if (this.GetComponent<Rigidbody>().velocity.y < -10)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x,-10, this.GetComponent<Rigidbody>().velocity.z);
        }
        if (this.GetComponent<Rigidbody>().velocity.z > 10)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x, this.GetComponent<Rigidbody>().velocity.y,10);
        }
        if (this.GetComponent<Rigidbody>().velocity.z < -10)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x, this.GetComponent<Rigidbody>().velocity.y,-10);
        }
        if (this.GetComponent<Rigidbody>().velocity.x > 0 && 3 > this.GetComponent<Rigidbody>().velocity.x)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(3, this.GetComponent<Rigidbody>().velocity.y, this.GetComponent<Rigidbody>().velocity.z);
        }
        if (this.GetComponent<Rigidbody>().velocity.x < 0 && -3 < this.GetComponent<Rigidbody>().velocity.x)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(-3, this.GetComponent<Rigidbody>().velocity.y, this.GetComponent<Rigidbody>().velocity.z);
        }
        if (this.GetComponent<Rigidbody>().velocity.y > 0 && 3 > this.GetComponent<Rigidbody>().velocity.y)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x, 3, this.GetComponent<Rigidbody>().velocity.z);
        }
        if (this.GetComponent<Rigidbody>().velocity.y < 0 && -3 < this.GetComponent<Rigidbody>().velocity.y)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x, -3, this.GetComponent<Rigidbody>().velocity.z);
        }
        if (this.GetComponent<Rigidbody>().velocity.z > 0 && 3 > this.GetComponent<Rigidbody>().velocity.z)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x, this.GetComponent<Rigidbody>().velocity.y, 3);
        }
        if (this.GetComponent<Rigidbody>().velocity.z < 0 && -3 < this.GetComponent<Rigidbody>().velocity.z)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x, this.GetComponent<Rigidbody>().velocity.y, -3);
        }       
	}

    //物にぶつかった時の処理
    void OnCollisionEnter(Collision other)
    {
        //ぶつかったものがブロックだった場合相手ブロックを壊す
        if (other.gameObject.CompareTag("block"))
        {
            Destroy(other.gameObject);
        }
        //ぶつかったものが下の壁だった場合自滅&残機を減らす
        if (other.gameObject.CompareTag("wall"))
        {
            Destroy(this.gameObject);
            GameObject.Find("sinkou(Clone)").GetComponent<sinkou>().zanki -= 1;
        }
    }
}
