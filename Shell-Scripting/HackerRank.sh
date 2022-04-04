#! /usr/bin/bash

# HackerRank - Linux Shell

# Let's Echo 
#Write a bash script that prints the string "HELLO". 
echo HELLO

# Looping and Skipping 
#Your task is to use for loops to display only odd natural numbers from 1 to 99.
for n in {1..99}
do
    if (($n%2 != 0))
    then
        echo $n
    fi
done

# A Personalized Echo
#Write a Bash script which accepts as input and displays the greeting "Welcome (name)"
read Name
echo "Welcome $Name"

# 4) Looping with Numbers
#Use a for loop to display the natural numbers from 1 to 50.
#!/bin/bash
for i in {1..50}
do
    echo $i
done

# The world of Numbers
#Given two integers, X and Y , find their sum, difference, product, and quotient.
read X
read Y
echo $((X+Y))
echo $((X-Y))
echo $((X*Y))
echo $((X/Y))

# Comparing Numbers
#Given two integers, X and Y , identify whether X < Y or X > Y or X = Y
#Exactly one of the following lines:
# X is less than Y
# X is greater than Y
# X is equal to Y 
#!/bin/bash
read X
read Y
if (( $X > $Y ))
then
    echo "X is greater than Y"
fi

if (( $X == $Y))
then
    echo "X is equal to Y"
fi

if(( $X < $Y))
then
    echo "X is less than Y"
fi

# More on Conditionals
# Given three integers (X, Y, and Z) representing the three sides of a triangle, identify whether the triangle is scalene, isosceles, or equilateral.
# If all three sides are equal, output EQUILATERAL.
# Otherwise, if any two sides are equal, output ISOSCELES.
# Otherwise, output SCALENE.
read x
read y
read z
if ((($x == $y) && ($y == $z)))
    then
    echo "EQUILATERAL"
elif ((($x == $y) || ($x == $z) || ($y == $z)))
    then
    echo "ISOSCELES"
else
    echo "SCALENE"
fi 

# Arithmetic Operations.sh
#A mathematical expression containing +,-,*,^, / and parenthesis will be provided. Read in the expression, then evaluate it. Display the result rounded to 3 decimal places.
read x
printf "%.3f\n" `echo "$x" | bc -l`

# Compute the average.sh
# Given integers, compute their average, rounded to three decimal places. 
read num
ctr=$num
sum=0

while [ $ctr -gt 0 ]
do
   read x
   sum=$((sum + x))
   ctr=$((ctr - 1))     
done
printf "%.3f\n" `echo "$sum/$num" | bc -l`


# Cut 1
#Given N lines of input, print the 3rd character from each line as a new line of output. It is guaranteed that each of the n lines of input will have a 3rd character.
cut -c 3

# 9) Cut 2
# Display the 2nd and 7th character from each line of text.
cut -c 2,7

# Cut 3
#Display a range of characters starting at the 2nd position of a string and ending at the 7th position (both positions included).
cut -c 2-7

# Cut 4
#Display the first four characters from each line of text. 
cut -c -4

# Cut 5
#Given a tab delimited file with several columns (tsv format) print the first three fields.
cut -f 1-3

# Cut 6
#Print the characters from thirteenth position to the end.
cut -c 13-

# Cut 7
#Given a sentence, identify and display its fourth word. Assume that the space (' ') is the only delimiter between words.
cut -d " " -f 4

# Cut 8
#Given a sentence, identify and display its first three words. Assume that the space (' ') is the only delimiter between words. 
cut -d " " -f 1-3

# Cut 9
#Given a tab delimited file with several columns (tsv format) print the fields from second fields to last field.
cut -f 2-

# Tail of a Text File #1.sh
#In this challenge, we practice using the tail command to display the last lines of a text file. Display the last 20 lines of an input file.
tail -20

# Tail of a Text File #2.sh
#In this challenge, we practice using the tail command to display the last characters of a text file. Display the last 20 characters of an input file.
tail -c 20

# Head of a Text File #1.sh
#In this challenge, we practice using the head command to display the first n lines of a text file. Display the first 20 lines of an input file.
head -20

# Head of a Text File #2.sh
#In this challenge, we practice using the head command to display the first n characters of a text file. Display the first 20 characters of an input file.
head -c 20

# Middle of a Text File.sh
#Display the lines (from line number 12 to 22, both inclusive) of a given text file.
head -22 | tail -11

