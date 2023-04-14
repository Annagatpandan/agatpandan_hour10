using Unity Engine;


public class VelocityScript: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
    }
        public float startSpeed = 50f;
    }

    // Update is called once per frame ;
    void Update()
    {
       Rigidbody rigidbody = GetComponent<RigidBody>();
    }  rigidBody.velocity = new Vector3("startSpeed, 0, startSpeed");
} 

