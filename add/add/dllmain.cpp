// dllmain.cpp : 定义 DLL 应用程序的入口点。
#include "pch.h"

//类似程序的入口函数main，DLL也有一个入口函数DllMain

BOOL APIENTRY DllMain( HMODULE hModule,              //指向自身的句柄
                       DWORD  ul_reason_for_call,    //调用原因
                       LPVOID lpReserved             //静态加载为非NULL ，动态加载为NULL
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:       //进程创建的时候调用
    case DLL_THREAD_ATTACH:        //线程创建的时候调用
    case DLL_THREAD_DETACH:        //线程结束的时候调用
    case DLL_PROCESS_DETACH:       //进程结束的时候调用
        break;
    }
    return TRUE;

    //系统是在什么时候调用DllMain函数的呢？
    //静态链接时，或动态链接时调用LoadLibrary和FreeLibrary都会调用DllMain函数。

    //一个程序要调用DLL里面的函数，先要把DLL文件映射到进程的地址空间。
  
}

