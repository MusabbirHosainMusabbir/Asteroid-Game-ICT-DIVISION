
using UnityEngine;

public class invoke : MonoBehaviour
{
    public GameObject panal;
    public GameObject terget;

   // public GameObject healthBer;
    void Start()
    {
       // Invoke("panal", 2);

        InvokeRepeating("SpawnObject", 70, 70);
    }

    // Update is called once per frame
    void Update()
    {
        // Instantiate(terget, new Vector3(0, 0.001f, 0), Quaternion.identity);
    }
    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(terget, new Vector3(x, 2, z), transform.rotation);
        panal.SetActive(true);

     //   healthBer.SetActive(true);
    }
 
}
