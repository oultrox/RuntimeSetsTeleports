using System.Collections.Generic;
using UnityEngine;

namespace ScriptableData.RuntimeSet
{
    public abstract class RuntimeSet<T> : ScriptableObject
    {
        private List<T> items = new List<T>();

        public List<T> Items { get => items; set => items = value; }

        public void Initialize()
        {
            items.Clear();
        }

        public T GetIemIndex(int index)
        {
            return items[index];
        }

        public void AddToList(T thingToAdd)
        {
            if (items.Contains(thingToAdd)) return;
            items.Add(thingToAdd);
        }

        public void RemoveFromList(T thingToRemove)
        {
            if (items.Contains(thingToRemove) == false) return;
            items.Remove(thingToRemove);
        }
    }

}

