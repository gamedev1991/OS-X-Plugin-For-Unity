//
//  TestMethods.cpp
//  TestPlugin
//
//  Created by Mac on 30/10/18.
//  Copyright © 2018 Suventure. All rights reserved.
//

#include "TestMethods.h"

const char* PrintHello(){
    return "Hello";
}

int PrintANumber(){
    return 5;
}

int AddTwoIntegers(int a, int b) {
    return a + b;
}

float AddTwoFloats(float a, float b) {
    return a + b;
}

extern "C"{
    void CallUnityMethod (Unity_Callback1 callbackFunc)
    {
        NSLog(@"here");
        callbackFunc(strdup([@"Calling Unity Method Success" UTF8String]));
    }
}
