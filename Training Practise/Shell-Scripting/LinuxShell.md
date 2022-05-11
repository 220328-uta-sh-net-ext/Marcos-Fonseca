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

1. Debian
Debian is renowned for being a mother to popular Linux distributions such as Deepin, Ubuntu, and Mint which have provided solid performance, stability, and unparalleled user experience. The latest stable release is Debian 10.5, an update of Debian 10 colloquially known as Debian Buster.

Note that Debian 10.5 does not constitute a new version of Debian Buster and is only an update of Buster with the latest updates and added software applications. Also included are security fixes that address pre-existing security issues. If you have your Buster system, there’s no need to discard it. Simply perform a system upgrade using the APT package manager.

Debian Linux
Debian Linux
The Debian project provides over 59,000 software packages and supports a wide range of PCs with each release encompassing a broader array of system architectures. It strives to strike a balance between cutting edge technology and stability. Debian provides 3 salient development branches: Stable, Testing, and Unstable.


freestar
The stable version, as the name suggests is rock-solid, enjoys full security support but unfortunately, does not ship with the very latest software applications. Nevertheless, It is ideal for production servers owing to its stability and reliability and also makes the cut for relatively conservative desktop users who don’t really mind having the very latest software packages. Debian Stable is what you would usually install on your system.

Debian Testing is a rolling release and provides the latest software versions that are yet to be accepted into the stable release. It is a development phase of the next stable Debian release. It’s usually fraught with instability issues and might easily break. Also, it doesn’t get its security patches in a timely fashion. The latest Debian Testing release is Bullseye.

The unstable distro is the active development phase of Debian. It is an experimental distro and acts as a perfect platform for developers who are actively making contributions to the code until it transitions to the ‘Testing’ stage.

Overall, Debian is used by millions of users owing to its package-rich repository and the stability it provides especially in production environments.

Download Debian ISO Images: http://www.debian.org/distrib/.

2. Gentoo
Gentoo is a distro built for professional use and experts who take into consideration what packages they are working with from the word go. This category includes developers, system & network administrators. As such, it’s not ideal for beginners in Linux. Gentoo comes recommended for those who want to have a deeper understanding of the ins and outs of the Linux operating system.

Gentoo Linux
Gentoo Linux
Gentoo ships with a package management system known as portage which is also native to other distros such as Sabayon, and Calculate Linux which is based on Gentoo and backward-compatible with it. It is Python-based and based on the ports’ collections concept. Port collections are sets of patches and makefiles provided for by BSD-based distros such as OpenBSD and NetBSD.

Download and Installation of Gentoo: http://www.gentoo.org/main/en/where.xml.

3. Ubuntu
Created and maintained by Canonical, Ubuntu is one of the most popular Linux distros enjoyed across the globe by beginners, intermediate users, and professionals alike. Ubuntu was specifically designed for beginners in Linux or those transitioning from mac and Windows.

Ubuntu Linux
Ubuntu Linux
By default, Ubuntu ships with GNOME desktop environment with every day out-of-the-box applications such as Firefox, LibreOffice, and image editing applications such as GIMP, music players, and video players such as Audacious and Rhythmbox.

The latest version is Ubuntu 20.04 LTS codenamed Focal Fossa. It provides numerous improvements and new features such as the new Yaru theme, new look and polished icons, great support for Snap packages, and the fractional scaling functionality that provides support for high-resolution displays.

Ubuntu forms the basis of several other Linux distributions. Some of the distributions based on Ubuntu 20.04 include Lubuntu 20.04 LTS, Kubuntu 20.04, and Linux Mint 20.04 LTS (Ulyana).

Due to its user-friendliness and elegant UI, Ubuntu is ideal for desktop users and newcomers who are trying to wrap their head around Linux. They can readily get started with default Apps as stated earlier on as they work their way towards getting a better understanding of Linux.

It’s worth mentioning Ubuntu Studio which is geared towards multimedia production. It targets creatives who are looking to make a career in graphics, photography, audio, and video production.

Download Ubuntu ISO image: https://ubuntu.com/download/desktop.

4. Linux Mint
Linux Mint is a hugely popular community-driven Linux distro based on Ubuntu. It has transcended time to provide one of the most elegant, and user-friendly distributions loved by desktop users and professionals alike. Despite the controversy surrounding the latest release – Mint 20 – dropping snap support by default, Mint remains a stable, powerful and outstanding Linux distribution.

Linux Mint Desktop
Linux Mint Desktop
To enable snap support, simply run the commands:

$ sudo rm /etc/apt/preferences.d/nosnap.pref
$ sudo apt update
$ sudo apt install snapd
Based on Ubuntu 20.04 LTS, Mint 20 is available in 3 desktop editions – Cinnamon, XFCE and MATE editions. Mint has dropped support for 32-bit versions and is only available in 64-bit. Under the hood, Linux Mint 20 rides on Linux kernel 5.4 with new enhancements such as improved support for AMD Navi 12, Intel Tiger Lake CPU and NVIDIA GPU. Additionally, the general UI has received a revamp with polished icons, new themes, high-resolution background images and a retouched taskbar.

New features include Warpinator, which is a file-sharing program that works in a LAN and fractional scaling feature for HiDPI displays to enjoy sharper and crisp images. You will also get other applications for everyday use such as Firefox, LibreOffice, Audacious music player, Timeshift, and Thunderbird.

If you want a fast and stable Linux desktop to perform day-to-day desktop tasks, listening to music, watching videos, and even gaming, Mint is the go-to distribution. Mint 20 is a long term release and will receive support until 2025. We have an article on how to install Mint 20 on your PC.

