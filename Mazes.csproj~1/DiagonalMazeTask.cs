using System;
using System.Security.Cryptography.X509Certificates;

namespace Mazes
{
	public static class DiagonalMazeTask
    {        
        public static void MoveOut(Robot robot, int width, int height)
		{
            var a = Math.Round((double)(width / height));
            var b = Math.Round((double)(height / width));
            while (!robot.Finished)
            {
                if (width == height)
                {
                    robot.MoveTo(Direction.Down);

                    robot.MoveTo(Direction.Right);

                    if (robot.Finished) break;
                }
                

                else if (width > height)
                {
                    for (int i = 0; i <= a+1; i++)
                    {
                        robot.MoveTo(Direction.Right);
                    }
                    

                    robot.MoveTo(Direction.Down);
                    if (robot.Finished) break;
                }
                else 
                {
                    robot.MoveTo(Direction.Down);
                    
                    for (int i = 0; i < b; i++)
                    {
                        robot.MoveTo(Direction.Right);
                        
                    }
                    if (robot.Finished) break;
                }


                if (robot.Finished) break;
            }
            

        }
	}
}