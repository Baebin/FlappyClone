using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            timer = 0;
            
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(-2.4f, Random.Range(-1.0f, 5.5f), 0);
            
            Destroy(newpipe, 10.0f);
        }
    }
}
