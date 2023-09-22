using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Composite : Component
    {
        private List<Component> ChildComponents = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public void AddComponent(Component NewComponent)
        {
            this.ChildComponents.Add(NewComponent);
        }

        public void RemoveComponent(Component RemoveComponent)
        {
            this.ChildComponents.Remove(RemoveComponent);
        }

        public override int GetSalary()
        {
            return this.ChildComponents.Sum(x => x.GetSalary());
        }
    }
}
