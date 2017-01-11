using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//配列の初期化
		int[] points = {10,20,30,40,50};

		// 配列の要素数のぶんだけ処理を繰り返す
		for (int i = 0; i < points.Length; i++) {
				// 配列の要素を表示する
				Debug.Log (points [i]);
			}

		// 配列の要素をすべて逆から表示する
		for (int b = 4; b >= 0; b--) {
			Debug.Log (points [b]);
		}
			
	}

	// Update is called once per frame
	void Update () {

	}
}
