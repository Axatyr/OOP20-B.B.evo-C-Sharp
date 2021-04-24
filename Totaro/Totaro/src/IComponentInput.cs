using System;
namespace Totaro.src
{
    public interface IComponentInput
    {
        void Update(IGameObject obj, IControllerInput controller);
    }
}
