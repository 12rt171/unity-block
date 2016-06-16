using UnityEngine;
using System.Collections;

public class shot : MonoBehaviour {
    GameObject sphere;
	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -3);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("me"))
        {
            Destroy(this.gameObject);
            sphere = GameObject.Find("Sphere(Clone)");
            if (sphere != null)
            {
                Destroy(sphere);
                GameObject.Find("Text").GetComponent<sinkou>().zanki -= 1;
            }

        }
        if (other.gameObject.CompareTag("wall"))
        {
            Destroy(this.gameObject);
        }
    }
}