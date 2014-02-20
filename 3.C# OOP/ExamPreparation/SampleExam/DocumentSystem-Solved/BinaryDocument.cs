﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class BinaryDocument : Document, IDocument
{
    public ulong Size { get; protected set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "size")
        {
            this.Size = ulong.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("size", this.Size));
        base.SaveAllProperties(output);
    }
}