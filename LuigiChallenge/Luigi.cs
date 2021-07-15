using System;
using System.Collections.Generic;

namespace LuigiChallenge
{
    public class Luigi
    {
        private IEnumerable<int> map1;

        public Luigi()
        {
           //foreach (int i in map1)
            //{
               // if(i != 0)
                //{
                 //   return "Right";
                //}
            //}
        }


//Guide Luigi home by following the trail of "0"s from left to right and top to bottom in the 2D matrix.

//Give him directions with two commands:

//"Down" or "Right";

            

        



//Example:
//input:

//        [4,0,4]
//        [5,0,0]
//        [6,9,0]
//        [8,3,0]

//        output:

//String "Down Right Down Down"

//(Note: In all the tests Luigi will have clear path.So there will only be a "0" below or to the right of each other.No isolated "0"s or "0"s moving back left.)


        public string GoHome2D(int[][] map)
        {
            int count2 = 0;
            string Result = "";
            foreach(int[] zero in map )
            {
                count2++;
                
                int count = 0;
                foreach (var z in zero)
                {
                    
                    
                    if(z == 0)
                    {
                        count++;
                        
                    }
                    if(count > 1 && z == 0)
                    {
                        Result += "Right ";
                    }
                }
                if(count2 < map.Length)
                {
                    Result += "Down ";
                }
                
            }
//foreach(int[] otherNum in map)
            //{
            //foreach(var o in otherNum)
               // {
                    //Result += "Down ";
                //}
                
            //
            return Result.Trim();
        }
    }
}
