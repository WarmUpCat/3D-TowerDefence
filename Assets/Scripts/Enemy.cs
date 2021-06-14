using UnityEngine;
using UnityEngine.AI;


namespace HGK
{
    public class Enemy : MonoBehaviour
    {
        public float speed = 10f;

        private Transform target;
        private int wavepointIndex = 0; //move throu each index to get to END

        public bool isRandomWaypoint = false;

        NavMeshAgent agent;

        void Start()
        {// use the array created in Waypoint
            agent = GetComponent<NavMeshAgent>();
            target = Waypoints.points[0]; //the first waypoint

        }


     
        /// <summary>
        /// if waypoint[waypoint index] is reached then destroy game object by calling EndPath(). Once waypoint is reached set the waypoint back to 0 index. If random pick random waypoints
        /// </summary>
        void Update()
        {//get the direction vector to move to and move in the direction 

            //Vector3 dir = target.position - transform.position;
            //transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

            //if (Vector3.Distance(transform.position, target.position) <= 0.2f)
            //{
            //    GetNextWaypoint();
            //}
            agent.SetDestination(Waypoints.points[wavepointIndex].position);

            float distanceToWaypoint = Vector3.Distance(transform.position,
                                                        Waypoints.points[wavepointIndex].position);

            if (isRandomWaypoint)
            {
                if (distanceToWaypoint < 1f)
                {
                    wavepointIndex = Random.Range(0, Waypoints.points.Length);
                }
            }
            else
            {
                if (distanceToWaypoint < 1f)
                {
                    wavepointIndex++;
                    EndPath();
                }

                if (wavepointIndex >= Waypoints.points.Length-1)
                {
                    wavepointIndex = 0;
                    
                }
            }




        }


        /// <summary>
        /// destroy game object
        /// And lives is minused or lost
        /// </summary>
        void EndPath()
        {
            PlayerStats.Lives--;
            Destroy(gameObject);
        }


        //void GetNextWaypoint()
        //{
        //   if(wavepointIndex >= Waypoints.points.Length -1)
        //    {
        //        Destroy(gameObject);
        //        return;
        //    }

        //    wavepointIndex++;
        //    target = Waypoints.points[wavepointIndex];
        //}


    }

}
