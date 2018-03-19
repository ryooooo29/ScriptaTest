using System.Collections;
using UnityEngine;

public class Test : MonoBehaviour {

	//Use this for initialization
	void Start(){
		//配列を初期化する
		int[] array = {10,20,30,40,50};
		 
		//配列の要素を表示する
		for (int i = 0; i < array.Length; i++){
			Debug.Log (array [i]);
				}

		//各要素を逆順で表示する
		for(int i2 = 4; i2 >= 0; i2--){
			Debug.Log (array [i2]);
		
		}
	}



	// Update is called once pwe frame
	void Update(){
	}
}
