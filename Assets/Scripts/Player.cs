using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [System.Serializable]
    public class PlayerStats
    {
        public int LivingSpacePoint = 100;


    }

    public PlayerStats playerStats = new PlayerStats();

    public int fallBoundary = -20;

    void Update()
    {
        if(transform.position.y <= fallBoundary)
        {
            LooseLivingSpace(9999999);
        }
    }

    public void LooseLivingSpace(int damage)
        {

        playerStats.LivingSpacePoint -= damage;

        if(playerStats.LivingSpacePoint <= 0)
        {
            Debug.Log("Player Killlllleddd");
            GameMaster.KillPlayer(this);
            
        }

        }


        
    

}
