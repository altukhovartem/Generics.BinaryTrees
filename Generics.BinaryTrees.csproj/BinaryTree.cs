﻿using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// нода дерева должна реализовывать интерфейс IEnumerable
/// едиснтвенный метод этого интерфейса это GetEnumerator
/// тебе надо написать класс, который в конструкторе принимает ноду дерева, которую попросили перечислиться, и который реализует интерфейс IEnumerator
/// вспоминай во что превращается форыч и что это за интерфейсы
/// держи в голове что нода выполняет сразу две роли
/// она и носитель значения, и корень какого то поддерева
/// IEnumerable - то что можно перечислить, IEnumerator - то что умеет что-то перечислять
/// </summary>

namespace Generics.BinaryTrees
{
    public class BinaryTree<T> : IEnumerable<T>
        where T:IComparable
    {
        private BinaryTree<T> left;
        public BinaryTree<T> Left
        {
            get {
                    if (left == null)
                    {
                        left = new BinaryTree<T>();
                    }
                    return left;
                }
            set { left = value; }
        }
        private BinaryTree<T> right;
        public BinaryTree<T> Right
        { 
            get
            {
                if (right == null)
                {
                    right = new BinaryTree<T>();
                }
                return right;
            }
            set { right = value; }
        }

        public BinaryTree<T> Parent { get; set; }

        public T Value { get; set; }
        private bool HasValue = false;
        public bool SuperHasValue { get { return HasValue; } set { HasValue = value; } }

        public IEnumerator<T> GoAroundTheTree(BinaryTree<T> currentTree)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T value)
        {
            if (HasValue == false)
            {
                this.Value = value;
                HasValue = true;
                return;
            }
            else
            {
                if (value.CompareTo(this.Value) == 1)
                {
                    Insert(value, Right);
                }
                else if ((value.CompareTo(this.Value) == -1))
                {
                    Insert(value, Left);
                }
            }
        }

        private void Insert(T value, BinaryTree<T> currentNode)
        {
            if (currentNode.HasValue == false)
            {
                currentNode.Value = value;
                currentNode.HasValue = true;
                return;
            }

            int comparisonValue = value.CompareTo(currentNode.Value);
            if (comparisonValue == 1)
            {
                Insert(value, currentNode.Right);
            }
            else if (comparisonValue == -1)
            {
                Insert(value, currentNode.Left);
            }
            
        }

      
    }

    public static class BinaryTree
    {
        public static BinaryTree<int> Create(params int[] items)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            for (int i = 0; i < items.Length; i++)
            {
                binaryTree.Add(items[i]);
            }
            return binaryTree;
        }
    }

}


