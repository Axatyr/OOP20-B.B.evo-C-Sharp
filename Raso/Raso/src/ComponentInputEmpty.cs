using System;
namespace Raso.src
{
    [Serializable]
    public class ComponentInputEmpty : IComponentInput
    {
        public void Update(GameObject obj, IControllerInput controller)
        {
        }
    }
}
