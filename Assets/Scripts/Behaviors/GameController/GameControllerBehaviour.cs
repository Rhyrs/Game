﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GameControllerBehaviour : MonoBehaviour 
{
    public List<ActorBehavior> playerTeam = new List<ActorBehavior>();
    public List<ActorBehavior> enemyTeam = new List<ActorBehavior>();
    public List<ActorBehavior> nuetrals = new List<ActorBehavior>();
    public int playerTeamTotal;
    public int enemyTeamTotal;
    public int nuetralTotal;
    

    public enum UnitSide
    {
        player,
        enemy, 
        nuetral,
        NUMBER_OF_SIDES
    }

    public GameControllerBehaviour.UnitSide currentTurn = UnitSide.player;

	// Use this for initialization
	void Start () 
    {
        for (int index = 0; index < playerTeam.Count; index++)
            playerTeam[index].theSide = GameControllerBehaviour.UnitSide.player;

        for (int index = 0; index < enemyTeam.Count; index++)
            enemyTeam[index].theSide = GameControllerBehaviour.UnitSide.enemy;

        for (int index = 0; index < nuetrals.Count; index++)
            nuetrals[index].theSide = GameControllerBehaviour.UnitSide.nuetral;

        playerTeamTotal = playerTeam.Count;
        enemyTeamTotal = enemyTeam.Count;
        nuetralTotal = nuetrals.Count;
	}

    // Update is called once per frame
    void Update()
    {
        if(enemyTeamTotal == 0)
        {
            Application.LoadLevel("PlayerWins");
        }

        if (playerTeamTotal == 0)
        {
            Application.LoadLevel("PlayerLosses");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int index = 0; index < playerTeam.Count; index++)
                playerTeam[index].actorHasMovedThisTurn = false;

            for (int index = 0; index < enemyTeam.Count; index++)
                enemyTeam[index].actorHasMovedThisTurn = false;

            for (int index = 0; index < nuetrals.Count; index++)
                nuetrals[index].actorHasMovedThisTurn = false;

            if (currentTurn == UnitSide.player)
                currentTurn = UnitSide.enemy;
            else
                currentTurn = UnitSide.player;
        }
	}
}
