using System;
using System.Collections;

namespace CourseworkDenisZhukov {

    public class List<T> : IEnumerator, IEnumerable where T : IComparable {

        #region Directions

        List<T> left = null;
        List<T> right = null;
        List<T> up = null;
        List<T> down = null;

        #endregion

        List<T> currentPosition = null;

        #region Properties

        T value;
        public T Value => this.value;

        int count = 0;
        public int Count => this.count;

        int capacity = 1;
        public int Capacity => this.capacity;

        #endregion

        /// <summary>
        /// Sets the number of elements vertically.
        /// </summary>
        /// <param name="capacity">The number of elements alogn the vertical line.</param>
        public List(int capacity = 1) {
            if (capacity > 0) this.capacity = capacity;
        }

        #region Methods

        /// <summary>
        /// Adds a value horizontally to the end of the list
        /// </summary>
        /// /// <param name="value">Added value.</param>
        public void Add(T value) {
            List<T> list = this;
            for (; list.right != null; list = list.right) ;
            list.right = new List<T>(this.capacity);
            list.right.value = value;
            list.right.left = list;
            count++;
        }

        /// <summary>
        /// <br>Adds the values horizontally to the end of the list.</br>
        /// <br>Else if vertical = true, then first value of array is main node and remaining cells is extension for main node.</br>
        /// </summary>
        /// <param name="values">Array of added values.</param>
        /// <param name="vertical">Adds an array of values ​​vertically. The first element of array is the main element.</param>
        public void Add(T[] values, bool vertical = true) {
            if (values.Length == 0) return;
            if (!vertical) foreach (T value in values) this.Add(value);
            else {
                if (values.Length == 0) return;
                if (values.Length > capacity || values.Length == 0)
                    throw new Exception($"Invalid many values ​​for the main node extension.\nMaximum number of items given main node(with main node): {this.capacity}. You have passed {values.Length} items");
                this.Add(values[0]);
                for (int i = 1; i < values.Length; i++) {
                    this.ExpandMainNode(values[i], this.count - 1);
                }
            }
        }

        /// <summary>
        /// <br>The first value of arrays is main node</br>
        /// <br>The others values of arrays is his exstensions</br>
        /// </summary>
        /// <param name="values">Array of added values. The first element in each array is the main node, the rest are extensions.</param>
        public void Add(T[,] values) {
            if (values.GetLength(0) == 0 || values.GetLength(1) == 0) return;
            int length = values.GetLength(0);
            if (values.GetLength(1) > capacity || values.Length == 0)
                throw new Exception($"Invalid many values ​​for the main node extension.\nMaximum number of items given main node(with main node): {this.capacity}. You have passed {values.GetLength(1)} items");
            for (int i = 0; i < length; i++) {
                this.Add(values[i, 0]);
                for (int j = 1; j < values.GetLength(1); j++)
                    this.ExpandMainNode(values[i, j], this.Count - 1);
            }
        }

