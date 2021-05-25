﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace System.Dors
{
    public interface IDataTreeBinder
    {
        string TreeNodeName { get; }
        object TreeNodeTag { get; }
        IDataTreeBinder[] TreeNodeChilds { get; }
        IDataTreeBinder BoundedTree { get; set; }
    }
    
}