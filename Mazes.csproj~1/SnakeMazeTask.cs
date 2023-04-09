namespace Mazes
{
	public static class SnakeMazeTask
	{
        private static void MoveRight(Robot robot, int width)
        {
            for (int i = 0; i < width - 3; i++)
            {
                robot.MoveTo(Direction.Right);
            }
        }
        private static void MoveDown(Robot robot)
        {
            robot.MoveTo(Direction.Down);
            robot.MoveTo(Direction.Down);
        }
        private static void MoveLeft(Robot robot, int width)
        {
            for (int i = 0; i < width - 3; i++)
            {
                robot.MoveTo(Direction.Left);
            }
        }
            public static void MoveOut(Robot robot, int width, int height)
		{
            while (!robot.Finished)
            {
                MoveRight(robot, width);
                MoveDown(robot);
                MoveLeft(robot, width);
                if (!robot.Finished)
                {
                    MoveDown(robot);
                }
            }

        }
	}
}