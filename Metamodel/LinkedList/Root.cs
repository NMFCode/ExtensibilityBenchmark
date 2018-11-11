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
    /// The default implementation of the Root class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/georghinkel/ExtensibilityBenchmark/LinkedList")]
    [XmlNamespacePrefixAttribute("linkedList")]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/ExtensibilityBenchmark#//LinkedList/Root")]
    public partial class Root : ModelElement, IRoot, IModelElement
    {
        
        private static Lazy<ITypedElement> _headReference = new Lazy<ITypedElement>(RetrieveHeadReference);
        
        /// <summary>
        /// The backing field for the Head property
        /// </summary>
        private IItem _head;
        
        private static Lazy<ITypedElement> _tailReference = new Lazy<ITypedElement>(RetrieveTailReference);
        
        /// <summary>
        /// The backing field for the Tail property
        /// </summary>
        private IItem _tail;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Head property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IItem Head
        {
            get
            {
                return this._head;
            }
            set
            {
                if ((this._head != value))
                {
                    IItem old = this._head;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnHeadChanging(e);
                    this.OnPropertyChanging("Head", e, _headReference);
                    this._head = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.ParentChanged -= this.OnResetHead;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetHead;
                    }
                    this.OnHeadChanged(e);
                    this.OnPropertyChanged("Head", e, _headReference);
                }
            }
        }
        
        /// <summary>
        /// The Tail property
        /// </summary>
        [CategoryAttribute("Root")]
        [XmlAttributeAttribute(true)]
        public IItem Tail
        {
            get
            {
                return this._tail;
            }
            set
            {
                if ((this._tail != value))
                {
                    IItem old = this._tail;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTailChanging(e);
                    this.OnPropertyChanging("Tail", e, _tailReference);
                    this._tail = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetTail;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetTail;
                    }
                    this.OnTailChanged(e);
                    this.OnPropertyChanged("Tail", e, _tailReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new RootChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new RootReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/ExtensibilityBenchmark#//LinkedList/Root")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Head property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HeadChanging;
        
        /// <summary>
        /// Gets fired when the Head property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HeadChanged;
        
        /// <summary>
        /// Gets fired before the Tail property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TailChanging;
        
        /// <summary>
        /// Gets fired when the Tail property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TailChanged;
        
        private static ITypedElement RetrieveHeadReference()
        {
            return ((ITypedElement)(((ModelElement)(Root.ClassInstance)).Resolve("Head")));
        }
        
        /// <summary>
        /// Raises the HeadChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHeadChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HeadChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the HeadChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHeadChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HeadChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Head property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetHead(object sender, System.EventArgs eventArgs)
        {
            this.Head = null;
        }
        
        private static ITypedElement RetrieveTailReference()
        {
            return ((ITypedElement)(((ModelElement)(Root.ClassInstance)).Resolve("Tail")));
        }
        
        /// <summary>
        /// Raises the TailChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTailChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TailChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TailChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTailChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TailChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Tail property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTail(object sender, System.EventArgs eventArgs)
        {
            this.Tail = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.Head))
            {
                return ModelHelper.CreatePath("Head");
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "HEAD"))
            {
                return this.Head;
            }
            if ((reference == "TAIL"))
            {
                return this.Tail;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "HEAD"))
            {
                this.Head = ((IItem)(value));
                return;
            }
            if ((feature == "TAIL"))
            {
                this.Tail = ((IItem)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "HEAD"))
            {
                return new HeadProxy(this);
            }
            if ((reference == "TAIL"))
            {
                return new TailProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/ExtensibilityBenchmark#//LinkedList/Root")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Root class
        /// </summary>
        public class RootChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Root _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RootChildrenCollection(Root parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.Head != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.HeadChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.HeadChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Head == null))
                {
                    IItem headCasted = item.As<IItem>();
                    if ((headCasted != null))
                    {
                        this._parent.Head = headCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Head = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Head))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.Head != null))
                {
                    array[arrayIndex] = this._parent.Head;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Head == item))
                {
                    this._parent.Head = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Head).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Root class
        /// </summary>
        public class RootReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Root _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RootReferencedElementsCollection(Root parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.Head != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Tail != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.HeadChanged += this.PropagateValueChanges;
                this._parent.TailChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.HeadChanged -= this.PropagateValueChanges;
                this._parent.TailChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Head == null))
                {
                    IItem headCasted = item.As<IItem>();
                    if ((headCasted != null))
                    {
                        this._parent.Head = headCasted;
                        return;
                    }
                }
                if ((this._parent.Tail == null))
                {
                    IItem tailCasted = item.As<IItem>();
                    if ((tailCasted != null))
                    {
                        this._parent.Tail = tailCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Head = null;
                this._parent.Tail = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Head))
                {
                    return true;
                }
                if ((item == this._parent.Tail))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.Head != null))
                {
                    array[arrayIndex] = this._parent.Head;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Tail != null))
                {
                    array[arrayIndex] = this._parent.Tail;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Head == item))
                {
                    this._parent.Head = null;
                    return true;
                }
                if ((this._parent.Tail == item))
                {
                    this._parent.Tail = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Head).Concat(this._parent.Tail).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Head property
        /// </summary>
        private sealed class HeadProxy : ModelPropertyChange<IRoot, IItem>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public HeadProxy(IRoot modelElement) : 
                    base(modelElement, "Head")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IItem Value
            {
                get
                {
                    return this.ModelElement.Head;
                }
                set
                {
                    this.ModelElement.Head = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Tail property
        /// </summary>
        private sealed class TailProxy : ModelPropertyChange<IRoot, IItem>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TailProxy(IRoot modelElement) : 
                    base(modelElement, "Tail")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IItem Value
            {
                get
                {
                    return this.ModelElement.Tail;
                }
                set
                {
                    this.ModelElement.Tail = value;
                }
            }
        }
    }
}

