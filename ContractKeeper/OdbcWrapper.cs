﻿using System.Text;
using System.Runtime.InteropServices;

namespace ContractKeeper
{
    public static class OdbcWrapper
    {
        [DllImport("odbc32.dll")]
        public static extern int SQLDataSources(int EnvHandle, int Direction, StringBuilder ServerName, int ServerNameBufferLenIn,
    ref int ServerNameBufferLenOut, StringBuilder Driver, int DriverBufferLenIn, ref int DriverBufferLenOut);

        [DllImport("odbc32.dll")]
        public static extern int SQLAllocEnv(ref int EnvHandle);
    }
}
