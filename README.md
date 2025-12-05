# NC800 Relay Control

Written in C#. Still learning the language of C#. I wrote this program so as not to operate the NC800 network relay with a browser. Instead it's a stand alone program with all the conttrol buttons on one control page. 

Work as far as turning ON & OFF relays, but still having problems in changing the IPaddress/Port which works the first time, but no so the next time. Made a few changes to the client and now seems to work good.

A little more DEBUGGING needing. I decided to make the application exit after doing a IPaddress/Port change. This means you will have to restart the application.

I use the registery key HKEY_CURRENT_USER\SOFTWARE\NC800 to store the IP address & Port number. So if you RESET you NC800 relay control board, you will need to delete the NC800 registery key item also.
Maybe I'll add in a auto delete key incase an unreachable IP/Port or an option to reset the IP/Port on start if unreachable.


