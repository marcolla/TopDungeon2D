using UnityEngine;

public class Portal : Collidable
{
    public string[] sceneNames;

    protected override void OnCollide(Collider2D coll)
    {
        if(coll.name == "Player")
        {
            // Save state when changing scene
            GameManager.instance.SaveState(); 
            // Teleport the player
            string sceneName = sceneNames[Random.Range(0,sceneNames.Length)]; // Pick random scene in array
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName); // Since there's only one load scene, no need to import UnityEngine.SceneManagement
        }
    }
}
