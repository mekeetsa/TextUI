﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoRentalOutlet_TUI.A_TextUI_Specific {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VideoRentalOutlet_TUI.A_TextUI_Specific.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///┌─────────────────────────────────────────────────────────────────────────────┐
        ///│   1. Shortcut Keys                                                          │
        ///└─────────────────────────────────────────────────────────────────────────────┘
        ///
        ///
        ///    Ctrl+S    Save
        ///    Alt+F4    Save and E&amp;xit
        ///
        ///    F1        View help
        ///
        ///    F3        Manage price List
        ///
        ///    F4        Company details
        ///
        ///    F5        Browse customer database
        ///    Shift+F5  Find a customer
        ///    Ctrl+F5   Manage customer database
        ///
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ShortHelp {
            get {
                return ResourceManager.GetString("ShortHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///    Arrows         -  move cursor
        ///
        ///    Digits 1-9     -  replace digit in the square
        ///
        ///    Backspace, 0,  -  clear current square
        ///    Delete, Space
        ///
        ///    +, PgUp        -  increment square contents
        ///
        ///    -, PgDown      -  decrement square contents
        ///
        ///
        ///    S, F5          -  try to solve puzzle
        ///
        ///    C              -  clear all squares
        ///
        ///    X              -  lock/unlock current square
        ///
        ///    L              -  reload puzzle from file
        ///
        ///    I              -  load sudoku &apos;AI Escargot&apos;
        ///
        ///
        ///    Shift [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SudokuHelp {
            get {
                return ResourceManager.GetString("SudokuHelp", resourceCulture);
            }
        }
    }
}