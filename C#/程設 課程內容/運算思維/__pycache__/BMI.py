# -*- coding: utf-8 -*-
""" 
Created on The Sep 19:48:30 2019

@author:潘凌徵

Project:
"""

height = int(input("Please input your height(cm):"))

weight = int(input("Please input your weight(kg):"))  
  
bmi = weight/(height/100)**2

print("Your bmi is",format(bmi,"5.2f"))

if(bmi<18.5):
    print("You are skinny")
else:
     if(18.5<bmi<24):
         print("Your are well shape")
         if(bmi>24):
             print("You are over weighted!")