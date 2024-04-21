using SnakeGame.ViewModels;

namespace SnakeGame.Models
{
    abstract class SpeedState
    {
        public abstract void ChangeSpeedState(MainWindowVM context);
    }

    class NormalSpeedState : SpeedState
    {
        public override void ChangeSpeedState(MainWindowVM context)
        {
            context.Speed = (int)(context.Speed * 0.8);
            context.SpeedState = new HighSpeedState();            
        }
    }
    class SlowSpeedState : SpeedState
    {
        public override void ChangeSpeedState(MainWindowVM context)
        {
            context.Speed = (int)(context.Speed * 0.3);
            context.SpeedState = new NormalSpeedState();
        }
    }
    class HighSpeedState : SpeedState
    {
        public override void ChangeSpeedState(MainWindowVM context)
        {
            context.Speed = context.Speed * 2;
            context.SpeedState = new SlowSpeedState();            
        }
    }
}
