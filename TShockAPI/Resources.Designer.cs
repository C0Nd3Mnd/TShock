﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TShockAPI {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TShockAPI.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to #Format
        ///#name parent permisson1 permission2 permissionN
        ///#if there is no parent, put null instead
        ///#groups inherit permissions from their parents
        ///#put a ! before a permission to negate it
        ///#Do not remove the group default
        ///#Do not name a group SuperAdmin, that is hard-coded into the code, it grants total permissions
        ///#ALWAYS DECLARE A GROUP&apos;S PARENT BEFORE YOU DECLARE THE GROUP
        ///
        ///#currently avaliable permissions: 
        ///#reservedslot	- reserved slot for player
        ///#canwater		- allow players to use water
        ///#canlav [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string groups {
            get {
                return ResourceManager.GetString("groups", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #see https://github.com/TShock/TShock/wiki/Item-List for a list of item ids
        ///#List each banned item ID below this, with each on a new line.
        /// </summary>
        internal static string itembans {
            get {
                return ResourceManager.GetString("itembans", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  !&quot;#$%&amp;&apos;()*+,-./0123456789:;&lt;=&gt;?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz{|}~/// ¡¢£¤¥¦§¨©.
        /// </summary>
        internal static string mousefontchars {
            get {
                return ResourceManager.GetString("mousefontchars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #format
        ///#ip group
        ///#see groups.txt for a list of groups
        ///#127.0.0.1 superadmin.
        /// </summary>
        internal static string users {
            get {
                return ResourceManager.GetString("users", resourceCulture);
            }
        }
    }
}
