using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace SQLManager
{
    public class SQLManagerException : DbException
    {
        public SQLManagerException() : base() { }
        public SQLManagerException(string msg)
            : base(msg) { }

    }
}

