# DevUp2015
Slides and demos from Dev Up 2015, formerly St. Louis Day(s) of .NET

Includes:
* Git Your .NET On!
* JavaScript is Not a Dirty Word
* Be the Center of the Universe with REST and ASP.NET Web API
* Full-day TDD pre-compiler

If you have any questions, please feel free to reach out to me on [Twitter] (https://twitter.com/jamesbender)

Bonus:
Some people in my Git talk asked me how I got the name of the current Git branch to show up in my command prompt. I have the following code added to my .bash_profile:

parse_git_branch() {

    git branch 2> /dev/null | sed -e '/^[^*]/d' -e 's/* \(.*\)/ (\1)/'

}

export PS1="\u@\h \W\[\033[32m\]\$(parse_git_branch)\[\033[00m\] $ "

**PLEASE NOTE!** I am using this on a MacBook Pro running Yosemite. Your milage may vary. I offer this code with NO promise or warranty that it won’t bork your system. Please do whatever back-up ritual is customary on your OS before you attempt to make this change. Good luck!