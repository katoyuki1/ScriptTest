using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53;

	public void Magic() {
		if (mp < 5) {
			Debug.Log ("MPが足りないため魔法が使えない");
		} else {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		}
	}

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

}

public class Test : MonoBehaviour {

	void Start () {
		// 課題：配列を宣言して出力しましょう
		Debug.Log("-----課題-----");
		int[] array = {10, 20, 30, 40, 50};
		Debug.Log("順番に出力");
		for(int i = 0; i < array.Length; i++) {
			Debug.Log (array[i]);
		}
		Debug.Log("逆順に出力");
		for(int i = array.Length - 1; i >= 0; i--) {
			Debug.Log (array[i]);
		}

		// 発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
		Debug.Log("-----発展課題-----");
		Boss boss = new Boss();
		for(int i = 1; i <= 11; i++) {
			boss.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
