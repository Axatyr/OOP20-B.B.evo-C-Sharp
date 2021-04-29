using System;
namespace Raso.src
{
    public interface IComponentInput
    {
        void Update(GameObject obj, IControllerInput controller);
    }
}
