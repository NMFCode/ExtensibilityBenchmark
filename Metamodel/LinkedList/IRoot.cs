//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.ExtensibilityBenchmark.LinkedList
{
    
    
    /// <summary>
    /// The public interface for Root
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Root))]
    [XmlDefaultImplementationTypeAttribute(typeof(Root))]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/ExtensibilityBenchmark#//LinkedList/Root")]
    public interface IRoot : IModelElement
    {
        
        /// <summary>
        /// The Head property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        IItem Head
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Tail property
        /// </summary>
        [CategoryAttribute("Root")]
        [XmlAttributeAttribute(true)]
        IItem Tail
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Head property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HeadChanging;
        
        /// <summary>
        /// Gets fired when the Head property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HeadChanged;
        
        /// <summary>
        /// Gets fired before the Tail property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TailChanging;
        
        /// <summary>
        /// Gets fired when the Tail property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TailChanged;
    }
}

