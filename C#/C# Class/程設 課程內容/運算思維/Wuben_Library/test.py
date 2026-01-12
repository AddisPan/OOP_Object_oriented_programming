# -*- coding: utf-8 -*-
"""
Created on Thu Oct 31 13:51:50 2019

@author: A108222018
"""
### environment setting ###



### import code ###
import circle
import rectangle
import diamond
import random
### global data ###
CIRCLE_AREA = 0
CIRCLE_CIRCUMERENCE= 1
RECTANGLE_AREA = 2
RECTANGLE_PERIMETER = 3
DIAMOND_AREA = 4
DIAMOND_PERIMETER = 5
NUM_CHOICE = 6

###common methods ###
def makeChoice():
    print("0:circle area")
    print("1:circle circumference")
    print("2:rectangle area")
    print("3:rectangle perimeter")
    print("4:diamond area")
    print("5:diamond perimeter")
    print("others to quit")
    
    try:
        choice = int(input("your chioce:"))
    except:
        choice = NUM_CHOICE #超出範圍choice的值一律定NUM_CHOICE，也就是6#
    return choice #怕程式崩壞，意外狀況的處理。ex:choice沒值-->程式崩壞#

if __name__ == '__main__': #直接執行此程式，才可觸發以下代碼(import導入則不行)#
                           #金玲本來要把test.py導入至其他程式中，屆時__name__的值則會變為test，不等於__main__-->非成立#
    choice = makeChoice()
    while(0 <= choice and choice < NUM_CHOICE):
        if(choice == CIRCLE_AREA):
            radius=random.randint(2,10) #2~10隨機選取一個整數，ex:random.randint(2,10.3)則是3,6,9中選取#
            print("Radius",radius,"\n","area is -->",circle.area(radius))
            
        elif(choice == CIRCLE_CIRCUMERENCE):
            radius=random.randint(2,10)
            print("Radius",radius,"\n","circumference is -->",circle.circumference(radius))
            
        elif(choice == RECTANGLE_AREA):
            length=random.randint(2,10)
            width=random.randint(2,10)
            print("Length",length,"\n","Width",width,"\n","area is -->",rectangle.area(length,width))
            
        elif(choice == RECTANGLE_PERIMETER):
            length=random.randint(2,10)
            width=random.randint(2,10)
            print("Length",length,"\n","Width",width,"\n","perimeter is -->",rectangle.perimeter(length,width))
        elif(choice == DIAMOND_AREA):
            base=random.randint(2,10)
            height=random.randint(2,10)
            print("Base",base,"\n","Height",height,"\n","area is -->",diamond.area(base,height))
        elif(choice == DIAMOND_PERIMETER):
            base=random.randint(2,10)
            height=random.randint(2,10)
            print("Base",base,"\n","Height",height,"\n","area is -->",diamond.perimeter(base,height))
        print("\n")
        choice = makeChoice() #防止無限迴圈，須將choice的值改變#
            
            
            

    