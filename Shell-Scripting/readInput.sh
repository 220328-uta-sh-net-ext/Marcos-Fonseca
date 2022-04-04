#! /usr/bin/bash

# ctrl+k+C to comment the selection
# ctrl+k+U to uncomment the selection


# 1) Take input from user and the also save its value in the variable mentioned
echo "Enter your name: "
read name  
echo "Hello $name"

# Arrays - multi collection of values placed one after another (indexed)
echo "Enter names: "
read -a names 
echo "The names are: ${names[0]}, ${names[1]}, ${names[2]}"

# Array
os=('Ubuntu' 'Windowns' 'Kali')

os[3]='Mac'     #Add element
unset os[2]     #Remove element

echo "${os[@]}"
echo "${os[1]}"
echo "${!os[@]}"    #Print the number of index
echo "${#os[@]}"    #Print the lenght

string=testeteste
echo "${string[@]}"

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

# 4) Start a script passing the argument
echo $0 $1 $2 $3 ' > echo $1 $2 $3'
args=("$@")
echo ${args[0]} ${args[1]} ${args[2]} ${args[3]}
echo $@ #print the arguments passed
echo $# #print the numeber os arguments passed

# 5) If Statement 
count=10
if [ $count -gt 9 ]     #for -eq -ne -gt -ge -lt -le uses [ ]
then
    echo "Condition is True"
else
    echo "Condition is False"
fi

count=10
if (($count > 12))       #for < <= > >= uses (( ))
then
    echo "Condition is True"
else
    echo "Condition is False"
fi

word=c
if [[ $word == "b" ]] 
then
    echo "Condition b is True"
elif [[ $word == "a" ]]
then
    echo "Condition a is True"
else
    echo "Condition is False"

# 6) File Test Operator
echo -e "Enter the name of the file : \c"
read file_name

if [ -e $file_name ]
then 
    echo "$file_name found"
else
    echo "$file_name not found!"
fi

echo -e "Enter the name of the file : \c"
read file_name

# 7) How to append output to the end of text file
if [ -f $file_name ]
then 
    if [ -w $file_name ]
    then
        echo "Type som text data. To quit press ctrl+d"
        cat >> $file_name
    else
        echo "The file do not have write permission"
    fi
else
    echo "$file_name not exists"
fi

# 8) Logical 'AND' Operator
age=25

if  [ "$age" -gt 18 ] && [ "$age" -lt 30 ] #or if  [ "$age" -gt 18 -a "$age" -lt 30 ]
then
    echo "Valid age"
    else
    echo "Age not valid"
fi

# 9) Logical 'OR' Operator
age=30

if  [ "$age" -eq 18 ] || [ "$age" -eq 30 ] #or if  [ "$age" -eq 18 -o "$age" -eq 30 ]
then
    echo "Valid age"
    else
    echo "Age not valid"
fi

# 10) Perform arithmetic operations
num1=20
num2=5

echo $(( num1 + num2 ))     #or $( expr $num1 + $num2 )
echo $(( num1 - num2 ))     #or $( expr $num1 - $num2 )
echo $(( num1 * num2 ))     #or $( expr $num1 \* $num2 )
echo $(( num1 / num2 ))     #or $( expr $num1 / $num2 )
echo $(( num1 % num2 ))     #or $( expr $num1 % $num2 )

# 12) The case statement
vehicle=$1

case $vehicle in #expression
    "car" ) #pattern1
        echo "Rent of $vehicle is 100 dollar" ;; #statement1
    "van" ) #pattern2
        echo "Rent of $vehicle is 80 dollar" ;; #statement2
    "bike" ) #pattern3
        echo "Rent of $vehicle is 5 dollar" ;; #statement3
    "truck" ) #pattern4
        echo "Rent of $vehicle is 250 dollar" ;; #statement4
    "bus" ) #pattern5
        echo "Rent of $vehicle is 300 dollar" ;; #statement5
    * )
    echo "Unknown Vehicle";; #Default condition
esac

# 13) The case statement Example
echo -e "Enter some character : \c"
read value

case $value in #expression
    [a-z] ) #pattern1
        echo "User entered $value a to z" ;; #statement1
    [0-9] ) #pattern2
        echo "User entered $value 0 to 9" ;; #statement2
    ? ) #pattern3
        echo "User entered $value special character" ;; #statement3
    * )
    echo "Unknown Vehicle";; #Default condition
esac

# 15) WHILE Loops
n=1
while [ $n -le 50 ]     #or (( $n <= 10 ))
do
    echo "$n"            
    n=$(( n+1 ))        #or (( n++ ))
    #sleep 1 to set a delay on the loop
done

# 17) Read a file content in Bash
while read p   
do
    echo $p              
done < README.md

#or
cat README.md | while read p 
do
    echo $p
done

#or
while IFS= read -r line 
do
    echo    $line
done < README.md

# 18) UNTIL loop
n=1
until [ $n -ge 10 ] #or (( $n > 10 ))
do
    echo $n
    n=$((n+1))  
done

# 19) FOR loop
echo ${BASH_VERSION}
for (( i=0; i<5; i++ )) # {1..100..20}
do
echo $i
done

# 20) FOR loop to execute commands
for command in ls pwd date
do
echo "-----------$command-------------"
$command
done

for item in *
do
    if [ -d $item ]
    then
        echo $item
    fi 
done

# 21) Select loop (When you need a Menu)
select name in Mark John Tom Ben 
do
    case $name in 
    Mark)
        echo Mark selected
        ;;
    John)
        echo Mark selected
        ;;
    Tom)
        echo Mark selected
        ;;
    Ben)
        echo Mark selected
        ;;
    *) #Default Pick
        echo "Error, please provide a pick"
    esac    
done

# 22) Break and continue

for (( i=1 ; i<=10 ; i++)) 
do
    if [ $i -gt 5 ]
    then
        break #BREAK
    fi 
    echo "$i"
done

for (( i=1 ; i<=10 ; i++)) 
do
    if [ $i -eq 3 -o $i -eq 6 ]
    then
        continue #CONTINUE
    fi 
    echo "$i"
done


# 23) Functions
function print(){
    echo $1
}

quit (){
    exit
}

print Hello
print World

echo "foo"

quit

# 24) Local Variables
function print(){
    local name=$1
    echo "The name is $name"
}
name="Tom"
echo "The name is $name : before"
print max
echo "The name is $name : after"

# 25) Functions Example
usage() {
    echo "You need to provide an argument : "
    echo "Usage : $0 file_name"
}

is_file_exist() {
    local file="$1"
    [[ -f "$file" ]] && return 0 || return 1
}

[[ $# -eq 0 ]] && usage

if ( is_file_exist "$1" )
then
    echo "File Found"
else
    echo "File not found"
fi

# 27) Signals and Traps
echo "pid is $$"
while (( COUNT < 10 ))
do
    sleep 1
    (( COUNT ++ ))
    echo $COUNT
done
exit 0



