//namespace Mazes
//{
//    public static class EmptyMazeTask
//    {
//        public static void MoveOut(Robot robot, int width, int height)
//        {
//            var i = robot.X;
//            var j = robot.Y;
//            while (!robot.Finished)
//            {
//                if (i < width - 2)
//                {
//                    robot.MoveTo(Direction.Right);
//                    i++;
//                }
//                if (j < height - 2)
//                {
//                    robot.MoveTo(Direction.Down);
//                    j++;
//                }

//            }
//        }
//    }
//}

//namespace Mazes
//{
//    public static class EmptyMazeTask
//    {
//        public static void MoveOut(Robot robot, int width, int height)
//        {
//            for (i = 0; i <= width; i++)
//            {

//                if (robot.X <= width - 2)
//                {
//                    robot.MoveTo(Direction.Right);
//                }
//            }
//            for (j = 0; j <= height; j++)
//            {
//                if (robot.Y <= height - 2)
//                {
//                    robot.MoveTo(Direction.Down);

//                }
//            }
//        }
//    }
//}

//namespace Mazes
//{
//    public static class EmptyMazeTask
//    {
//        public static void MoveOut(Robot robot, int width, int height)
//        {
//            for (int i = robot.X; i <= width - 3; i++)
//            {

//                robot.MoveTo(Direction.Right);
//            }

//            for (int j = robot.Y; j <= height - 3; j++)
//            {
//                robot.MoveTo(Direction.Down);

//            }

//        }
//    }
//}

namespace Mazes
{
    public static class EmptyMazeTask
    {
        public static void MoveRight(Robot robot, int width)
        {
            for (int i = robot.X; i <= width - 3; i++)
            {

                robot.MoveTo(Direction.Right);
            }
        }
        public static void MoveDown(Robot robot, int height)
        {
            for (int j = robot.Y; j <= height - 3; j++)
            {
                robot.MoveTo(Direction.Down);

            }
        }
        public static void MoveOut(Robot robot, int width, int height)
        {
            MoveRight(robot, width);
            MoveDown(robot,height);
            

        }
    }
}