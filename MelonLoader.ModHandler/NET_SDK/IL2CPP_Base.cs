﻿using System;

namespace NET_SDK.Reflection
{
    public class IL2CPP_Base
    {
        public IntPtr Ptr { get; internal set; }
        internal IL2CPP_Base(IntPtr ptr)
            => Ptr = ptr;
    }
}