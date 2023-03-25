using System.ComponentModel;

namespace Decorator.Domain
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public class Decorator : Component
    {
        protected Component component;
        public void SetComponent(Component component)
        {
            this.component = component;
        }

    }
}
