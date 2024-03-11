using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * this class content all variable data we can change 
 * */

[CreateAssetMenu(menuName = "SDA/Enemy Data")] 
public class EnemyData : ScriptableObject
{
    public float Player_Speed;
    public float Delay;
    public bool AutoAim;
    public float bulte_speed;
    public float enemy_speed;
    public float Force;
    public bool followPlayer;
    public float Life_time;



}
