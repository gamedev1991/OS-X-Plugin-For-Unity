//
//  TestMethods.hpp
//  TestPlugin
//
//  Created by Mac on 30/10/18.
//  Copyright © 2018 Suventure. All rights reserved.
//

#ifndef TestMethods_hpp
#define TestMethods_hpp
#import <Foundation/Foundation.h>
#include <stdio.h>
typedef void (*Unity_Callback1)(char * message);

extern "C" {
    const char* PrintHello ();
    int PrintANumber ();
    int AddTwoIntegers(int, int);
    float AddTwoFloats(float, float);
}
#endif /* TestMethods_h */
