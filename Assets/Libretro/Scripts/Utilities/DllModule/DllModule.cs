﻿using System;

namespace SK.Utilities
{
    public abstract class DllModule
    {
        public string Name { get; protected set; } = string.Empty;

        protected IntPtr _nativeHandle = IntPtr.Zero;

        public abstract bool Load(string path);
        public abstract bool GetFunction<T>(string functionName, out T functionPtr) where T : Delegate;
        public abstract void Free();
    }
}