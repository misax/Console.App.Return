using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Class.Library.Return
{
    public delegate bool Predicate(ref GameObject gameObject);
    public class World
    {
        private GameObject[] gameObjects;

        public World(params GameObject[] gameObjects)
        {
            this.gameObjects = gameObjects;
        }

        public ref GameObject GetReturnRef(Predicate filter)
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                if (filter(ref gameObjects[i]))
                {
                    return ref gameObjects[i];
                }
            }
            throw new ArgumentOutOfRangeException();
        }
        public  GameObject GetReturn(Func<GameObject, bool> filter)
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                if (filter( gameObjects[i]))
                {
                    return  gameObjects[i];
                }
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}