        /// <summary>
        /// Adds a value vertically to the list.
        /// </summary>
        /// <param name="value">Added value.</param>
        /// <param name="numNode">Node number for add value.</param>
        /// <returns>true if value is added; otherwise, false.</returns>
        public bool ExpandMainNode(T value, int numNode) {
            if (numNode >= this.count) return false;
            List<T> list = this.right;
            for (int i = 0; i < numNode && list != null; list = list.right, i++) ;
            for (int i = 0; i < this.capacity - 1 && list != null; list = list.down, i++) {
                if (list.down == null) {
                    list.down = new List<T>();
                    list.down.up = list;
                    list.down.value = value;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Create main node and insert that after/before index.
        /// </summary>
        /// <param name="value">Added value.</param>
        /// <param name="index">Index of element after/before will added element</param>
        /// <param name="after">Insert element after or before element</param>
        /// <returns>true if value is inserted in the list; otherwise, false.</returns>
        public bool Insert(T value, int index, bool after = true) {
            if (index >= this.count) throw new ArgumentException($"Index is out of range. Index: {index}.\nList have {this.count} element(s)\n", nameof(index));
            List<T> listBefore = after ? this.right : this;
            for (int i = 0; listBefore != null && i < index; listBefore = listBefore.right, i++) ;
            if (listBefore == null) return false;
            List<T> listAfter = listBefore.right;

            List<T> newList = new List<T>();
            listBefore.right = newList;
            if (listAfter != null) listAfter.left = newList;
            newList.left = listBefore;
            newList.right = listAfter;
            newList.value = value;

            this.count++;
            this.Reset();
            return true;
        }

        /// <summary>
        /// <br>Insert array of values in the list.</br>
        /// <br>Vertical: the first element of array is main node. The rest is extensions.</br>
        /// <br>Horizontal: all elements of array is main node.</br>
        /// </summary>
        /// <param name="values">Array of values.</param>
        /// <param name="index">The relative index of which the insert will be.</param>
        /// <param name="after">Insert values after index or before.</param>
        /// <param name="vertical">Insert values vertical or horizontal.</param>
        /// <returns></returns>
        public bool Insert(T[] values, int index, bool after = true, bool vertical = true) {
            if (values.Length == 0) return true;
            if (index >= this.count) throw new ArgumentException($"Index is out of range. Index: {index}.\nList have {this.count} element(s)\n", nameof(index));
            if (values.Length > this.capacity) throw new Exception($"There are more items passed than the list can vertically store.\nPassed {values.Length}, maximum: {this.capacity}\n");
            List<T> list = after ? this.right : this;
            for (int i = 0; list != null && i < index; list = list.right, i++) ;

            if (!vertical) for (int i = 0; i < values.Length; i++) this.Insert(values[i], index + i, after);
            if (vertical) this.Insert(values[0], index, after);
            for (int i = 1; i < values.Length && vertical; i++)
                this.ExpandMainNode(values[i], index + Convert.ToInt32(after));

            return true;
        }

        /// <summary>
        /// Removes an element and its dependent elements.
        /// </summary>
        /// <param name="index">The index of the item to remove.</param>
        public void Remove(int index) {
            if (index >= this.count) throw new ArgumentException($"Index is out of range. Index: {index}.\nList have {this.count} element(s)\n", nameof(index));
            List<T> list = this.right;
            for (int i = 0; list != null && i < index; list = list.right, i++) ;
            if (list.left != null) list.left.right = list.right;
            if (list.right != null) list.right.left = list.left;
            list.left = null;
            list.right = null;
            this.count--;
            this.Reset();
        }

        /// <summary>
        /// Removes an element and its dependent elements.
        /// </summary>
        /// <param name="index">The value of the item to remove.</param>
        public void Remove(T value) {
            (int index, int deepIndex) = this.FindIndexes(value);
            if (index == -1) return;
            this.Remove(index);
        }

        /// <summary>
        /// Checks if a value is in the list. deepSearch: true - add search of vertical.
        /// </summary>
        /// <param name="value">Finded value.</param>
        /// <param name="value">Add search of vertical.</param>
        /// <returns>true if value is found in the list; otherwise, false.</returns>
        public bool Contains(T value, bool deepSearch = false) {
            if (value == null) throw new Exception($"Method Contains dont accept value null");
            foreach (List<T> list in this) {
                if (list.value.CompareTo(value) == 0) return true;
            }
            if (deepSearch) {
                for (int i = 0; i < this.Count; i++) {
                    T[] arr = this[i];
                    for (int j = 0; j < this.Capacity; j++) {
                        if (arr[j] != null && arr[j].CompareTo(value) == 0) return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Searches for indexes in the list, returns i, j of indexes. Return -1, -1 if coincidence not found.
        /// </summary>
        /// <param name="value">Finded value.</param>
        /// <returns>Tuple of Indexes: Int32, Int32.</returns>
        public (int, int) FindIndexes(T value) {
            if (value == null) throw new Exception($"Method FindIndexes dont accept value null");
            List<T> list = this.right;
            int i = 0,
                j = 0;
            for (; list != null; list = list.right, i++) {
                if (list.value.CompareTo(value) == 0) return (i, j);
                for (List<T> listDown = list; listDown != null; listDown = listDown.down, j++) {
                    if (listDown.value.CompareTo(value) == 0) return (i, j);
                }
            }
            return (-1, -1);
        }

        /// <summary>
        /// Delete all values from the list.
        /// </summary>
        public void Clear() {
            this.right = null;
            this.count = 0;
            this.Reset();
        }

        /// <summary>
        /// Arranges for each element her depend count.
        /// </summary>
        protected void ArrangeCount() {
            int count = this.count;
            if (this.right != null) this.right.count = count;
            List<T> list = this?.right;
            for (; list != null; list = list.right, count--)
                list.count = count;
        }

        /// <summary>
        /// Swaps elements position in list.
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        private void Swap(List<T> list1, List<T> list2) {
            if (list1 == list2) return;

            List<T> list1Prev = list1.left;
            List<T> list1Next = list1.right;

            List<T> list2Prev = list2.left;
            List<T> list2Next = list2.right;

            if (list1.right == list2) {
                list1Prev.right = list2;
                if (list2Next != null) list2Next.left = list1;
                list1.right = list2Next;
                list1.left = list2;
                list2.left = list1Prev;
                list2.right = list1;
            }
            else if (list1.left == list2) {
                list2Prev.right = list1;
                if (list1Next != null) list1Next.left = list2;
                list2.right = list1Next;
                list2.left = list1;
                list1.left = list2Prev;
                list1.right = list2;
            }
            else {
                list1Prev.right = list2;
                if (list2Next != null) list2Next.left = list1;
                if (list1Next != null) list1Next.left = list2;
                if (list2Prev != null) list2Prev.right = list1;
                if (list1Prev != null) list1Prev.right = list2;
                list1.right = list2Next;
                list1.left = list2Prev;
                list2.right = list1Next;
                list2.left = list1Prev;
            }


        }

        /// <summary>
        /// Sorts by first element vertically by ASC.
        /// </summary>
        public void QuickSort() {
            if (this.Count > 0) this._QuickSort(0, Count - 1);
        }

        void _QuickSort(int left, int right) {
            if (left < right) {
                int pivot = Partition(left, right);
                _QuickSort(left, pivot - 1);
                _QuickSort(pivot + 1, right);
            }
        }

        int Partition(int left, int right) {
            T pivot = this[right, 0];
            int i = (left - 1);

            for (int j = left; j <= right - 1; j++) {
                if (this[j, 0].CompareTo(pivot) < 0) {
                    i++;
                    Swap(this[i, true], this[j, true]);
                }
            }
            Swap(this[i + 1, true], this[right, true]);
            return (i + 1);
        }

        #endregion

        #region Realization IEnumerator, IEnumerable for Foreach(T in T<T> TCollection)

        public IEnumerator GetEnumerator() {
            this.Reset();
            return (IEnumerator)this;
        }

        public bool MoveNext() {
            if (currentPosition != null) currentPosition = currentPosition.right;
            else currentPosition = this.right;
            return (currentPosition != null);
        }

        public void Reset() {
            this.ArrangeCount();
            currentPosition = null;
        }

        public object Current {
            get => currentPosition;
        }

        #endregion

        #region Indexers
        public List<T> this[int index, bool isList] {
            get {
                if (!isList) return null;
                else {
                    if (index >= this.count)
                        throw new ArgumentException($"Index is out of range. Index: {index}.\nList have {this.count} element(s)\n", nameof(index));

                    List<T> list = this.right;
                    for (int i = 0; i < index; i++, list = list.right) ;
                    return list;
                }
            }
        }

        /// <summary>
        /// You get array of values from the list by indexes.
        /// </summary>
        /// <param name="index">Index of node</param>
        /// <returns>Array of values(column)</returns>
        public T[] this[int index] {
            get {
                if (index >= this.count)
                    throw new ArgumentException($"Index is out of range. Index: {index}.\nList have {this.count} element(s)\n", nameof(index));
                T[] col = new T[capacity];
                List<T> list = this;
                if (list != null && list.value == null && list.right != null) list = list.right;
                for (int i = 0; i < this.count && list != null; list = list.right, i++) {
                    if (i == index) {
                        for (int j = 0; j < this.capacity && list != null; list = list.down, j++)
                            col[j] = list.value;
                        return col;
                    }
                }
                throw new Exception($"An unknown error has occurred");
            }
        }

        /// <summary>
        /// You access the list by indexes.
        /// </summary>
        /// <param name="indexHorizontal">Index of node</param>
        /// <param name="indexVertical">Index of node extensions</param>
        /// <returns>Value from list.</returns>
        public T this[int indexHorizontal, int indexVertical] {
            get {
                if (indexHorizontal >= this.count || indexVertical >= capacity)
                    throw new ArgumentException($"Index is out of range. Index: {indexHorizontal} {indexVertical}.\nList have {this.count} element(s) and {this.capacity} expended items.\n", nameof(indexHorizontal));
                List<T> list = this.right;
                for (int i = 0; i < indexHorizontal && list != null; list = list.right, i++) ;
                for (int i = 0; i < indexVertical && list != null; list = list.down, i++) {
                    if (i + 1 != indexHorizontal && list.down == null) {
                        list.down = new List<T>();
                        list.down.up = list;
                    }
                }
                if (list != null) return list.value;
                else if (list == null) return this.value; //Nullable value of type T
                throw new Exception($"An unknown error has occurred");
            }
            set {
                if (indexHorizontal >= this.count || indexVertical >= capacity)
                    throw new ArgumentException($"Index is out of range. Index: {indexHorizontal} {indexVertical}.\nList have {this.count} element(s) and {this.capacity} expended items.\n", nameof(indexHorizontal));
                List<T> list = this.right;
                for (int i = 0; i < indexHorizontal && list != null; list = list.right, i++) ;
                for (int i = 0; i < indexVertical && list != null; list = list.down, i++) {
                    if (i + 1 != indexHorizontal && list.down == null) {
                        list.down = new List<T>();
                        list.down.up = list;
                    }
                }
                if (list != null) list.value = value;
                else throw new Exception($"An unknown error has occurred");
            }
        }

        #endregion
    }

}