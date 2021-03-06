﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystems : GameSystemsLibrary {

    protected List<Faction> ActiveTeams;


    public void SceneChange() {
        if (SceneManager.GetActiveScene().name.Contains("Battle"))
        {
            Debug.Log("Battle Scene has loaded");
            GameStart();
        }
        else
        {
            Debug.Log("Battle Scene is not loaded");
        }
    }

    //before gamestart, establish the total number of players and what factions they are
    private void GameStart() {

        if (LevelManager.DM == null) {
            Debug.Log("This is not a conflict zone");
            return;
        }

        //wipes active team if already instanced
        if (ActiveTeams.Count > 0) {
            ActiveTeams.Clear();
        }

        //Spawn the correct factions
        for (int i = 0; i < TeamCount; i++) {
            ActiveTeams.Add(Instantiate(Resources.Load("FactionContainer", typeof(GameObject)), new Vector3(0, 0, 0), Quaternion.identity) as Faction);
        }
        foreach (Faction item in ActiveTeams) {

        }

        //Establish Turn order?

        //Pull Assets for Scene
        print("Colours pulled");
        Gameplay_Colour_Tile_Movment = Resources.Load("Colours/Colour_Tile_Movment", typeof(Material)) as Material;
        Gameplay_Colour_Tile_Attack = Resources.Load("Colours/Colour_Tile_Attack", typeof(Material)) as Material;
        Gameplay_Colour_Tile_Target = Resources.Load("Colours/Colour_Tile_Target", typeof(Material)) as Material;
    }

    public void ResourceCall_Faction(bool isPlayer, int FactionID) {
        if (isPlayer) {

        } else {

        }
    }

    public void Application_Close() {

    }
}