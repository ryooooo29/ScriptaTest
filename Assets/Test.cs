using System.Collections;
using UnityEngine;

public class Boss{
	private int hp = 100; //体力
	private int power = 25; //攻撃力
	public  int mp = 53;

	//攻撃用の関数
	public void  Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}
	//防御用の関数
	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		//残りのhpを減らす
		this.hp -= damage;
	}
	//Magic関数
	public void Magic(int magic){
		//魔法攻撃をする
		//残りのmpを減らす
		for (int i = 0; i < 10; i++) {
			this.mp -= magic;
			if (this.mp >= 5) {
				Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
			} else {
				Debug.Log ("MPが足りないため魔法が使えない。");
			}
		}
	}
}




public class Test : MonoBehaviour{

	void Start(){
		//Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		//攻撃用の関数を呼び出す
		lastboss.Attack();
		//防御用の関数を呼び出す
		lastboss.Defence(3);
		// 魔法攻撃の関数を呼び出す
		lastboss.Magic(5);

	}

	// Update is called once pwe frame
	void Update(){
	}
}
