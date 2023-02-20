using UnityEngine;

public class GroundSpawner : MonoBehaviour {

    public GameObject GroundTile;
    Vector3 NextSpawnPoint;

    public void SpawnTile ()
    {
       GameObject temp = Instantiate(GroundTile, NextSpawnPoint, Quaternion.identity);
        NextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    
    private void Start() {
        for (int i = 0; i < 20; i++) { // this line sets how many planes spawn when the player reaches a hit box (collider)
            SpawnTile();    

        }
        
    }

}