Download Linux Mint ISO Image – https://linuxmint.com/download.php

5. Red Hat Enterprise Linux
Abbreviated as RHEL, Red Hat Enterprise Linux is a Linux distro designed for Enterprise or commercial purposes. It’s one of the leading open-source alternatives to other proprietary systems such as Microsoft. Red Hat is usually a top choice for server environments given its stability and regular security patches which boost its overall security.

RHEL Linux Distribution
RHEL Linux Distribution
You can readily set it up on physical servers, virtual environments such as VMware, HyperV, and also on the cloud. Red Hat has done a perfect job in containerization technology thanks to OpenShift PaaS (platform as a service), a hybrid cloud environment that is built around Docker containers and managed by Kubernetes.

Redhat trains and certifies system administrators through specialist courses such as RHCSA (Red Hat Certified System Administrators) and RHCE (Red Hat Certified Engineer).

Where efficiency, security, and stability are of utmost priority RHEL is the ideal distro to opt for. RHEL is subscription-based and the subscription is renewed annually. You can purchase a license for an array of subscription models such as Linux Developer Workstation, Linux developer suite, and Linux for Virtual Datacenters.

Traditionally, Red Hat and its derivatives such as CentOS have used yum package manager. Things have changed now and the latest release – RHEL 8 (Ootpa) – now uses DNF as its default package manager. RHEL is distributed using 2 main repositories – AppStream repository and the BaseOS.

The AppStream repository (Application Stream) provides all the software applications that you want to install on your system while the BaseOS provides applications only for the core functionality of the system.

Additionally, you can also download and try out RedHat for free by through the Red Hat developer program.

6. CentOS
The CentOS Project is a community-driven free operating system that aims at delivering a robust and reliable open source ecosystem. Based on RHEL, CentOS is a perfect alternative to Red Hat Enterprise Linux since it is free to download and install. It gives users the stability and reliability of RHEL while allowing them to enjoy free security and feature updates. CentOS 8 is a favourite among Linux enthusiasts who want to savour the benefits of RHEL.

CentOS Linux Distribution
CentOS Linux Distribution
The latest version is CentOS 8.2 which is the third iteration of CentOS 8. It relies on App stream and BaseOS repositories and ships with the latest software packages such as Python 3.8, GCC 9.1, Maven 3.6, etc.

Download CentOS 8 – https://www.centos.org/centos-linux/.

7. Fedora
Fedora has enjoyed a reputation for being one of the most user-friendly distros for quite a while now owing to its simplicity and out-of-the-box applications which enable newcomers to easily get started.

It’s a powerful and flexible operating system that’s tailored for desktops & laptops, servers, and even for IoT ecosystems. Fedora, just like CentOS, is based on Red Hat and is in fact, a testing environment for Red Hat before transitioning to the Enterprise phase. As such, it’s usually used for development and learning purposes and comes in handy for developers and students.

Fedora Linux Distribution
Fedora Linux Distribution
Fedora has for a while now used the DNF package manager ( and still uses it as its default package manager) and offers the latest and the very best in RPM software packages. The latest Fedora is Fedora 32.

Download Fedora Linux – https://getfedora.org/.

8. Kali Linux
Developed and maintained by offensive security, Kali Linux is a Debian-based Linux distro designed for penetration testing and conducting digital forensics. It ships with out-of-the-box tools meant for penetration testing such as Nmap, Metasploit Framework, Maltego, and Aircrack-ng to mention a few.

Kali Linux Distribution
Kali Linux Distribution
Kali Linux is meant for Cybersecurity experts and students who want to venture into penetration testing. In fact, Kali provides industry-standard certifications such as Penetration Testing with Kali and Kali Linux Certified Professional.

Kali uses the APT package manager and the latest version is Kali 2020.2 and here’s a guide on how to install Kali 2020.2.

Download Kali Linux – https://www.kali.org/downloads/.

9. Arch Linux
Arch Linux is a lightweight and flexible geeky Linux distro designed for advanced users or Linux experts who care much about what is installed and the services running. It gives users the freedom to custom or configures the system, to their preference. In a nutshell, Arch is meant for users who really know the ins and outs of working with Linux.

Arch Linux
Arch Linux
Arch is a rolling release implying that it is constantly updated to the latest version and all you need is to update the packages on the terminal. It uses Pacman as the default package manager and leverages the AUR (Arch User Repository) which is a community to install software packages and the latest version is 2020.09.01.

Download Arch Linux – https://www.archlinux.org/download/.

10. OpenSUSE
The OpenSUSE project is a modern and comprehensive community project that provides 2 main SUSE branches: SUSE Leap which is a point release that targets desktop users as well as enterprise development and for testing purposes. This makes it a perfect choice for open source developers and System administrators.

OpenSuse Linux
OpenSuse Linux
On the other hand, it has SUSE Tumbleweed, a rolling release that packs the latest software stacks and IDEs and is the closest you’ll get to a bleeding-edge distro. TumbleWeed is any power user’s or software developer’s piece of cake thanks to the availability of up-to-date packages such as office applications, GCC compiler, and the kernel.

OpenSUSE relies on the Yast package manager for managing software packages and is recommended for developers and system administrators.

![Office365](https://images.idgesg.net/images/article/2017/06/microsoft-office-365-logo-2016-100727915-large.jpg?auto=webp&quality=85,70)

<a href="url"><img src="https://images.idgesg.net/images/article/2017/06/microsoft-office-365-logo-2016-100727915-large.jpg?auto=webp&quality=85,70)" align="left" height="48" width="48" ></a>
