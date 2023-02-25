using UnityEngine;

namespace ScriptableData.RuntimeSet
{
    public class GameObjectRuntimeSetSubscriber : MonoBehaviour
    {
        [SerializeField] private GameObjectRuntimeSet gameObjectRuntimeSet;

        private void OnEnable()
        {
            gameObjectRuntimeSet.AddToList(this.gameObject);
        }

        private void OnDisable()
        {
            gameObjectRuntimeSet.RemoveFromList(this.gameObject);
        }


    }
}
