﻿using UnityEngine;
using System.Collections;

public class GuiScore : MonoBehaviour {

    // GUIの表示
    [ExecuteInEditMode()]

    private int drawScore = 0;

	void Start () {
	
	}
	
	void Update () {

        // スコアの更新
        //PlayerMove player = GameObject.Find("player").GetComponent<PlayerMove>();
        //score = player.GetStatus().Score;
        drawScore = GameObject.Find("player").GetComponent<BaseCharacterController>().score;

        // 描画する
        this.guiText.text = "Score_" + drawScore;
	
	}
}
