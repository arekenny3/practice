#! /usr/bin/python3
import re
import time

time.sleep(180)
line = "Cats are smart.er than dogs"

matchObj = re.match( r'(.*) are (.*?) .*', line, re.M|re.I)
if matchObj:
   print("matchObj.group(0) : "), matchObj.group()
   print("matchObj.group(1) : "), matchObj.group(1)
   print('matchObj.group(2) : '), matchObj.group(2)
else:
      print("No match!!")
