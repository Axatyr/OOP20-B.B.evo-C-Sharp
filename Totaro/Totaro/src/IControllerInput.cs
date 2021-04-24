using System;
namespace Totaro.src
{
    public interface IControllerInput
    {
        bool IsMoveLeft();

        bool IsMoveRight();

        void NotifyMoveRight(bool condition);

        void NotifyMoveLeft(bool condition);
    }
}
