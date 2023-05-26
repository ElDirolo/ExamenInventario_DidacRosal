using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioController : MonoBehaviour
{
    public static InventarioController Instance;

    public ScriptableIteam[] weapons;
    public Image[] weaponsImage;    
    public Text[] weaponsName;
    public Text[] weaponsPrice;

    public ScriptableIteam[] armors;
    public Image[] armorsImage;    
    public Text[] armorsName;
    public Text[] armorsPrice;

    void Awake()
    {
        Instance = this;
    }

    public void AddIteam(ScriptableIteam weapon)
    {
        for( int i = 0; i < weapons.Length; i++)
        {
            if(weapon.iteamType == 0)
            {
                if(weapons[i] == null)
                {
                    weapons[i] = weapon;
                    weaponsImage[i].sprite = weapon.iteamImage;
                    weaponsName[i].text = weapon.iteamName;
                    weaponsPrice[i].text = "Vale: " + weapon.iteamPrice;
                    return;
                }
            }

            if(weapon.iteamType == 1)
            {
                if(armors[i] == null)
                {
                    armors[i] = weapon;
                    armorsImage[i].sprite = weapon.iteamImage;
                    armorsName[i].text = weapon.iteamName;
                    armorsPrice[i].text = "Vale: " + weapon.iteamPrice;
                    return;
                }
            }            
        }

    }
}
