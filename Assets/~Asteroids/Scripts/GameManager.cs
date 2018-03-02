using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace GoneHome
{

    public class GameManager : MonoBehaviour
    {

        public void NextLevel()
        {
            //Get active scene
            Scene currentScene = SceneManager.GetActiveScene();
            //Load the next scene up using buildIndex
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }

        public void ResetLevel()
        {

            // Grab all enemies and reset them
            Enemy[] enemies = FindObjectOfType<Enemy>();
            // Loop through all enemies and reset them
            for (int i = 0; i < enemies.Length; i++)
            {
                // reset
                enemies[i].Reset();
            }

            //Grab the player and reset it
            Player player = FindObjectOfType<Player>();
            player.Reset();
        }

    }
}