# **Assigment 2**

## a) History of Linux and shell

**Linux** When Linus Torvalds created Linux, he certainly didn't know the importance that this project would have for the world of computing and Information Technology (IT). Thanks to his initiative, Linux is present on hundreds of thousands of servers, personal computers and portable devices around the world.
For many people, Linux is merely an operating system. This definition is not wrong, but it is not complete either. In fact, Linux is part of a whole, more precisely, it is an open-source* kernel, which has been — and is developed — over time thanks to the voluntary collaboration of developers from around the world.

**Shell** Shells—or command-line interpreters—have a long history, but this discussion begins with the first UNIX® shell. Ken Thompson (of Bell Labs) developed the first shell for UNIX called the V6 shell in 1971. Similar to its predecessor in Multics, this shell (/bin/sh) was an independent user program that executed outside of the kernel.

## b) Getting Started With Shell Programming

**Simple architecture of a hypothetical shell**

![Shell Architecture](https://developer.ibm.com/developer/default/tutorials/l-linux-shells/images/figure2.gif)

**The bash shell comes with two types of commands:**
- Internal commands (builtins) - part of the shell itself, i.e. built into the shell.
- External commands - separate binaries stored in /sbin, /usr/sbin, /usr/bin, /bin, or /usr/local/bin directories.

**Basic Terminal Navigation Commands:**
*ls :* To get the list of all the files or folders.
*ls -l:* Optional flags are added to ls to modify default behavior, listing contents in extended form -l is used for “long” output
*ls -a:* Lists of all files including the hidden files, add -a  flag 
*cd:* Used to change the directory.
*du:* Show disk usage.
*pwd:* Show the present working directory.
*man:* Used to show the manual of any command present in Linux.
*rmdir:* It is used to delete a directory if it is empty.
*ln file1 file2:* Creates a physical link.
*ln -s file1 file2:* Creates a symbolic link.
*locate:* It is used to locate a file in Linux System
*echo:*  This command helps us move some data, usually text into a file.
*df:* It is used to see the available disk space in each of the partitions in your system.
*tar:* Used to work with tarballs or files compressed in a tarball archive

## c) The Shell Variables and Environment

Created and maintained by Linux bash shell itself. This type of variable (with the exception of auto_resume and histchars) is defined in CAPITAL LETTERS. You can configure aspects of the shell by modifying system variables such as PS1, PATH, LANG,HISTSIZE,and DISPLAY etc.

BASH_VERSION 	Holds the version of this instance of bash. 	echo $BASH_VERSION
HOSTNAME 	The name of the your computer. 	echo $HOSTNAME
CDPATH 	The search path for the cd command. 	echo $CDPATH
HISTFILE 	The name of the file in which command history is saved. 	echo $HISTFILE  