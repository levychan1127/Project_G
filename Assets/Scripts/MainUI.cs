using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GlobalFunc
{
    //通用的UI切换方法
    public static GameObject ChangeUI(GameObject gameObject, string targetUIName)
    {
        GameObject root = GameObject.Find("Canvas");
        if (root != null)
        {
            GameObject targetUI = root.transform.Find(targetUIName).gameObject;
            if (targetUI != null)
            {
                gameObject.SetActive(false);
                targetUI.SetActive(true);
                return targetUI;
            }
        } 
        return null; 
    }
}

public class MainUI : MonoBehaviour {

    // Use this for initialization
    void Start () {
        //LoadClick();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LevelUpClick()
    {
        PlayerAttribute.LevelUpCheck();
    }

    public void SaveClick()
    {
        GameDataManager gameDataManager = gameObject.AddComponent<GameDataManager>();
        gameDataManager.Save();
    }

    public void LoadClick()
    {
        GameDataManager gameDataManager = gameObject.AddComponent<GameDataManager>();
        gameDataManager.Load();
        PlayerAttribute.level = gameDataManager.gameData.PlayerLevel;
        PlayerAttribute.RefreshAttribute();
    }

    public void OpenAttributeUI()
    {
        GlobalFunc.ChangeUI(gameObject, "AttributeUI");
    }
}
