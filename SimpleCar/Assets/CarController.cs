﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    float speed = 0;
    Vector2 startPos;

	
	void Start () {
	}
	
	void Update () {

        // スワイプの長さを求める(追加)
        if(Input.GetMouseButtonDown(0)){     　 
            // マウスをクリックした座標 
            this.startPos = Input.mousePosition;     
        } else if (Input.GetMouseButtonUp(0))
        {
            // マウスを離した座標
            Vector2 endPos = Input.mousePosition;
            float swipeLengh = endPos.x = this.startPos.x;

            // スワイプの長さを初速度に変換する
            this.speed = swipeLengh / 500.0f;
        }

        transform.Translate(this.speed, 0, 0);  // 移動
        this.speed *= 0.98f;                    // 減速
	}
}
