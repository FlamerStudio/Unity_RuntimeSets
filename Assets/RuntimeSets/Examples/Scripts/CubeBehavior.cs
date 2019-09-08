using UnityEngine;

namespace Flamers
{
    public class CubeBehavior : MonoBehaviour
    {
        [SerializeField]
        private RuntimeCubeBehaviorList enabledCubeList;

        private void OnEnable()
        {
            enabledCubeList.Add(this);
        }

        private void OnDisable()
        {
            enabledCubeList.Remove(this);
        }
    }
}