﻿/*  
    Beethoven.Plugins - A package that is used to develop/extend plugins for the host composed by Beethoven
  
    "Whatever happens SPARTAN's code must stand ... or at least crash responsibly."
  
    The MIT License (MIT)
    
    Copyright (C) 2011 Mehmetali Shaqiri (mehmetalishaqiri@gmail.com)
 
    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:
    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.
    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;



namespace Beethoven.Plugins.MetaData
{
    /// <summary>
    /// Metadata about a given plugin
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed  class PluginMetadataAttribute : ExportAttribute, IPluginMetadata
    {
        public PluginMetadataAttribute() : base(typeof(IPluginMetadata)) { }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string PluginName { get; set; }

        /// <summary>
        /// Gets the ID of the Plugin.
        /// </summary>
        public string PluginID { get; set; }

        /// <summary>
        /// Gets the Version of the Plugin.
        /// </summary>
        public string Version { get; set; }


        /// <summary>
        /// The name of the controller
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// The display order of plugin
        /// </summary>
        public int OrderNumber { get; set; }
        
    }
}