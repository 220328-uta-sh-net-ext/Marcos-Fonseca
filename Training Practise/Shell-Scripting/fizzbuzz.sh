#!/usr/bin/bash 

# Assigment 3
# w.a.p. in shell scripting with following conditions:
# for a number between 1 to 20, 
# print fizz if a number is divisible by 3
# print buzz if the number is divisible by 5
# print fizzbuzz if the number is divisible by both 3 and 5
# print nothing if the number isn't divisible by 3 or 5.
# create the file by name fizzbuzz.sh



# Welcome Message
echo "Welcome to the FizzBuzz" 
echo "Pick a number between 1-20"

read Number; # user input
f=3; # Fizz Variable
b=5; # Buzz Variable

if (($Number % $f == 0)) && (($Number % $b == 0)) # if the number is divisible by both 3 and 5
then 
    echo "FizzBuzz";

elif (($Number % $f == 0)) # if a number is divisible by 3
then    
    echo "Fizz";

elif (($Number % $b == 0)) # if the number is divisible by 5
then
    echo "Buzz";

else    # if the number isn't divisible by 3 or 5.
    echo "";

fi