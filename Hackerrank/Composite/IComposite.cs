using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.Composites
{
    public interface IComponent
    {
        int GetSize();
    }

    public interface IComposite : IComponent
    {
        void Add<T>(T composite) where T : IComponent;

        void Remove<T>(T composite) where T : IComponent;
    }

    public class Component : IComponent
    {
        public int GetSize()
        {
            return 1;
        }
    }

    public class Composite : IComposite
    {
        private List<IComponent> composites = new List<IComponent>();
        public void Add<T>(T composite) where T : IComponent
        {
            composites.Add(composite);
        }

        public int GetSize()
        {
            return composites.Select(x => x.GetSize()).Aggregate((x, y) => x + y);
        }

        public void Remove<T>(T composite) where T : IComponent
        {
            composites.Add(composite);
        }
    }
}