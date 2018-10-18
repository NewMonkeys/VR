using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "fireWall")
        {
            Debug.Log("ジュージュー");
            Destroy(other.gameObject);
        }
    }

    /*
    private void OnParticleTrigger(GameObject other)
    {
        if (other.tag == "fireWall")
        {
            Debug.Log("ジュージュー");
            Destroy(other.gameObject);
        }
    }*/
}
