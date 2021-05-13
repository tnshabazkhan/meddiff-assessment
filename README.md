# meddiff-assessment
This Repo contains the solution for various problem statements. Such as Palindrom, group files by owner name, Custom Change Directory operation, Parse Error logs lines and write into a different log file.

How to Run the application:

1. open project in visual studio
2. Build and Run the project which will run Problem 1-4 solutions
3. Alternatively, each problem is segregated into a function which can be copied and used individually.

Problem 1 (Group files according to owner names):

Algorithm crafted: 

1. Take input dictionary of type Dictionary<string, string> and an output dictionary of type Dictionary<string, List<string>>.
2. Iterate over input dictionary.
3. If the author key is not present in output dictionary, then add the author key and initialise the value to a list of 1 book(current book).
4. If author key is already present in output dictionary, then update the List corresponding to it by adding the current book to the dictionary.
5. return the output dictionary.

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Problem 2 (Palindrome):

Algorithm crafted: 

1. Take the input string.
2. Loop from 0th index to mid half index of the string(i.e if string is of length 11, loop for indices 0 till 11/2, which is 5). Also have a negative index which goes from End 
	the string to the middle.
3. As we iterate, compare the char pointed by positive index and negative index.
4. If anywhere any character mismatches untill the loop completes, break the loop and return IsPalindrome as false.
5. Else if the loop completes, return IsPalindrome as true.

Note - We donot have to worry about the mid index charecter in Odd Length Palindrome. Hence we can use same logic for both Odd and Even Palindromes

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Problem 3 (Parse log file and extract errors into a seperate file):

Algorithm crafted: 

1. Take the input path of the log file.
2. Read the file using ReadAllLines method, which gives and array of string, each entry is a line in the log file.
3. Loop through the string array and for each line, check if the line contains any of these 3 key words -> "[FATAL]", "[ERROR]", "[WARN]"
4. If any line contains the above keywords, then take those lines into a List of strings.
5. Write the List of strings into the error.log file in the input file directory.

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Problem 4 (Custom Change Directory(cd)):

Algorithm crafted: 

1. Create an object of Path class and set the CurrentPath to initialise the path.
2. Call path.cd() methdo with the string to change directory.
3. Check if the string passed starts with ".." if it does it means that it is a relative path, so take the current path and shorten it to get it's parent and append the rest of the path after "..".
4. Else Check if the string passed doesn't starts with "/" either, if it doesn't start with "/" then again it is a relative path, and hence append the input of cd to the current path.
5. Else if the path starts with "/", then the path is an absolute path, hence we don't care about the current path and just take the input path recived from parameters.
6. Once the above steps are done, we run a while loop to get the index of ".." in the path and if we find it, we remove the directory once level above the ".." along with the dots from the path.
	Ex: path.cd("/Folder1/Folder2/../Folder3") will become just "/Folder1/Folder3", the previous directory of ".." is removed along with the ".."
7. Once all the ".." characters are replaced in the string, the cd operation is complete.
8. return the final path.
9. In case any operation is causing an exception during string operations, it is due to incorrect or invalid Folder path, hence we catch it and return Cannot find the speacified folder
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
