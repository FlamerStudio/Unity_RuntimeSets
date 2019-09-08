using Flamers.RuntimeSets;
using System.Collections.Generic;
using UnityEngine;

namespace Flamers
{
    [CreateAssetMenu(menuName = "RuntimeSets/Lists/CubeBehavior")]
    public class RuntimeCubeBehaviorList : RuntimeList<CubeBehavior>
    {
        public List<CubeBehavior> GetItemsInArea(Vector3 point, float distance)
        {
            List<CubeBehavior> cubes = new List<CubeBehavior>();
            foreach(CubeBehavior c in Items)
            {
                Vector3 cubePos = c.transform.position;
                if(point.x - distance < cubePos.x && cubePos.x < point.x + distance 
                    && point.y - distance < cubePos.y && cubePos.y < point.y + distance
                    && point.z - distance < cubePos.z && cubePos.z < point.z + distance)
                {
                    cubes.Add(c);
                }
            }

            return cubes;
        }
    }
}
