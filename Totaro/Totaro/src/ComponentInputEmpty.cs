using System;
namespace Totaro.src
{
    [Serializable]
    public class ComponentInputEmpty : IComponentInput
    {
        public void Update(IGameObject obj, IControllerInput controller)
        {
        }
    }
}
