using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour {

    const float Gravity = 9.81f;
    public float gravityScale = 1.0f;

	void Update () {

        Vector3 vector = new Vector3();

        //Unityエディターと実機で処理を分ける
        if (Application.isEditor)
        {
            vector.x = Input.GetAxis("Horizontal");
            vector.z = Input.GetAxis("Vertical");

            //高さ方向の判定はキーのxとする
            if (Input.GetKey("z"))
            {
                vector.y = 1.0f;
            }
            else
            {
                vector.y = -1.0f;
            }
        }
        else
        {
            vector.x = Input.acceleration.x;
            vector.y = Input.acceleration.y;
            vector.z = Input.acceleration.z;
        }

        Physics.gravity = Gravity * vector.normalized * gravityScale;
	}
}
