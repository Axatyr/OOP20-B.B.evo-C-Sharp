using System;
namespace OOP20.src
{
    public interface IControllerInput
    {
        bool IsMoveLeft();

        bool IsMoveRight();

        void NotifyMoveRight(bool condition);

        void NotifyMoveLeft(bool condition);
    }
}
