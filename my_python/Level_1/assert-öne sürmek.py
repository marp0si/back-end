# -*- coding: utf-8 -*-
"""
Created on Sun May 22 16:26:40 2022

@author: _s1n4n_
"""
try:
    number = 42
    assert number > 0
    assert number < 0 , f"number greater than 0 expected, got: {number}"
    numbers = [1, 2, 3, 4, 5]
    assert 4 in numbers
    assert 10 in numbers, "10 bu dizide yok"
    x = 1
    y = x,null = None
    assert x is y
    assert x is not y,"x ve y farklı aynı şeyler değil"
    assert null is None
    number = 42
    assert isinstance(number, int)

    number = 42.0
    assert isinstance(number, int),"number bir sayı değil, yani sayı da tam sayı değil"
    assert all([True, True, True])
    assert all([True, False, True]), "hepsi aynı olması gerekirken farklı => all()"
    assert any([False, True, False])
    assert any([False, False, False]),"hepsi farklı olması gerekirken aynı=>any()"
    assert len([1, 2, 3]) > 0
except:
    pass





