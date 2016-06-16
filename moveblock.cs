//自機の挙動

using UnityEngine;
using System.Collections;

public class moveblock : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () {
        //位置と角度の固定
        this.transform.position = new Vector3(this.transform.position.x, 0, -8);
        this.transform.rotation = new Quaternion(0,0,0,0);

        //左右への移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.GetComponent<Rigidbody>().velocity.x <= 15)
            {
                this.GetComponent<Rigidbody>().velocity += new Vector3(1, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.GetComponent<Rigidbody>().velocity.x >= -15)
            {
                this.GetComponent<Rigidbody>().velocity -= new Vector3(1, 0, 0);
            }
        }
        //減速&端数処理
        else
        {
            if (this.GetComponent<Rigidbody>().velocity.x >= 1)
            {
                this.GetComponent<Rigidbody>().velocity -= new Vector3(1, 0, 0);
            }
            if (this.GetComponent<Rigidbody>().velocity.x <= -1)
            {
                this.GetComponent<Rigidbody>().velocity += new Vector3(1, 0, 0);
            }
            this.GetComponent<Rigidbody>().velocity = new Vector3((int)this.GetComponent<Rigidbody>().velocity.x, 0, 0);
        }
        sphere = GameObject.Find("Sphere(Clone)");
      
	}
}
