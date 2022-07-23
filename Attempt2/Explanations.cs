namespace Attempt2
{
    public class Explanations
    {
        /*
         *  - the first thing I wanted was a menu screen where you could have two options:
         * to pull up your list of walks by pressing 1 or press 2 to add a walk to your list
         *   - i created a new class that would house the methods and menu text, and then called on it the program
         *  - i used a simple if statement to determine what page the user wanted to visit
         *  - i then referenced the class & method I had just made in a while loop in the program to have it running the whole time
         *      
         *
         *  - then i created a data class that contained all of our Walk properties (date and distance) and then created the
         *      constructor that passes in those properties as parameters.
         *  - in this class is also where I added the method to print our info in the console app (and to calculate our total distance walked which i will talk more about later).
         *
         *
         *  - once i had that in place i needed a list to store all of our walk data in.
         *  - to do all the things I wanted my list to do, i referenced an earlier project where I had done something very similar before so recreating the
         *      functionality was not too difficult.
         *  - i created a new class to represent the walk history page.
         *  - i created a public list that passed the data class I had just made through it with and gave it a get & set.
         *  - i then created a constructor to initialize the list
         *
         
         *  - once that was in order things got a bit trickier since I had no prior code to reference. I needed a method that would read the contents of the list and calculate the total distance walked.
         *  - I created a method to show the walk history and in it i put a foreach to go through our list and print the info of each walk and give each of them an id.
         *  - First I had to create a total distance variable that I made as 0.0 (i found out i had to put a decimal since it was a double), and then
         *     i wrote the equation that would use the foreach to add the values of each distance property together.
         *  - when i wrote the equation it wouldn't work the way I wanted so I had to ask a friend for help on how to bypass this problem and the solution they showed me was surprisingly easy.
         *  - all i had to do was generate a new distance value by creating a method that just returned the distance value. then i called on that method in the foreach i had made to print the info
         *      and then it worked the way i wanted it to.
         *
         
         *  - i then created a .txt file with the data you gave me and copied its full path into a string
         *      variable called filePath
         *  - since i now had default data that was "preloaded" in my .txt file, i needed to generate a new walk history page that contained all the data from the file.
         *  - i created a method to create a new walkhistroy page that would ultimately have to return the data  I generated from within itself.
         *  - i was unsure how to have my code actually read the file, however, so I googled ways to have the file contents be read.
         *      I found more than one way to do this and tried things like StreamReaders and StreamWriters but they werent quite what
         *      I was looking for.
         *      I eventually found the file.ReadAllText, but that ended up being to broad and I needed to be more specific. I finally found the File.ReadLines Method using a System.IO that seemed to be what I was looking for.
         *
         *  - i used a foreach to have my ReadLines method read each string line of the .txt file and passed in the filePath as a parameter to tell the foreach where to look for the contents.
         *  - once my file contents were being read I quickly arrived at another problem. The lines were being read in their entirety
         *      instead of being divided up by their date and distance like I wanted.
         *  - i went back to google to solve this and eventually found a YouTube video of a guy using a split method where you can split a string into multiple parts
         *      as long as you tell it what to look for as a divider.
         *  - i then used the comma between the date and distance to split the string into two parts (& values), 0 being the date and 1 being the distance.
         *
         
         *  - I thought this would have solved my problems, but i ran into another problem right away. The distance values of the kilometers walked were written
         *      needing to be doubles so I had to figure out how to covert them from a string to a double. This problem was a huge pain for me and took me forever.
            - once i looked up how to convert it, the computer was telling me that there was still an error and I could not figure out why. 
                I had written the convert code exactly how they had done it on the internet and still it was not working. After what felt like hours I finally made a call to a friend in the US to have him see if 
                he could spot what was wrong. Luckily he was able to determine that since I was on a european machine, my doubles were being converted with commas instead of decimals and that was breaking the code.  
                 so he told me to plug in a System.Globalization.InvariantCulture to essentially translate it and convert the double back to decimals and this worked right away. This one was really tricky to solve, but felt great once it was over. 
                The evidence became clear right away as well. Once the application was run and we viewed the walk history, all of the distances were seperated by commas and not decimals, even though they were decimals 
                in the .txt file. And in the end of course, the solution was incredibly simple. I definitely would not have been able to solve this one alone. The help was greatly appreciated. 
        
                  --- side note: upon revisting the code just now i realized that if the user puts a decimal in the the distance walked column, the code breaks as well since it cannot read the double.
                                    - i had to use the same translation technique as before to solve this, and now the user can input anything into the console and the 
                                        code does not break. If you use a comma the program will not register correctly, but as long as the user uses a decimal when inputing the distance they walked, 
                                            the code then reacts appropriately.


         * - the next step was relatively straight forward.
         * - i had to create a space for the user to be able to input new walk data. I created a method where the console read the responses from the user. The user could input a string(date) and a double(distance).
         * - i then created a method to add walk data the user input into the data list i had created by passing in the parameters i had just made in the previous method.
         * - i was then able to run my addwalk function in the foreach i had made in for my .txt file which allowed the user to add the data they input to the .txt file.
         *
         *  - one final thing I did in an attempt to make it work through a github download, was move a copy of the .txt file to the same file and change the path name.
        *  - instead of writing the full path to file on my hardrive i thought this could be a solution to send the file with the solution so that no matter who downloads it, the .txt file can be accessed.
         *  - hopefully the file can be downloaded and accessed on your end! I hope it works this time around and you are able to see that it does function the way it is supposed to! :)
        
         */
    }
}