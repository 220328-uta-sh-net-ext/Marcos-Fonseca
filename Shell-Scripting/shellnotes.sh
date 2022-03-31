#! /usr/bin/bash

# Chapter 4: Conditionals Execution (Decision Making)
# Chapter 4: Conditionals Execution (Decision Making)
# Chapter 4: Conditionals Execution (Decision Making)

# Conditions
[[ -z STRING ]] 	    #Empty string
[[ -n STRING ]] 	    #Not empty string
[[ STRING == STRING ]] 	#qual
[[ STRING != STRING ]] 	#Not Equal
[[ NUM -eq NUM ]] 	    #Equal
[[ NUM -ne NUM ]] 	    #Not equal
[[ NUM -lt NUM ]]   	#Less than
[[ NUM -le NUM ]]   	#Less than or equal
[[ NUM -gt NUM ]]   	#Greater than
[[ NUM -ge NUM ]]   	#Greater than or equal
[[ STRING =~ STRING ]] 	#Regexp
(( NUM < NUM ))     	#Numeric conditions
[[ -o noclobber ]] 	    # If OPTIONNAME is enabled
[[ ! EXPR ]] 	        # Not
[[ X && Y ]] 	        # And
[[ X || Y ]] 	        # Or

# File conditions
[[ -e FILE ]] 	        # Exists
[[ -r FILE ]] 	        # Readable
[[ -h FILE ]] 	        # Symlink
[[ -d FILE ]]       	# Directory
[[ -w FILE ]] 	        # Writable
[[ -s FILE ]] 	        # Size is > 0 bytes
[[ -f FILE ]] 	        # File
[[ -x FILE ]] 	        # Executable
[[ FILE1 -nt FILE2 ]] 	# 1 is more recent than 2
[[ FILE1 -ot FILE2 ]] 	# 2 is more recent than 1
[[ FILE1 -ef FILE2 ]] 	# Same files

# String
if [[ -z "$string" ]]; then
  echo "String is empty"
elif [[ -n "$string" ]]; then
  echo "String is not empty"
else
  echo "This never happens"
fi

# Combinations
if [[ X && Y ]]; then
  ...
fi

# Equal
if [[ "$A" == "$B" ]]

# Regex
if [[ "A" =~ . ]]

if (( $a < $b )); then
   echo "$a is smaller than $b"
fi

if [[ -e "file.txt" ]]; then
  echo "file exists"
fi


# Chapter 5: Bash Loops
# Chapter 5: Bash Loops
# Chapter 5: Bash Loops

# Basic for loop
for i in /etc/rc.*; do
  echo $i
done

# Reading lines
cat file.txt | while read line; do
  echo $line
done

# C-like for loop
for ((i = 0 ; i < 100 ; i++)); do
  echo $i
done

# Forever
while true; do
  ···
done

# Ranges
for i in {1..5}; do
    echo "Welcome $i"
done

# With step size
for i in {5..50..5}; do
    echo "Welcome $i"
done




