#Distraction Blocking Hosts File
A hosts file designed to block distracting websites


If all you need is the distraction blocking hosts file then have a look at new_hosts_file.txt

Just copy and paste the contents of that into the contents your system hosts file, whereever that may be. On Windows its c:\windows\system32\drivers\etc\hosts and on Ubuntu it's /etc/hosts


If you're wanting the tool for adding sites to a hosts file then check out the visual studio solution

Please note that the tool does not overrwrite your active hosts file for you, its just creates a template for a new one.  You'll need to manually replace your hosts file with the one generated by this tool. I don't want this app to freak out any antivirus by screwing around with actual hosts files. Might do that in a later version.


Todo:

-Tidy the code. This was rushed (about 10-20 minutes dev time)

-Look at making it replace the actual hosts file

-Right click to delete or edit hosts

-Further enhancements
