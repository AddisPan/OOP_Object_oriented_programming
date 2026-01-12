# -*- coding: utf-8 -*-
"""
Created on Thu Oct 31 13:51:50 2019

@author: A108222018
"""

### import code ###

###common methods ###

def area(base,height):
    return (base*height) #平行四邊形求法底乘高#

def perimeter(base,height):
    side = ((base/2)**2 + (height/2)**2)**0.5 #求菱邊#
    return side*4 #周長即為4倍菱邊長#
