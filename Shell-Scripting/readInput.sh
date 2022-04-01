#! /usr/bin/bash

# ctrl+k+C to comment the selection
# ctrl+k+U to uncomment the selection



# Take input from user and the also save its value in the variable mentioned
echo "Enter your name: "
read name  
echo "Hello $name"

# Arrays - multi collection of values placed one after another (indexed)
echo "Enter names: "
read -a names 
echo "The names are: ${names[0]}, ${names[1]}, ${names[2]}"

# Print the Input without a variable
echo "Hello put some text and see results: "
read
echo "results: $REPLY"

# User and Password Input
read -p "Username: " username
read -sp 'Password: ' password
echo
echo "username is $username"
echo "password is $password"

# Start a script passing the argument
echo $0 $1 $2 $3 ' > echo $1 $2 $3'
args=("$@")
echo ${args[0]} ${args[1]} ${args[2]} ${args[3]}
echo $@ #print the arguments passed
echo $# #print the numeber os arguments passed

# If Statement 

count=10
if [ $count -gt 9 ]     #for -eq -ne -gt -ge -lt -le uses [ ]
then
    echo "Condition is True"
fi

if (($count > 9))       #for < <= > >= uses (( ))
then
    echo "Condition is True"
fi