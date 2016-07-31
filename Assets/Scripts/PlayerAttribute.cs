using UnityEngine;
using System.Collections;

public class PlayerAttribute : MonoBehaviour{

    public static string playerName = "次西瓜的喵";
    public static int level = 1;
    public static long atk = level*10;
    public static long hp = level*100;
    public static long exp = 0;
    private static long[] expLimit = {
        5,
        10,
        15,
        20,
        25,
        50,
        60,
        70,
        80,
        100                        
    };

    public static void RefreshAttribute()
    {
        atk = level * 10;
        hp = level * 100;
    }

    public static void LevelUpCheck()
    {
        if (exp > expLimit[level - 1])
        {
            exp = 0;
            level++;
            RefreshAttribute();
        }
        return;
    }

    public static void GetExp()
    {

    }

}
