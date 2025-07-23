// 1. Масиви int[] numbers = {1, 2, 3, 4};   [0], [1], [2], [3]             - виклик за індексами
// 2. Списки List<T>. - T - тип даних        [0], [1], [2], [3].....        - виклик за індексами
// 3. Черга Queue<T> - FIFO. - first in first out - A B C D - A.  - очередь в лікарню           - виклик за ітератором 
// 4. Стек Stack<T> - LIFO - last in first out.   - A B C D - D   - а хто крайній?              - виклик за ітератором
// 5. Словник Dictionary<Tkey, Tvalue> - ключ-значення                       - виклик за ключем contacts["Мирослав"]
// 6. HashSet<T> - зберігає унікальні! елементи, не гарантує порядок

// загальні операції в контейнерах
// .Add(item)
// .Remove(item)
// .Contains(item)
// .Count()
// .Clear()
// foreach



// 2. Списки List<T>. - T - тип даних        [0], [1], [2], [3].....        - виклик за індексами

//  .RemoveAt(index)
// .RemoveAll(умову)
// .IndexOf(value) - повертає індекс заданого значення
// .Insert(index, value) - вставити значення у вказаний індекс.        0 1 2 3 5.  .Insert(1, 7). 0 1 7 2 3 5


// 3. Словник Dictionary<Tkey, Tvalue> - ключ-значення   (map)
// словник працює парами, Tkey - first, Tvalue - second
// Tkey - ключ - завжди унікальний 
// Мама - 90980980907 <string, string>
// Мама1 - 90990120931
// {"Мама", "90980980907" ; "Мама1", "90990120931"}
// contacts["Мама"] = 90990120931

// .Add(Tkey, Tvalue);
// .ContainsKey(Tkey);
// dict[Tkey]       (dict - назва колекції)
// .Remove(Tkey)
// .Clear();
// .Count   
// foreach(var pair in dict){ pair.first та pair.second}                Tkey - first, Tvalue - second

// 4. Черга Queue<T> - FIFO. - first in first out - A B C D - A.  - очередь в лікарню           - виклик за ітератором

// FIFO - принцип 

// .Enqueue(value) - додати елемент у кінець черги
// .Dequeue(value) - видаляє і повертає перший елемент
// .Peek() - використовувати перший елемент черги
// .Count - скільки елементів в черзі
// .Clear();
// .Containts(value);

// 5. Стек Stack<T> - LIFO - last in first out.
// LIFO - принцип, приклад купи тарілок

// 1 2 3 4 5 - 5del - 1 2 3 4 - 1 2 3 - 1 2 ....

// .Push(value) - додає на вершину елемент 
// .Pop() - видаляє і повертає елемент з вершини
// .Peek() - повертає елемент з вершини
// .Clear();
// .Count 
// .Containts(value);

// 6. HashSet<T> (множина) - зберігає унікальні! елементи, не гарантує порядок (множина)

// .Add(value)
// .Contains(value)
// .Remove(value)
// .Clear()
// .Count

// *
// .SetEquals(otherSet) - порівнєю дві множини
// .UnionWith(otherSet) - поєднати дві множини
// .IntersectWith(otherSet) - залишити лише спільні елементи множин
// .ExceptWith(set) - видаляє елементи, що є в інший множині
