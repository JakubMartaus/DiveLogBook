using System;
using System.Collections.Generic;
using System.Text;

namespace DiveLogBook
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
