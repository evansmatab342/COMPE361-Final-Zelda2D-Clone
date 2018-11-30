using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zelda2D_Clone.Levels_and_Movement
{
    /*This class is used to produce a level. 
     * It will divide the screen into squares, represented by "2D" list. 
     * This list is called for each new screen.
     */
    public class Level_Management
    {
        //Contains the current directive to a level
        public string currLevel;

        //Used to contain a level.
        List<List<int>> aLevel = new List<List<int>>();
        List<List<int>> bLevel = new List<List<int>>();
        //Also used to contain a level. The manager switches between these two when loading levels. 
        //This allows us to have two levels at a time. 
        //Meaning, if the player wants to go back to the previous level they won't have to defeat every enemy again.

        //Used to keep track of adjacent files. Order: Up, down, left, right
        string[] adjLevels;

        //Default constructor fills the lists with 0s.
        public Level_Management()
        {
            //Used to add empty lists of integers
            List<int> zeros = new List<int>();
            for(int i = 0; i < 25; ++i)
            {
                zeros.Add(0); 
            }
            for (int line = 0; line < 25; ++line)
            {
                    aLevel.Add(zeros);
                    bLevel.Add(zeros);
            }
        }
        /* This is used to select which level will be chosen next. Levels are divided into subscreens.
         * As such there will be a similar class used to determine which screen comes next.
         * Level_Selector can only choose adjacent levels. Each level contains a reference to adjacent levels.
         */ 
        public bool Level_Selector(/*string currLevel*/)
        {

            //Master always runs. Determines which level player left off.
            currLevel = File.ReadLines("Master.txt").Take(1).First();
            return false;
        }
        
        /* Grabs a specific set of characters from the string and puts it into the string
         * Current level from master file are 15 and 16
         */ 
        private string stringSelector(int indexOne, int indexTwo = 0)
        {
            try
            {
                return "currLevel[indexOne]" + "currLevel[indexTwo]";
            }
            catch(IndexOutOfRangeException)
            {
                return "currLevel[0]";  //Return the first character by default.
            }
            
        }
        /* The following loads a level, as specified by the string passed into it.
         * We iterate through the text file and load every value into the list.
         * 11 30 2018 changing to public for debugging change later to private
         */
        public void levelLoader(string level)
        {
            int line;       //Used to iterate through each line in a text file
            string lineString;  //Used to load line. Each character is then read and translated into integers. The integers are then placed in the aLevel/bLevel List
            int i = 0;      //Used to iterate through integers
            try
            {
                for (line = 0; line < 25; ++line)
                {
                    lineString = File.ReadLines(level).Skip(line).Take(1).First();
                    foreach (char tile in lineString)
                    {
                        aLevel[line][i++] = (int)Char.GetNumericValue(tile); //From the list we access the value, We then convert the character from the line string into an integer.
                    }
                }
            }
            //Exception handling not done
            catch(IndexOutOfRangeException excp)
            {
                //Create a control to output "Could not load the level correctly. Closing..."
            }
        }


    }
}
