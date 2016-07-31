using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AttributeUI : MonoBehaviour {
    public Text playerName;
    public Text Level;
    public Text Atk;
    public Text Hp;

	// Use this for initialization
	void Start () {
       
	}
	
    void OnEnable()
    {
        playerName.text = "名称： " + PlayerAttribute.playerName;
        Level.text = "等级： " + PlayerAttribute.level;
        Atk.text = "攻击： " + PlayerAttribute.atk;
        Hp.text = "生命： " + PlayerAttribute.hp;
    }

	// Update is called once per frame
	void Update () {
	
	}

    public void ReturnMainUI()
    {
        GlobalFunc.ChangeUI(gameObject, "MainUI");
    }
}
