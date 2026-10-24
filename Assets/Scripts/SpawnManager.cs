using UnityEngine;
using UnityEngine.InputSystem;
public class SpawnManager : MonoBehaviour
{
    public GameObject [] animalPrefabs;
    public InputAction spawnAction;
    private float spawnRangeX = 20;
    private float spawnRangeY = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",2,1.5f);
        spawnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomAnimal(){
       int animalIndex = Random.Range(0,animalPrefabs.Length);
            Vector3 spawnPos =new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnRangeY);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); 
    }
}
