﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBModelClass.App_GlobalResources {
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
    public class POEntityResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal POEntityResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DBModelClass.App_GlobalResources.POEntityResources", typeof(POEntityResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Master Name.
        /// </summary>
        public static string MasterID {
            get {
                return ResourceManager.GetString("MasterID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} field required max length of {1}.
        /// </summary>
        public static string MaxLengthField {
            get {
                return ResourceManager.GetString("MaxLengthField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} field required min length of {2}, max length of {1}!.
        /// </summary>
        public static string MinMaxLengthField {
            get {
                return ResourceManager.GetString("MinMaxLengthField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Purchase Order No..
        /// </summary>
        public static string PONo {
            get {
                return ResourceManager.GetString("PONo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project Name.
        /// </summary>
        public static string ProjectID {
            get {
                return ResourceManager.GetString("ProjectID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} field range is from {1} to {2}.
        /// </summary>
        public static string RangeField {
            get {
                return ResourceManager.GetString("RangeField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} field have to fullfill the Pattern.
        /// </summary>
        public static string RegexField {
            get {
                return ResourceManager.GetString("RegexField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Regex Item.
        /// </summary>
        public static string RegexItem {
            get {
                return ResourceManager.GetString("RegexItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} field is required!.
        /// </summary>
        public static string RequireField {
            get {
                return ResourceManager.GetString("RequireField", resourceCulture);
            }
        }
    }
}
