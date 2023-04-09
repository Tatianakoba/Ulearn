using System.Security.Cryptography.X509Certificates;

namespace Mazes
{
	public static class DiagonalMazeTask
    {        
        public static void MoveOut(Robot robot, int width, int height)
		{   
            while (!robot.Finished)
            {
                if (width > height)
                {
                    for (int i = 0; i < (width - 2) / (height - 2); i++)
                    {
                        robot.MoveTo(Direction.Right);
                    }
                    

                    robot.MoveTo(Direction.Down);
                    


                }
                else if (width < height)
                {
                    robot.MoveTo(Direction.Down);
                    
                    for (int i = 0; i < (height - 2) / (width - 2); i++)
                    {


                        robot.MoveTo(Direction.Right);
                    }
                    

                }
                else

                {
                    robot.MoveTo(Direction.Down);
                    
                    robot.MoveTo(Direction.Right);
                    
                }
                if (robot.Finished) break;
            }
        }
	}
}