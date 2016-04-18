﻿using System;
using System.IO;

namespace SuperPutty.Data
{
    public class LayoutData
    {
        public const string AutoRestore = "<Auto Restore>";
        public const string AutoRestoreLayoutFileName = "AutoRestoreLayout.XML";

        public LayoutData(string filePath)
        {
            this.FilePath = filePath;
            this.Name = Path.GetFileNameWithoutExtension(filePath);
            this.IsDefault = (this.Name == SuperPuTTY.Settings.DefaultLayoutName);
        }

        public string Name { get; set; }
        public string FilePath { get; set; }

        public bool IsReadOnly { get; set; }

        public bool IsDefault;

        public override string ToString()
        {
            return IsDefault ? String.Format("{0} (default)", this.Name) : this.Name;
        }
    }

    public class LayoutChangedEventArgs : EventArgs
    {
        public LayoutData New { get; set; }
        public LayoutData Old { get; set; }
        public bool IsNewLayoutAlreadyActive { get; set; }
    }
}
