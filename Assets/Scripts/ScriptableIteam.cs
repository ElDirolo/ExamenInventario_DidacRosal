using UnityEngine;

[CreateAssetMenu(fileName = "Nombre del nuevo item", menuName = "Nombre del menu")]

public class ScriptableIteam : ScriptableObject
{
    public string iteamName;
    public Sprite iteamImage;
    public string iteamPrice;
    public float iteamType;
}
